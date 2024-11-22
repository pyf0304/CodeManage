/**
* 类名:clsvqa_PushWApi
* 表名:vqa_Push(01120634)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:46:21
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:互动管理(InteractManage)
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
        define(["require", "exports", "axios", "../../L0_Entity/InteractManage/clsvqa_PushEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vqa_Push_GetObjFromJsonObj = exports.vqa_Push_CopyObjTo = exports.vqa_Push_GetCombineCondition = exports.vqa_Push_GetObjByJSONStr = exports.vqa_Push_GetObjLstByJSONObjLst = exports.vqa_Push_GetObjLstByJSONStr = exports.vqa_Push_GetJSONStrByObj = exports.vqa_Push_GetWebApiUrl = exports.vqa_Push_GetRecCountByCondAsync = exports.vqa_Push_IsExistAsync = exports.vqa_Push_IsExist = exports.vqa_Push_IsExistRecordAsync = exports.vqa_Push_GetObjLstByPagerAsync = exports.vqa_Push_GetObjLstByRange = exports.vqa_Push_GetObjLstByRangeAsync = exports.vqa_Push_GetTopObjLstAsync = exports.vqa_Push_GetObjLstByPushIdLstAsync = exports.vqa_Push_GetObjLstAsync = exports.vqa_Push_GetFirstObjAsync = exports.vqa_Push_GetFirstID = exports.vqa_Push_GetFirstIDAsync = exports.vqa_Push_FilterFunByKey = exports.vqa_Push_SortFunByKey = exports.vqa_Push_SortFun_Defa_2Fld = exports.vqa_Push_SortFun_Defa = exports.vqa_Push_GetObjByPushIdAsync = exports.vqa_Push_ConstructorName = exports.vqa_Push_Controller = void 0;
    /**
     * v答疑推送(vqa_Push)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvqa_PushEN_js_1 = require("../../L0_Entity/InteractManage/clsvqa_PushEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vqa_Push_Controller = "vqa_PushApi";
    exports.vqa_Push_ConstructorName = "vqa_Push";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPushId:关键字
    * @returns 对象
    **/
    async function vqa_Push_GetObjByPushIdAsync(lngPushId) {
        const strThisFuncName = "GetObjByPushIdAsync";
        if (lngPushId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPushId]不能为空！(In clsvqa_PushWApi.GetObjByPushIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPushId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Push_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngPushId": lngPushId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvqa_Push = vqa_Push_GetObjFromJsonObj(returnObj);
                return objvqa_Push;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Push_GetObjByPushIdAsync = vqa_Push_GetObjByPushIdAsync;
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
    function vqa_Push_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.pushId - b.pushId;
    }
    exports.vqa_Push_SortFun_Defa = vqa_Push_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vqa_Push_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.questionsId == b.questionsId)
            return a.questionsContent.localeCompare(b.questionsContent);
        else
            return a.questionsId.localeCompare(b.questionsId);
    }
    exports.vqa_Push_SortFun_Defa_2Fld = vqa_Push_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vqa_Push_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_PushId:
                    return (a, b) => {
                        return a.pushId - b.pushId;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsId:
                    return (a, b) => {
                        return a.questionsId.localeCompare(b.questionsId);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsContent:
                    return (a, b) => {
                        if (a.questionsContent == null)
                            return -1;
                        if (b.questionsContent == null)
                            return 1;
                        return a.questionsContent.localeCompare(b.questionsContent);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReceiveUser:
                    return (a, b) => {
                        if (a.receiveUser == null)
                            return -1;
                        if (b.receiveUser == null)
                            return 1;
                        return a.receiveUser.localeCompare(b.receiveUser);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReceiveDate:
                    return (a, b) => {
                        if (a.receiveDate == null)
                            return -1;
                        if (b.receiveDate == null)
                            return 1;
                        return a.receiveDate.localeCompare(b.receiveDate);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_UserName:
                    return (a, b) => {
                        if (a.userName == null)
                            return -1;
                        if (b.userName == null)
                            return 1;
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsReceive:
                    return (a, b) => {
                        if (a.isReceive == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_AnswerCount:
                    return (a, b) => {
                        return a.answerCount - b.answerCount;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsEnd:
                    return (a, b) => {
                        if (a.isEnd == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_VoteCount:
                    return (a, b) => {
                        return a.voteCount - b.voteCount;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_PdfContent:
                    return (a, b) => {
                        if (a.pdfContent == null)
                            return -1;
                        if (b.pdfContent == null)
                            return 1;
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_qa_PaperId:
                    return (a, b) => {
                        if (a.qa_PaperId == null)
                            return -1;
                        if (b.qa_PaperId == null)
                            return 1;
                        return a.qa_PaperId.localeCompare(b.qa_PaperId);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsPublic:
                    return (a, b) => {
                        if (a.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_PaperTitle:
                    return (a, b) => {
                        if (a.paperTitle == null)
                            return -1;
                        if (b.paperTitle == null)
                            return 1;
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsReply:
                    return (a, b) => {
                        if (a.isReply == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsRequestReply:
                    return (a, b) => {
                        if (a.isRequestReply == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReplyDate:
                    return (a, b) => {
                        if (a.replyDate == null)
                            return -1;
                        if (b.replyDate == null)
                            return 1;
                        return a.replyDate.localeCompare(b.replyDate);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsTypeId:
                    return (a, b) => {
                        if (a.questionsTypeId == null)
                            return -1;
                        if (b.questionsTypeId == null)
                            return 1;
                        return a.questionsTypeId.localeCompare(b.questionsTypeId);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsTypeName:
                    return (a, b) => {
                        if (a.questionsTypeName == null)
                            return -1;
                        if (b.questionsTypeName == null)
                            return 1;
                        return a.questionsTypeName.localeCompare(b.questionsTypeName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vqa_Push]中不存在！(in ${exports.vqa_Push_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_PushId:
                    return (a, b) => {
                        return b.pushId - a.pushId;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsId:
                    return (a, b) => {
                        return b.questionsId.localeCompare(a.questionsId);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsContent:
                    return (a, b) => {
                        if (b.questionsContent == null)
                            return -1;
                        if (a.questionsContent == null)
                            return 1;
                        return b.questionsContent.localeCompare(a.questionsContent);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReceiveUser:
                    return (a, b) => {
                        if (b.receiveUser == null)
                            return -1;
                        if (a.receiveUser == null)
                            return 1;
                        return b.receiveUser.localeCompare(a.receiveUser);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReceiveDate:
                    return (a, b) => {
                        if (b.receiveDate == null)
                            return -1;
                        if (a.receiveDate == null)
                            return 1;
                        return b.receiveDate.localeCompare(a.receiveDate);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_UserName:
                    return (a, b) => {
                        if (b.userName == null)
                            return -1;
                        if (a.userName == null)
                            return 1;
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsReceive:
                    return (a, b) => {
                        if (b.isReceive == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_AnswerCount:
                    return (a, b) => {
                        return b.answerCount - a.answerCount;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsEnd:
                    return (a, b) => {
                        if (b.isEnd == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_VoteCount:
                    return (a, b) => {
                        return b.voteCount - a.voteCount;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_PdfContent:
                    return (a, b) => {
                        if (b.pdfContent == null)
                            return -1;
                        if (a.pdfContent == null)
                            return 1;
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_qa_PaperId:
                    return (a, b) => {
                        if (b.qa_PaperId == null)
                            return -1;
                        if (a.qa_PaperId == null)
                            return 1;
                        return b.qa_PaperId.localeCompare(a.qa_PaperId);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsPublic:
                    return (a, b) => {
                        if (b.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_PaperTitle:
                    return (a, b) => {
                        if (b.paperTitle == null)
                            return -1;
                        if (a.paperTitle == null)
                            return 1;
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsReply:
                    return (a, b) => {
                        if (b.isReply == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsRequestReply:
                    return (a, b) => {
                        if (b.isRequestReply == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReplyDate:
                    return (a, b) => {
                        if (b.replyDate == null)
                            return -1;
                        if (a.replyDate == null)
                            return 1;
                        return b.replyDate.localeCompare(a.replyDate);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsTypeId:
                    return (a, b) => {
                        if (b.questionsTypeId == null)
                            return -1;
                        if (a.questionsTypeId == null)
                            return 1;
                        return b.questionsTypeId.localeCompare(a.questionsTypeId);
                    };
                case clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsTypeName:
                    return (a, b) => {
                        if (b.questionsTypeName == null)
                            return -1;
                        if (a.questionsTypeName == null)
                            return 1;
                        return b.questionsTypeName.localeCompare(a.questionsTypeName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vqa_Push]中不存在！(in ${exports.vqa_Push_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vqa_Push_SortFunByKey = vqa_Push_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vqa_Push_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_PushId:
                return (obj) => {
                    return obj.pushId === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsId:
                return (obj) => {
                    return obj.questionsId === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsContent:
                return (obj) => {
                    return obj.questionsContent === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReceiveUser:
                return (obj) => {
                    return obj.receiveUser === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReceiveDate:
                return (obj) => {
                    return obj.receiveDate === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsReceive:
                return (obj) => {
                    return obj.isReceive === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_AnswerCount:
                return (obj) => {
                    return obj.answerCount === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsEnd:
                return (obj) => {
                    return obj.isEnd === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_VoteCount:
                return (obj) => {
                    return obj.voteCount === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_qa_PaperId:
                return (obj) => {
                    return obj.qa_PaperId === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsPublic:
                return (obj) => {
                    return obj.isPublic === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsReply:
                return (obj) => {
                    return obj.isReply === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsRequestReply:
                return (obj) => {
                    return obj.isRequestReply === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReplyDate:
                return (obj) => {
                    return obj.replyDate === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsTypeId:
                return (obj) => {
                    return obj.questionsTypeId === value;
                };
            case clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsTypeName:
                return (obj) => {
                    return obj.questionsTypeName === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vqa_Push]中不存在！(in ${exports.vqa_Push_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vqa_Push_FilterFunByKey = vqa_Push_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vqa_Push_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Push_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Push_GetFirstIDAsync = vqa_Push_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vqa_Push_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Push_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Push_GetFirstID = vqa_Push_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vqa_Push_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Push_Controller, strAction);
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
                const objvqa_Push = vqa_Push_GetObjFromJsonObj(returnObj);
                return objvqa_Push;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Push_GetFirstObjAsync = vqa_Push_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vqa_Push_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Push_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Push_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Push_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Push_GetObjLstAsync = vqa_Push_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPushId:关键字列表
    * @returns 对象列表
    **/
    async function vqa_Push_GetObjLstByPushIdLstAsync(arrPushId) {
        const strThisFuncName = "GetObjLstByPushIdLstAsync";
        const strAction = "GetObjLstByPushIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Push_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPushId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Push_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Push_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Push_GetObjLstByPushIdLstAsync = vqa_Push_GetObjLstByPushIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vqa_Push_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Push_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Push_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Push_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Push_GetTopObjLstAsync = vqa_Push_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vqa_Push_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Push_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Push_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Push_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Push_GetObjLstByRangeAsync = vqa_Push_GetObjLstByRangeAsync;
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
    async function vqa_Push_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Push_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Push_GetObjLstByRange = vqa_Push_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vqa_Push_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Push_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Push_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Push_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Push_GetObjLstByPagerAsync = vqa_Push_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vqa_Push_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Push_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Push_IsExistRecordAsync = vqa_Push_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPushId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vqa_Push_IsExist(lngPushId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Push_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PushId": lngPushId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Push_IsExist = vqa_Push_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPushId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vqa_Push_IsExistAsync(lngPushId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Push_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngPushId": lngPushId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Push_IsExistAsync = vqa_Push_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vqa_Push_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Push_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Push_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Push_GetRecCountByCondAsync = vqa_Push_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vqa_Push_GetWebApiUrl(strController, strAction) {
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
    exports.vqa_Push_GetWebApiUrl = vqa_Push_GetWebApiUrl;
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
    function vqa_Push_GetJSONStrByObj(pobjvqa_PushEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvqa_PushEN);
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
    exports.vqa_Push_GetJSONStrByObj = vqa_Push_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vqa_Push_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvqa_PushObjLst = new Array();
        if (strJSON === "") {
            return arrvqa_PushObjLst;
        }
        try {
            arrvqa_PushObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvqa_PushObjLst;
        }
        return arrvqa_PushObjLst;
    }
    exports.vqa_Push_GetObjLstByJSONStr = vqa_Push_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvqa_PushObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vqa_Push_GetObjLstByJSONObjLst(arrvqa_PushObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvqa_PushObjLst = new Array();
        for (const objInFor of arrvqa_PushObjLstS) {
            const obj1 = vqa_Push_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvqa_PushObjLst.push(obj1);
        }
        return arrvqa_PushObjLst;
    }
    exports.vqa_Push_GetObjLstByJSONObjLst = vqa_Push_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vqa_Push_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvqa_PushEN = new clsvqa_PushEN_js_1.clsvqa_PushEN();
        if (strJSON === "") {
            return pobjvqa_PushEN;
        }
        try {
            pobjvqa_PushEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvqa_PushEN;
        }
        return pobjvqa_PushEN;
    }
    exports.vqa_Push_GetObjByJSONStr = vqa_Push_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vqa_Push_GetCombineCondition(objvqa_Push_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_PushId) == true) {
            const strComparisonOp_PushId = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_PushId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_PushEN_js_1.clsvqa_PushEN.con_PushId, objvqa_Push_Cond.pushId, strComparisonOp_PushId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsId) == true) {
            const strComparisonOp_QuestionsId = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsId, objvqa_Push_Cond.questionsId, strComparisonOp_QuestionsId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsContent) == true) {
            const strComparisonOp_QuestionsContent = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsContent, objvqa_Push_Cond.questionsContent, strComparisonOp_QuestionsContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReceiveUser) == true) {
            const strComparisonOp_ReceiveUser = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReceiveUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReceiveUser, objvqa_Push_Cond.receiveUser, strComparisonOp_ReceiveUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReceiveDate) == true) {
            const strComparisonOp_ReceiveDate = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReceiveDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReceiveDate, objvqa_Push_Cond.receiveDate, strComparisonOp_ReceiveDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_UserName, objvqa_Push_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsReceive) == true) {
            if (objvqa_Push_Cond.isReceive == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsReceive);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsReceive);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_UpdDate, objvqa_Push_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_AnswerCount) == true) {
            const strComparisonOp_AnswerCount = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_AnswerCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_PushEN_js_1.clsvqa_PushEN.con_AnswerCount, objvqa_Push_Cond.answerCount, strComparisonOp_AnswerCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsEnd) == true) {
            if (objvqa_Push_Cond.isEnd == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsEnd);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsEnd);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_VoteCount) == true) {
            const strComparisonOp_VoteCount = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_VoteCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_PushEN_js_1.clsvqa_PushEN.con_VoteCount, objvqa_Push_Cond.voteCount, strComparisonOp_VoteCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_Memo, objvqa_Push_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_id_CurrEduCls, objvqa_Push_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_PdfContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_PdfContent, objvqa_Push_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_qa_PaperId) == true) {
            const strComparisonOp_qa_PaperId = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_qa_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_qa_PaperId, objvqa_Push_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsPublic) == true) {
            if (objvqa_Push_Cond.isPublic == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsPublic);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsPublic);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_PaperId, objvqa_Push_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_PaperTitle, objvqa_Push_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_PushEN_js_1.clsvqa_PushEN.con_PdfPageNum, objvqa_Push_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsReply) == true) {
            if (objvqa_Push_Cond.isReply == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsReply);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsReply);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsRequestReply) == true) {
            if (objvqa_Push_Cond.isRequestReply == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsRequestReply);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_IsRequestReply);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReplyDate) == true) {
            const strComparisonOp_ReplyDate = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReplyDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_ReplyDate, objvqa_Push_Cond.replyDate, strComparisonOp_ReplyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsTypeId) == true) {
            const strComparisonOp_QuestionsTypeId = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsTypeId, objvqa_Push_Cond.questionsTypeId, strComparisonOp_QuestionsTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Push_Cond.dicFldComparisonOp, clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsTypeName) == true) {
            const strComparisonOp_QuestionsTypeName = objvqa_Push_Cond.dicFldComparisonOp[clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PushEN_js_1.clsvqa_PushEN.con_QuestionsTypeName, objvqa_Push_Cond.questionsTypeName, strComparisonOp_QuestionsTypeName);
        }
        return strWhereCond;
    }
    exports.vqa_Push_GetCombineCondition = vqa_Push_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvqa_PushENS:源对象
     * @param objvqa_PushENT:目标对象
    */
    function vqa_Push_CopyObjTo(objvqa_PushENS, objvqa_PushENT) {
        objvqa_PushENT.pushId = objvqa_PushENS.pushId; //推送d
        objvqa_PushENT.questionsId = objvqa_PushENS.questionsId; //提问Id
        objvqa_PushENT.questionsContent = objvqa_PushENS.questionsContent; //提问内容
        objvqa_PushENT.receiveUser = objvqa_PushENS.receiveUser; //接收用户
        objvqa_PushENT.receiveDate = objvqa_PushENS.receiveDate; //接收日期
        objvqa_PushENT.userName = objvqa_PushENS.userName; //用户名
        objvqa_PushENT.isReceive = objvqa_PushENS.isReceive; //是否接收
        objvqa_PushENT.updDate = objvqa_PushENS.updDate; //修改日期
        objvqa_PushENT.answerCount = objvqa_PushENS.answerCount; //回答计数
        objvqa_PushENT.isEnd = objvqa_PushENS.isEnd; //是否结束
        objvqa_PushENT.voteCount = objvqa_PushENS.voteCount; //点赞计数
        objvqa_PushENT.memo = objvqa_PushENS.memo; //备注
        objvqa_PushENT.id_CurrEduCls = objvqa_PushENS.id_CurrEduCls; //教学班流水号
        objvqa_PushENT.pdfContent = objvqa_PushENS.pdfContent; //Pdf内容
        objvqa_PushENT.qa_PaperId = objvqa_PushENS.qa_PaperId; //论文答疑Id
        objvqa_PushENT.isPublic = objvqa_PushENS.isPublic; //是否公开
        objvqa_PushENT.paperId = objvqa_PushENS.paperId; //论文Id
        objvqa_PushENT.paperTitle = objvqa_PushENS.paperTitle; //论文标题
        objvqa_PushENT.pdfPageNum = objvqa_PushENS.pdfPageNum; //Pdf页码
        objvqa_PushENT.isReply = objvqa_PushENS.isReply; //是否回复
        objvqa_PushENT.isRequestReply = objvqa_PushENS.isRequestReply; //是否要求回复
        objvqa_PushENT.replyDate = objvqa_PushENS.replyDate; //回复日期
        objvqa_PushENT.questionsTypeId = objvqa_PushENS.questionsTypeId; //问题类型Id
        objvqa_PushENT.questionsTypeName = objvqa_PushENS.questionsTypeName; //问题类型名称
    }
    exports.vqa_Push_CopyObjTo = vqa_Push_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvqa_PushENS:源对象
     * @param objvqa_PushENT:目标对象
    */
    function vqa_Push_GetObjFromJsonObj(objvqa_PushENS) {
        const objvqa_PushENT = new clsvqa_PushEN_js_1.clsvqa_PushEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvqa_PushENT, objvqa_PushENS);
        return objvqa_PushENT;
    }
    exports.vqa_Push_GetObjFromJsonObj = vqa_Push_GetObjFromJsonObj;
});
