/**
* 类名:clsvRTViewpointRelaWApi
* 表名:vRTViewpointRela(01120541)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:44
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vRTViewpointRela_GetObjFromJsonObj = exports.vRTViewpointRela_CopyObjTo = exports.vRTViewpointRela_GetCombineCondition = exports.vRTViewpointRela_GetObjByJSONStr = exports.vRTViewpointRela_GetObjLstByJSONObjLst = exports.vRTViewpointRela_GetObjLstByJSONStr = exports.vRTViewpointRela_GetJSONStrByObj = exports.vRTViewpointRela_GetWebApiUrl = exports.vRTViewpointRela_GetRecCountByCondAsync = exports.vRTViewpointRela_IsExistAsync = exports.vRTViewpointRela_IsExist = exports.vRTViewpointRela_IsExistRecordAsync = exports.vRTViewpointRela_GetObjLstByPagerAsync = exports.vRTViewpointRela_GetObjLstByRange = exports.vRTViewpointRela_GetObjLstByRangeAsync = exports.vRTViewpointRela_GetTopObjLstAsync = exports.vRTViewpointRela_GetObjLstBymIdLstAsync = exports.vRTViewpointRela_GetObjLstAsync = exports.vRTViewpointRela_GetFirstObjAsync = exports.vRTViewpointRela_GetFirstID = exports.vRTViewpointRela_GetFirstIDAsync = exports.vRTViewpointRela_FilterFunByKey = exports.vRTViewpointRela_SortFunByKey = exports.vRTViewpointRela_SortFun_Defa_2Fld = exports.vRTViewpointRela_SortFun_Defa = exports.vRTViewpointRela_GetObjBymIdAsync = exports.vRTViewpointRela_ConstructorName = exports.vRTViewpointRela_Controller = void 0;
    /**
     * v主题观点关系(vRTViewpointRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvRTViewpointRelaEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vRTViewpointRela_Controller = "vRTViewpointRelaApi";
    exports.vRTViewpointRela_ConstructorName = "vRTViewpointRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vRTViewpointRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTViewpointRela_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvRTViewpointRela = vRTViewpointRela_GetObjFromJsonObj(returnObj);
                return objvRTViewpointRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTViewpointRela_GetObjBymIdAsync = vRTViewpointRela_GetObjBymIdAsync;
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
    function vRTViewpointRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vRTViewpointRela_SortFun_Defa = vRTViewpointRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTViewpointRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.viewpointName == b.viewpointName)
            return a.viewpointContent.localeCompare(b.viewpointContent);
        else
            return a.viewpointName.localeCompare(b.viewpointName);
    }
    exports.vRTViewpointRela_SortFun_Defa_2Fld = vRTViewpointRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTViewpointRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointName:
                    return (a, b) => {
                        return a.viewpointName.localeCompare(b.viewpointName);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointContent:
                    return (a, b) => {
                        return a.viewpointContent.localeCompare(b.viewpointContent);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointId:
                    return (a, b) => {
                        return a.viewpointId.localeCompare(b.viewpointId);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ProposePeople:
                    return (a, b) => {
                        return a.proposePeople.localeCompare(b.proposePeople);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointTypeId:
                    return (a, b) => {
                        return a.viewpointTypeId.localeCompare(b.viewpointTypeId);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointTypeName:
                    return (a, b) => {
                        return a.viewpointTypeName.localeCompare(b.viewpointTypeName);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_Reason:
                    return (a, b) => {
                        return a.reason.localeCompare(b.reason);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_Source:
                    return (a, b) => {
                        return a.source.localeCompare(b.source);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicName:
                    return (a, b) => {
                        return a.topicName.localeCompare(b.topicName);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicContent:
                    return (a, b) => {
                        return a.topicContent.localeCompare(b.topicContent);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicProposePeople:
                    return (a, b) => {
                        return a.topicProposePeople.localeCompare(b.topicProposePeople);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UserTypeId:
                    return (a, b) => {
                        return a.userTypeId.localeCompare(b.userTypeId);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UserTypeName:
                    return (a, b) => {
                        return a.userTypeName.localeCompare(b.userTypeName);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CitationCount:
                    return (a, b) => {
                        return a.citationCount - b.citationCount;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CitationId:
                    return (a, b) => {
                        return a.citationId.localeCompare(b.citationId);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewsDate:
                    return (a, b) => {
                        return a.viewsDate.localeCompare(b.viewsDate);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewsUserId:
                    return (a, b) => {
                        return a.viewsUserId.localeCompare(b.viewsUserId);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_PdfContent:
                    return (a, b) => {
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CreateDate:
                    return (a, b) => {
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_IsRecommend:
                    return (a, b) => {
                        if (a.isRecommend == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ClassificationId:
                    return (a, b) => {
                        return a.classificationId.localeCompare(b.classificationId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vRTViewpointRela]中不存在！(in ${exports.vRTViewpointRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointName:
                    return (a, b) => {
                        return b.viewpointName.localeCompare(a.viewpointName);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointContent:
                    return (a, b) => {
                        return b.viewpointContent.localeCompare(a.viewpointContent);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointId:
                    return (a, b) => {
                        return b.viewpointId.localeCompare(a.viewpointId);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ProposePeople:
                    return (a, b) => {
                        return b.proposePeople.localeCompare(a.proposePeople);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointTypeId:
                    return (a, b) => {
                        return b.viewpointTypeId.localeCompare(a.viewpointTypeId);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointTypeName:
                    return (a, b) => {
                        return b.viewpointTypeName.localeCompare(a.viewpointTypeName);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_Reason:
                    return (a, b) => {
                        return b.reason.localeCompare(a.reason);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_Source:
                    return (a, b) => {
                        return b.source.localeCompare(a.source);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicName:
                    return (a, b) => {
                        return b.topicName.localeCompare(a.topicName);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicContent:
                    return (a, b) => {
                        return b.topicContent.localeCompare(a.topicContent);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicProposePeople:
                    return (a, b) => {
                        return b.topicProposePeople.localeCompare(a.topicProposePeople);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UserTypeId:
                    return (a, b) => {
                        return b.userTypeId.localeCompare(a.userTypeId);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UserTypeName:
                    return (a, b) => {
                        return b.userTypeName.localeCompare(a.userTypeName);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CitationCount:
                    return (a, b) => {
                        return b.citationCount - a.citationCount;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CitationId:
                    return (a, b) => {
                        return b.citationId.localeCompare(a.citationId);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewsDate:
                    return (a, b) => {
                        return b.viewsDate.localeCompare(a.viewsDate);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewsUserId:
                    return (a, b) => {
                        return b.viewsUserId.localeCompare(a.viewsUserId);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_PdfContent:
                    return (a, b) => {
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CreateDate:
                    return (a, b) => {
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_IsRecommend:
                    return (a, b) => {
                        if (b.isRecommend == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ClassificationId:
                    return (a, b) => {
                        return b.classificationId.localeCompare(a.classificationId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vRTViewpointRela]中不存在！(in ${exports.vRTViewpointRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vRTViewpointRela_SortFunByKey = vRTViewpointRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vRTViewpointRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointName:
                return (obj) => {
                    return obj.viewpointName === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointContent:
                return (obj) => {
                    return obj.viewpointContent === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointId:
                return (obj) => {
                    return obj.viewpointId === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ProposePeople:
                return (obj) => {
                    return obj.proposePeople === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointTypeId:
                return (obj) => {
                    return obj.viewpointTypeId === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointTypeName:
                return (obj) => {
                    return obj.viewpointTypeName === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_Reason:
                return (obj) => {
                    return obj.reason === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_Source:
                return (obj) => {
                    return obj.source === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicName:
                return (obj) => {
                    return obj.topicName === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicContent:
                return (obj) => {
                    return obj.topicContent === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicProposePeople:
                return (obj) => {
                    return obj.topicProposePeople === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UserTypeId:
                return (obj) => {
                    return obj.userTypeId === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UserTypeName:
                return (obj) => {
                    return obj.userTypeName === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CitationCount:
                return (obj) => {
                    return obj.citationCount === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CitationId:
                return (obj) => {
                    return obj.citationId === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewsDate:
                return (obj) => {
                    return obj.viewsDate === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewsUserId:
                return (obj) => {
                    return obj.viewsUserId === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_IsRecommend:
                return (obj) => {
                    return obj.isRecommend === value;
                };
            case clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ClassificationId:
                return (obj) => {
                    return obj.classificationId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vRTViewpointRela]中不存在！(in ${exports.vRTViewpointRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vRTViewpointRela_FilterFunByKey = vRTViewpointRela_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vRTViewpointRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTViewpointRela_GetFirstIDAsync = vRTViewpointRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vRTViewpointRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTViewpointRela_GetFirstID = vRTViewpointRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vRTViewpointRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvRTViewpointRela = vRTViewpointRela_GetObjFromJsonObj(returnObj);
                return objvRTViewpointRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTViewpointRela_GetFirstObjAsync = vRTViewpointRela_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vRTViewpointRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTViewpointRela_GetObjLstAsync = vRTViewpointRela_GetObjLstAsync;
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
    async function vRTViewpointRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTViewpointRela_GetObjLstBymIdLstAsync = vRTViewpointRela_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vRTViewpointRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTViewpointRela_GetTopObjLstAsync = vRTViewpointRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vRTViewpointRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTViewpointRela_GetObjLstByRangeAsync = vRTViewpointRela_GetObjLstByRangeAsync;
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
    async function vRTViewpointRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTViewpointRela_GetObjLstByRange = vRTViewpointRela_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vRTViewpointRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTViewpointRela_GetObjLstByPagerAsync = vRTViewpointRela_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vRTViewpointRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTViewpointRela_IsExistRecordAsync = vRTViewpointRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vRTViewpointRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTViewpointRela_IsExist = vRTViewpointRela_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vRTViewpointRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTViewpointRela_IsExistAsync = vRTViewpointRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vRTViewpointRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTViewpointRela_GetRecCountByCondAsync = vRTViewpointRela_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vRTViewpointRela_GetWebApiUrl(strController, strAction) {
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
    exports.vRTViewpointRela_GetWebApiUrl = vRTViewpointRela_GetWebApiUrl;
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
    function vRTViewpointRela_GetJSONStrByObj(pobjvRTViewpointRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvRTViewpointRelaEN);
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
    exports.vRTViewpointRela_GetJSONStrByObj = vRTViewpointRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vRTViewpointRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvRTViewpointRelaObjLst = new Array();
        if (strJSON === "") {
            return arrvRTViewpointRelaObjLst;
        }
        try {
            arrvRTViewpointRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvRTViewpointRelaObjLst;
        }
        return arrvRTViewpointRelaObjLst;
    }
    exports.vRTViewpointRela_GetObjLstByJSONStr = vRTViewpointRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvRTViewpointRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vRTViewpointRela_GetObjLstByJSONObjLst(arrvRTViewpointRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvRTViewpointRelaObjLst = new Array();
        for (const objInFor of arrvRTViewpointRelaObjLstS) {
            const obj1 = vRTViewpointRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvRTViewpointRelaObjLst.push(obj1);
        }
        return arrvRTViewpointRelaObjLst;
    }
    exports.vRTViewpointRela_GetObjLstByJSONObjLst = vRTViewpointRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vRTViewpointRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvRTViewpointRelaEN = new clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN();
        if (strJSON === "") {
            return pobjvRTViewpointRelaEN;
        }
        try {
            pobjvRTViewpointRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvRTViewpointRelaEN;
        }
        return pobjvRTViewpointRelaEN;
    }
    exports.vRTViewpointRela_GetObjByJSONStr = vRTViewpointRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vRTViewpointRela_GetCombineCondition(objvRTViewpointRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_mId, objvRTViewpointRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointName) == true) {
            const strComparisonOp_ViewpointName = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointName, objvRTViewpointRela_Cond.viewpointName, strComparisonOp_ViewpointName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointId) == true) {
            const strComparisonOp_ViewpointId = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointId, objvRTViewpointRela_Cond.viewpointId, strComparisonOp_ViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ProposePeople) == true) {
            const strComparisonOp_ProposePeople = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ProposePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ProposePeople, objvRTViewpointRela_Cond.proposePeople, strComparisonOp_ProposePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointTypeId) == true) {
            const strComparisonOp_ViewpointTypeId = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointTypeId, objvRTViewpointRela_Cond.viewpointTypeId, strComparisonOp_ViewpointTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointTypeName) == true) {
            const strComparisonOp_ViewpointTypeName = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointTypeName, objvRTViewpointRela_Cond.viewpointTypeName, strComparisonOp_ViewpointTypeName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_Source) == true) {
            const strComparisonOp_Source = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_Source];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_Source, objvRTViewpointRela_Cond.source, strComparisonOp_Source);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicId, objvRTViewpointRela_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicName) == true) {
            const strComparisonOp_TopicName = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicName, objvRTViewpointRela_Cond.topicName, strComparisonOp_TopicName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicProposePeople) == true) {
            const strComparisonOp_TopicProposePeople = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicProposePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicProposePeople, objvRTViewpointRela_Cond.topicProposePeople, strComparisonOp_TopicProposePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UpdDate, objvRTViewpointRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UpdUser, objvRTViewpointRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_Memo, objvRTViewpointRela_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_IsSubmit) == true) {
            if (objvRTViewpointRela_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_AppraiseCount, objvRTViewpointRela_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_OkCount, objvRTViewpointRela_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_score) == true) {
            const strComparisonOp_score = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_score, objvRTViewpointRela_Cond.score, strComparisonOp_score);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UserTypeId) == true) {
            const strComparisonOp_UserTypeId = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UserTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UserTypeId, objvRTViewpointRela_Cond.userTypeId, strComparisonOp_UserTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UserTypeName) == true) {
            const strComparisonOp_UserTypeName = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UserTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UserTypeName, objvRTViewpointRela_Cond.userTypeName, strComparisonOp_UserTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CitationCount) == true) {
            const strComparisonOp_CitationCount = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CitationCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CitationCount, objvRTViewpointRela_Cond.citationCount, strComparisonOp_CitationCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CitationId) == true) {
            const strComparisonOp_CitationId = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CitationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CitationId, objvRTViewpointRela_Cond.citationId, strComparisonOp_CitationId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_StuScore, objvRTViewpointRela_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TeaScore, objvRTViewpointRela_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewsDate) == true) {
            const strComparisonOp_ViewsDate = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewsDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewsDate, objvRTViewpointRela_Cond.viewsDate, strComparisonOp_ViewsDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewsUserId) == true) {
            const strComparisonOp_ViewsUserId = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewsUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewsUserId, objvRTViewpointRela_Cond.viewsUserId, strComparisonOp_ViewsUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_id_CurrEduCls, objvRTViewpointRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_PdfContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_PdfContent, objvRTViewpointRela_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_PdfPageNum, objvRTViewpointRela_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_VersionCount, objvRTViewpointRela_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_CreateDate, objvRTViewpointRela_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ShareId, objvRTViewpointRela_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_IsRecommend) == true) {
            if (objvRTViewpointRela_Cond.isRecommend == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_IsRecommend);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_IsRecommend);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvRTViewpointRela_Cond.dicFldComparisonOp, clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ClassificationId) == true) {
            const strComparisonOp_ClassificationId = objvRTViewpointRela_Cond.dicFldComparisonOp[clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ClassificationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ClassificationId, objvRTViewpointRela_Cond.classificationId, strComparisonOp_ClassificationId);
        }
        return strWhereCond;
    }
    exports.vRTViewpointRela_GetCombineCondition = vRTViewpointRela_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvRTViewpointRelaENS:源对象
     * @param objvRTViewpointRelaENT:目标对象
    */
    function vRTViewpointRela_CopyObjTo(objvRTViewpointRelaENS, objvRTViewpointRelaENT) {
        objvRTViewpointRelaENT.mId = objvRTViewpointRelaENS.mId; //mId
        objvRTViewpointRelaENT.viewpointName = objvRTViewpointRelaENS.viewpointName; //观点名称
        objvRTViewpointRelaENT.viewpointContent = objvRTViewpointRelaENS.viewpointContent; //观点内容
        objvRTViewpointRelaENT.viewpointId = objvRTViewpointRelaENS.viewpointId; //观点Id
        objvRTViewpointRelaENT.proposePeople = objvRTViewpointRelaENS.proposePeople; //提出人
        objvRTViewpointRelaENT.viewpointTypeId = objvRTViewpointRelaENS.viewpointTypeId; //观点类型Id
        objvRTViewpointRelaENT.viewpointTypeName = objvRTViewpointRelaENS.viewpointTypeName; //观点类型名
        objvRTViewpointRelaENT.reason = objvRTViewpointRelaENS.reason; //理由
        objvRTViewpointRelaENT.source = objvRTViewpointRelaENS.source; //来源
        objvRTViewpointRelaENT.topicId = objvRTViewpointRelaENS.topicId; //主题Id
        objvRTViewpointRelaENT.topicName = objvRTViewpointRelaENS.topicName; //栏目主题
        objvRTViewpointRelaENT.topicContent = objvRTViewpointRelaENS.topicContent; //主题内容
        objvRTViewpointRelaENT.topicProposePeople = objvRTViewpointRelaENS.topicProposePeople; //主题提出人
        objvRTViewpointRelaENT.updDate = objvRTViewpointRelaENS.updDate; //修改日期
        objvRTViewpointRelaENT.updUser = objvRTViewpointRelaENS.updUser; //修改人
        objvRTViewpointRelaENT.memo = objvRTViewpointRelaENS.memo; //备注
        objvRTViewpointRelaENT.isSubmit = objvRTViewpointRelaENS.isSubmit; //是否提交
        objvRTViewpointRelaENT.appraiseCount = objvRTViewpointRelaENS.appraiseCount; //评论数
        objvRTViewpointRelaENT.okCount = objvRTViewpointRelaENS.okCount; //点赞统计
        objvRTViewpointRelaENT.score = objvRTViewpointRelaENS.score; //评分
        objvRTViewpointRelaENT.userTypeId = objvRTViewpointRelaENS.userTypeId; //用户类型Id
        objvRTViewpointRelaENT.userTypeName = objvRTViewpointRelaENS.userTypeName; //用户类型名称
        objvRTViewpointRelaENT.citationCount = objvRTViewpointRelaENS.citationCount; //引用统计
        objvRTViewpointRelaENT.citationId = objvRTViewpointRelaENS.citationId; //引用Id
        objvRTViewpointRelaENT.stuScore = objvRTViewpointRelaENS.stuScore; //学生平均分
        objvRTViewpointRelaENT.teaScore = objvRTViewpointRelaENS.teaScore; //教师评分
        objvRTViewpointRelaENT.viewsDate = objvRTViewpointRelaENS.viewsDate; //ViewsDate
        objvRTViewpointRelaENT.viewsUserId = objvRTViewpointRelaENS.viewsUserId; //ViewsUserId
        objvRTViewpointRelaENT.id_CurrEduCls = objvRTViewpointRelaENS.id_CurrEduCls; //教学班流水号
        objvRTViewpointRelaENT.pdfContent = objvRTViewpointRelaENS.pdfContent; //Pdf内容
        objvRTViewpointRelaENT.pdfPageNum = objvRTViewpointRelaENS.pdfPageNum; //Pdf页码
        objvRTViewpointRelaENT.versionCount = objvRTViewpointRelaENS.versionCount; //版本统计
        objvRTViewpointRelaENT.createDate = objvRTViewpointRelaENS.createDate; //建立日期
        objvRTViewpointRelaENT.shareId = objvRTViewpointRelaENS.shareId; //分享Id
        objvRTViewpointRelaENT.isRecommend = objvRTViewpointRelaENS.isRecommend; //是否推荐
        objvRTViewpointRelaENT.classificationId = objvRTViewpointRelaENS.classificationId; //分类Id
    }
    exports.vRTViewpointRela_CopyObjTo = vRTViewpointRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvRTViewpointRelaENS:源对象
     * @param objvRTViewpointRelaENT:目标对象
    */
    function vRTViewpointRela_GetObjFromJsonObj(objvRTViewpointRelaENS) {
        const objvRTViewpointRelaENT = new clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvRTViewpointRelaENT, objvRTViewpointRelaENS);
        return objvRTViewpointRelaENT;
    }
    exports.vRTViewpointRela_GetObjFromJsonObj = vRTViewpointRela_GetObjFromJsonObj;
});
