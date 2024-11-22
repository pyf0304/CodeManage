/**
* 类名:clsvgs_PaperVWApi
* 表名:vgs_PaperV(01120677)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:43
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsvgs_PaperVEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_PaperV_GetObjFromJsonObj = exports.vgs_PaperV_CopyObjTo = exports.vgs_PaperV_GetCombineCondition = exports.vgs_PaperV_GetObjByJSONStr = exports.vgs_PaperV_GetObjLstByJSONObjLst = exports.vgs_PaperV_GetObjLstByJSONStr = exports.vgs_PaperV_GetJSONStrByObj = exports.vgs_PaperV_GetWebApiUrl = exports.vgs_PaperV_GetRecCountByCondAsync = exports.vgs_PaperV_IsExistAsync = exports.vgs_PaperV_IsExist = exports.vgs_PaperV_IsExistRecordAsync = exports.vgs_PaperV_GetObjLstByPagerAsync = exports.vgs_PaperV_GetObjLstByRange = exports.vgs_PaperV_GetObjLstByRangeAsync = exports.vgs_PaperV_GetTopObjLstAsync = exports.vgs_PaperV_GetObjLstByPaperVIdLstAsync = exports.vgs_PaperV_GetObjLstAsync = exports.vgs_PaperV_GetFirstObjAsync = exports.vgs_PaperV_GetFirstID = exports.vgs_PaperV_GetFirstIDAsync = exports.vgs_PaperV_FilterFunByKey = exports.vgs_PaperV_SortFunByKey = exports.vgs_PaperV_SortFun_Defa_2Fld = exports.vgs_PaperV_SortFun_Defa = exports.vgs_PaperV_GetObjByPaperVIdAsync = exports.vgs_PaperV_ConstructorName = exports.vgs_PaperV_Controller = void 0;
    /**
     * 论文历史版本视图(vgs_PaperV)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvgs_PaperVEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvgs_PaperVEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vgs_PaperV_Controller = "vgs_PaperVApi";
    exports.vgs_PaperV_ConstructorName = "vgs_PaperV";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPaperVId:关键字
    * @returns 对象
    **/
    async function vgs_PaperV_GetObjByPaperVIdAsync(lngPaperVId) {
        const strThisFuncName = "GetObjByPaperVIdAsync";
        if (lngPaperVId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperVId]不能为空！(In GetObjByPaperVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngPaperVId": lngPaperVId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvgs_PaperV = vgs_PaperV_GetObjFromJsonObj(returnObj);
                return objvgs_PaperV;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperV_GetObjByPaperVIdAsync = vgs_PaperV_GetObjByPaperVIdAsync;
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
    function vgs_PaperV_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperVId - b.paperVId;
    }
    exports.vgs_PaperV_SortFun_Defa = vgs_PaperV_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PaperV_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.paperTitle.localeCompare(b.paperTitle);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.vgs_PaperV_SortFun_Defa_2Fld = vgs_PaperV_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PaperV_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperVId:
                    return (a, b) => {
                        return a.paperVId - b.paperVId;
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperContent:
                    return (a, b) => {
                        return a.paperContent.localeCompare(b.paperContent);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Periodical:
                    return (a, b) => {
                        return a.periodical.localeCompare(b.periodical);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Author:
                    return (a, b) => {
                        return a.author.localeCompare(b.author);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_ResearchQuestion:
                    return (a, b) => {
                        return a.researchQuestion.localeCompare(b.researchQuestion);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Keyword:
                    return (a, b) => {
                        return a.keyword.localeCompare(b.keyword);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureSources:
                    return (a, b) => {
                        return a.literatureSources.localeCompare(b.literatureSources);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureLink:
                    return (a, b) => {
                        return a.literatureLink.localeCompare(b.literatureLink);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UploadfileUrl:
                    return (a, b) => {
                        return a.uploadfileUrl.localeCompare(b.uploadfileUrl);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsQuotethesis:
                    return (a, b) => {
                        if (a.isQuotethesis == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsChecked:
                    return (a, b) => {
                        if (a.isChecked == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_QuoteId:
                    return (a, b) => {
                        return a.quoteId.localeCompare(b.quoteId);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Checker:
                    return (a, b) => {
                        return a.checker.localeCompare(b.checker);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureTypeId:
                    return (a, b) => {
                        return a.literatureTypeId.localeCompare(b.literatureTypeId);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureTypeName:
                    return (a, b) => {
                        return a.literatureTypeName.localeCompare(b.literatureTypeName);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTypeId:
                    return (a, b) => {
                        return a.paperTypeId.localeCompare(b.paperTypeId);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTypeName:
                    return (a, b) => {
                        return a.paperTypeName.localeCompare(b.paperTypeName);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperStatusId:
                    return (a, b) => {
                        return a.paperStatusId.localeCompare(b.paperStatusId);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperStatusName:
                    return (a, b) => {
                        return a.paperStatusName.localeCompare(b.paperStatusName);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperV]中不存在！(in ${exports.vgs_PaperV_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperVId:
                    return (a, b) => {
                        return b.paperVId - a.paperVId;
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperContent:
                    return (a, b) => {
                        return b.paperContent.localeCompare(a.paperContent);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Periodical:
                    return (a, b) => {
                        return b.periodical.localeCompare(a.periodical);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Author:
                    return (a, b) => {
                        return b.author.localeCompare(a.author);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_ResearchQuestion:
                    return (a, b) => {
                        return b.researchQuestion.localeCompare(a.researchQuestion);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Keyword:
                    return (a, b) => {
                        return b.keyword.localeCompare(a.keyword);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureSources:
                    return (a, b) => {
                        return b.literatureSources.localeCompare(a.literatureSources);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureLink:
                    return (a, b) => {
                        return b.literatureLink.localeCompare(a.literatureLink);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UploadfileUrl:
                    return (a, b) => {
                        return b.uploadfileUrl.localeCompare(a.uploadfileUrl);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsQuotethesis:
                    return (a, b) => {
                        if (b.isQuotethesis == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsChecked:
                    return (a, b) => {
                        if (b.isChecked == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_QuoteId:
                    return (a, b) => {
                        return b.quoteId.localeCompare(a.quoteId);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Checker:
                    return (a, b) => {
                        return b.checker.localeCompare(a.checker);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureTypeId:
                    return (a, b) => {
                        return b.literatureTypeId.localeCompare(a.literatureTypeId);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureTypeName:
                    return (a, b) => {
                        return b.literatureTypeName.localeCompare(a.literatureTypeName);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTypeId:
                    return (a, b) => {
                        return b.paperTypeId.localeCompare(a.paperTypeId);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTypeName:
                    return (a, b) => {
                        return b.paperTypeName.localeCompare(a.paperTypeName);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperStatusId:
                    return (a, b) => {
                        return b.paperStatusId.localeCompare(a.paperStatusId);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperStatusName:
                    return (a, b) => {
                        return b.paperStatusName.localeCompare(a.paperStatusName);
                    };
                case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperV]中不存在！(in ${exports.vgs_PaperV_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vgs_PaperV_SortFunByKey = vgs_PaperV_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_PaperV_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperVId:
                return (obj) => {
                    return obj.paperVId === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperContent:
                return (obj) => {
                    return obj.paperContent === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Periodical:
                return (obj) => {
                    return obj.periodical === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_ResearchQuestion:
                return (obj) => {
                    return obj.researchQuestion === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Keyword:
                return (obj) => {
                    return obj.keyword === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureSources:
                return (obj) => {
                    return obj.literatureSources === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureLink:
                return (obj) => {
                    return obj.literatureLink === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UploadfileUrl:
                return (obj) => {
                    return obj.uploadfileUrl === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsQuotethesis:
                return (obj) => {
                    return obj.isQuotethesis === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsChecked:
                return (obj) => {
                    return obj.isChecked === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_QuoteId:
                return (obj) => {
                    return obj.quoteId === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Checker:
                return (obj) => {
                    return obj.checker === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureTypeId:
                return (obj) => {
                    return obj.literatureTypeId === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureTypeName:
                return (obj) => {
                    return obj.literatureTypeName === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTypeId:
                return (obj) => {
                    return obj.paperTypeId === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTypeName:
                return (obj) => {
                    return obj.paperTypeName === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperStatusId:
                return (obj) => {
                    return obj.paperStatusId === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperStatusName:
                return (obj) => {
                    return obj.paperStatusName === value;
                };
            case clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperV]中不存在！(in ${exports.vgs_PaperV_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vgs_PaperV_FilterFunByKey = vgs_PaperV_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vgs_PaperV_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperV_GetFirstIDAsync = vgs_PaperV_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vgs_PaperV_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperV_GetFirstID = vgs_PaperV_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vgs_PaperV_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvgs_PaperV = vgs_PaperV_GetObjFromJsonObj(returnObj);
                return objvgs_PaperV;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperV_GetFirstObjAsync = vgs_PaperV_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vgs_PaperV_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperV_GetObjLstAsync = vgs_PaperV_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperVId:关键字列表
    * @returns 对象列表
    **/
    async function vgs_PaperV_GetObjLstByPaperVIdLstAsync(arrPaperVId) {
        const strThisFuncName = "GetObjLstByPaperVIdLstAsync";
        const strAction = "GetObjLstByPaperVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperV_GetObjLstByPaperVIdLstAsync = vgs_PaperV_GetObjLstByPaperVIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vgs_PaperV_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperV_GetTopObjLstAsync = vgs_PaperV_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_PaperV_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperV_GetObjLstByRangeAsync = vgs_PaperV_GetObjLstByRangeAsync;
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
    async function vgs_PaperV_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperV_GetObjLstByRange = vgs_PaperV_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_PaperV_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperV_GetObjLstByPagerAsync = vgs_PaperV_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vgs_PaperV_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperV_IsExistRecordAsync = vgs_PaperV_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPaperVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vgs_PaperV_IsExist(lngPaperVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperVId": lngPaperVId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperV_IsExist = vgs_PaperV_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPaperVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vgs_PaperV_IsExistAsync(lngPaperVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngPaperVId": lngPaperVId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperV_IsExistAsync = vgs_PaperV_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vgs_PaperV_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperV_GetRecCountByCondAsync = vgs_PaperV_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vgs_PaperV_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_PaperV_GetWebApiUrl = vgs_PaperV_GetWebApiUrl;
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
    function vgs_PaperV_GetJSONStrByObj(pobjvgs_PaperVEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvgs_PaperVEN);
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
    exports.vgs_PaperV_GetJSONStrByObj = vgs_PaperV_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vgs_PaperV_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvgs_PaperVObjLst = new Array();
        if (strJSON === "") {
            return arrvgs_PaperVObjLst;
        }
        try {
            arrvgs_PaperVObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvgs_PaperVObjLst;
        }
        return arrvgs_PaperVObjLst;
    }
    exports.vgs_PaperV_GetObjLstByJSONStr = vgs_PaperV_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvgs_PaperVObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vgs_PaperV_GetObjLstByJSONObjLst(arrvgs_PaperVObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvgs_PaperVObjLst = new Array();
        for (const objInFor of arrvgs_PaperVObjLstS) {
            const obj1 = vgs_PaperV_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvgs_PaperVObjLst.push(obj1);
        }
        return arrvgs_PaperVObjLst;
    }
    exports.vgs_PaperV_GetObjLstByJSONObjLst = vgs_PaperV_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_PaperV_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvgs_PaperVEN = new clsvgs_PaperVEN_js_1.clsvgs_PaperVEN();
        if (strJSON === "") {
            return pobjvgs_PaperVEN;
        }
        try {
            pobjvgs_PaperVEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvgs_PaperVEN;
        }
        return pobjvgs_PaperVEN;
    }
    exports.vgs_PaperV_GetObjByJSONStr = vgs_PaperV_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vgs_PaperV_GetCombineCondition(objvgs_PaperV_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperVId) == true) {
            const strComparisonOp_PaperVId = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperVId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperVId, objvgs_PaperV_Cond.paperVId, strComparisonOp_PaperVId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperId, objvgs_PaperV_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTitle, objvgs_PaperV_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Periodical) == true) {
            const strComparisonOp_Periodical = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Periodical];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Periodical, objvgs_PaperV_Cond.periodical, strComparisonOp_Periodical);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Author) == true) {
            const strComparisonOp_Author = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Author];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Author, objvgs_PaperV_Cond.author, strComparisonOp_Author);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_ResearchQuestion) == true) {
            const strComparisonOp_ResearchQuestion = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_ResearchQuestion];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_ResearchQuestion, objvgs_PaperV_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Keyword) == true) {
            const strComparisonOp_Keyword = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Keyword];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Keyword, objvgs_PaperV_Cond.keyword, strComparisonOp_Keyword);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureSources) == true) {
            const strComparisonOp_LiteratureSources = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureSources];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureSources, objvgs_PaperV_Cond.literatureSources, strComparisonOp_LiteratureSources);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureLink) == true) {
            const strComparisonOp_LiteratureLink = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureLink];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureLink, objvgs_PaperV_Cond.literatureLink, strComparisonOp_LiteratureLink);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UploadfileUrl) == true) {
            const strComparisonOp_UploadfileUrl = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UploadfileUrl];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UploadfileUrl, objvgs_PaperV_Cond.uploadfileUrl, strComparisonOp_UploadfileUrl);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsQuotethesis) == true) {
            if (objvgs_PaperV_Cond.isQuotethesis == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsQuotethesis);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsQuotethesis);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsSubmit) == true) {
            if (objvgs_PaperV_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsChecked) == true) {
            if (objvgs_PaperV_Cond.isChecked == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsChecked);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_IsChecked);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_QuoteId) == true) {
            const strComparisonOp_QuoteId = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_QuoteId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_QuoteId, objvgs_PaperV_Cond.quoteId, strComparisonOp_QuoteId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Checker) == true) {
            const strComparisonOp_Checker = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Checker];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Checker, objvgs_PaperV_Cond.checker, strComparisonOp_Checker);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureTypeId) == true) {
            const strComparisonOp_LiteratureTypeId = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureTypeId, objvgs_PaperV_Cond.literatureTypeId, strComparisonOp_LiteratureTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureTypeName) == true) {
            const strComparisonOp_LiteratureTypeName = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_LiteratureTypeName, objvgs_PaperV_Cond.literatureTypeName, strComparisonOp_LiteratureTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UpdUser, objvgs_PaperV_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_UpdDate, objvgs_PaperV_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_id_CurrEduCls, objvgs_PaperV_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTypeId) == true) {
            const strComparisonOp_PaperTypeId = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTypeId, objvgs_PaperV_Cond.paperTypeId, strComparisonOp_PaperTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTypeName) == true) {
            const strComparisonOp_PaperTypeName = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperTypeName, objvgs_PaperV_Cond.paperTypeName, strComparisonOp_PaperTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperStatusId) == true) {
            const strComparisonOp_PaperStatusId = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperStatusId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperStatusId, objvgs_PaperV_Cond.paperStatusId, strComparisonOp_PaperStatusId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperStatusName) == true) {
            const strComparisonOp_PaperStatusName = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperStatusName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_PaperStatusName, objvgs_PaperV_Cond.paperStatusName, strComparisonOp_PaperStatusName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperVEN_js_1.clsvgs_PaperVEN.con_Memo, objvgs_PaperV_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.vgs_PaperV_GetCombineCondition = vgs_PaperV_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvgs_PaperVENS:源对象
     * @param objvgs_PaperVENT:目标对象
    */
    function vgs_PaperV_CopyObjTo(objvgs_PaperVENS, objvgs_PaperVENT) {
        objvgs_PaperVENT.paperVId = objvgs_PaperVENS.paperVId; //PaperVId
        objvgs_PaperVENT.paperId = objvgs_PaperVENS.paperId; //论文Id
        objvgs_PaperVENT.paperTitle = objvgs_PaperVENS.paperTitle; //论文标题
        objvgs_PaperVENT.paperContent = objvgs_PaperVENS.paperContent; //主题内容
        objvgs_PaperVENT.periodical = objvgs_PaperVENS.periodical; //期刊
        objvgs_PaperVENT.author = objvgs_PaperVENS.author; //作者
        objvgs_PaperVENT.researchQuestion = objvgs_PaperVENS.researchQuestion; //研究问题
        objvgs_PaperVENT.keyword = objvgs_PaperVENS.keyword; //关键字
        objvgs_PaperVENT.literatureSources = objvgs_PaperVENS.literatureSources; //文献来源
        objvgs_PaperVENT.literatureLink = objvgs_PaperVENS.literatureLink; //文献链接
        objvgs_PaperVENT.uploadfileUrl = objvgs_PaperVENS.uploadfileUrl; //文件地址
        objvgs_PaperVENT.isQuotethesis = objvgs_PaperVENS.isQuotethesis; //是否引用论文
        objvgs_PaperVENT.isSubmit = objvgs_PaperVENS.isSubmit; //是否提交
        objvgs_PaperVENT.isChecked = objvgs_PaperVENS.isChecked; //是否检查
        objvgs_PaperVENT.quoteId = objvgs_PaperVENS.quoteId; //引用Id
        objvgs_PaperVENT.checker = objvgs_PaperVENS.checker; //审核人
        objvgs_PaperVENT.literatureTypeId = objvgs_PaperVENS.literatureTypeId; //作文类型Id
        objvgs_PaperVENT.literatureTypeName = objvgs_PaperVENS.literatureTypeName; //作文类型名
        objvgs_PaperVENT.updUser = objvgs_PaperVENS.updUser; //修改人
        objvgs_PaperVENT.updDate = objvgs_PaperVENS.updDate; //修改日期
        objvgs_PaperVENT.id_CurrEduCls = objvgs_PaperVENS.id_CurrEduCls; //教学班流水号
        objvgs_PaperVENT.paperTypeId = objvgs_PaperVENS.paperTypeId; //论文类型Id
        objvgs_PaperVENT.paperTypeName = objvgs_PaperVENS.paperTypeName; //论文类型名
        objvgs_PaperVENT.paperStatusId = objvgs_PaperVENS.paperStatusId; //论文状态Id
        objvgs_PaperVENT.paperStatusName = objvgs_PaperVENS.paperStatusName; //论文状态名
        objvgs_PaperVENT.memo = objvgs_PaperVENS.memo; //备注
    }
    exports.vgs_PaperV_CopyObjTo = vgs_PaperV_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvgs_PaperVENS:源对象
     * @param objvgs_PaperVENT:目标对象
    */
    function vgs_PaperV_GetObjFromJsonObj(objvgs_PaperVENS) {
        const objvgs_PaperVENT = new clsvgs_PaperVEN_js_1.clsvgs_PaperVEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_PaperVENT, objvgs_PaperVENS);
        return objvgs_PaperVENT;
    }
    exports.vgs_PaperV_GetObjFromJsonObj = vgs_PaperV_GetObjFromJsonObj;
});
