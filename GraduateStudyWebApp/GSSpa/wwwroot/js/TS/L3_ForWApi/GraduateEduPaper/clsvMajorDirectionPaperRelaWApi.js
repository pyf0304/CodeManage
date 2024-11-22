/**
* 类名:clsvMajorDirectionPaperRelaWApi
* 表名:vMajorDirectionPaperRela(01120555)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:39
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsvMajorDirectionPaperRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vMajorDirectionPaperRela_GetObjFromJsonObj = exports.vMajorDirectionPaperRela_CopyObjTo = exports.vMajorDirectionPaperRela_GetCombineCondition = exports.vMajorDirectionPaperRela_GetObjByJSONStr = exports.vMajorDirectionPaperRela_GetObjLstByJSONObjLst = exports.vMajorDirectionPaperRela_GetObjLstByJSONStr = exports.vMajorDirectionPaperRela_GetJSONStrByObj = exports.vMajorDirectionPaperRela_GetWebApiUrl = exports.vMajorDirectionPaperRela_GetRecCountByCondAsync = exports.vMajorDirectionPaperRela_IsExistAsync = exports.vMajorDirectionPaperRela_IsExist = exports.vMajorDirectionPaperRela_IsExistRecordAsync = exports.vMajorDirectionPaperRela_GetObjLstByPagerAsync = exports.vMajorDirectionPaperRela_GetObjLstByRange = exports.vMajorDirectionPaperRela_GetObjLstByRangeAsync = exports.vMajorDirectionPaperRela_GetTopObjLstAsync = exports.vMajorDirectionPaperRela_GetObjLstBymIdLstAsync = exports.vMajorDirectionPaperRela_GetObjLstAsync = exports.vMajorDirectionPaperRela_GetFirstObjAsync = exports.vMajorDirectionPaperRela_GetFirstID = exports.vMajorDirectionPaperRela_GetFirstIDAsync = exports.vMajorDirectionPaperRela_FilterFunByKey = exports.vMajorDirectionPaperRela_SortFunByKey = exports.vMajorDirectionPaperRela_SortFun_Defa_2Fld = exports.vMajorDirectionPaperRela_SortFun_Defa = exports.vMajorDirectionPaperRela_GetObjBymIdAsync = exports.vMajorDirectionPaperRela_ConstructorName = exports.vMajorDirectionPaperRela_Controller = void 0;
    /**
     * v专业方向论文关系(vMajorDirectionPaperRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvMajorDirectionPaperRelaEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvMajorDirectionPaperRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vMajorDirectionPaperRela_Controller = "vMajorDirectionPaperRelaApi";
    exports.vMajorDirectionPaperRela_ConstructorName = "vMajorDirectionPaperRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vMajorDirectionPaperRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMajorDirectionPaperRela_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvMajorDirectionPaperRela = vMajorDirectionPaperRela_GetObjFromJsonObj(returnObj);
                return objvMajorDirectionPaperRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMajorDirectionPaperRela_GetObjBymIdAsync = vMajorDirectionPaperRela_GetObjBymIdAsync;
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
    function vMajorDirectionPaperRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vMajorDirectionPaperRela_SortFun_Defa = vMajorDirectionPaperRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vMajorDirectionPaperRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.majorDirectionId == b.majorDirectionId)
            return a.paperId.localeCompare(b.paperId);
        else
            return a.majorDirectionId.localeCompare(b.majorDirectionId);
    }
    exports.vMajorDirectionPaperRela_SortFun_Defa_2Fld = vMajorDirectionPaperRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vMajorDirectionPaperRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionId:
                    return (a, b) => {
                        return a.majorDirectionId.localeCompare(b.majorDirectionId);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionENName:
                    return (a, b) => {
                        return a.majorDirectionENName.localeCompare(b.majorDirectionENName);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionName:
                    return (a, b) => {
                        return a.majorDirectionName.localeCompare(b.majorDirectionName);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionExplain:
                    return (a, b) => {
                        return a.majorDirectionExplain.localeCompare(b.majorDirectionExplain);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsVisible:
                    return (a, b) => {
                        if (a.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_PaperContent:
                    return (a, b) => {
                        return a.paperContent.localeCompare(b.paperContent);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Periodical:
                    return (a, b) => {
                        return a.periodical.localeCompare(b.periodical);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Author:
                    return (a, b) => {
                        return a.author.localeCompare(b.author);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_ResearchQuestion:
                    return (a, b) => {
                        return a.researchQuestion.localeCompare(b.researchQuestion);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Keyword:
                    return (a, b) => {
                        return a.keyword.localeCompare(b.keyword);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_LiteratureSources:
                    return (a, b) => {
                        return a.literatureSources.localeCompare(b.literatureSources);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_LiteratureLink:
                    return (a, b) => {
                        return a.literatureLink.localeCompare(b.literatureLink);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UploadfileUrl:
                    return (a, b) => {
                        return a.uploadfileUrl.localeCompare(b.uploadfileUrl);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsQuotethesis:
                    return (a, b) => {
                        if (a.isQuotethesis == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Checker:
                    return (a, b) => {
                        return a.checker.localeCompare(b.checker);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsChecked:
                    return (a, b) => {
                        if (a.isChecked == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorID:
                    return (a, b) => {
                        return a.majorID.localeCompare(b.majorID);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vMajorDirectionPaperRela]中不存在！(in ${exports.vMajorDirectionPaperRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionId:
                    return (a, b) => {
                        return b.majorDirectionId.localeCompare(a.majorDirectionId);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionENName:
                    return (a, b) => {
                        return b.majorDirectionENName.localeCompare(a.majorDirectionENName);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionName:
                    return (a, b) => {
                        return b.majorDirectionName.localeCompare(a.majorDirectionName);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionExplain:
                    return (a, b) => {
                        return b.majorDirectionExplain.localeCompare(a.majorDirectionExplain);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsVisible:
                    return (a, b) => {
                        if (b.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_PaperContent:
                    return (a, b) => {
                        return b.paperContent.localeCompare(a.paperContent);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Periodical:
                    return (a, b) => {
                        return b.periodical.localeCompare(a.periodical);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Author:
                    return (a, b) => {
                        return b.author.localeCompare(a.author);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_ResearchQuestion:
                    return (a, b) => {
                        return b.researchQuestion.localeCompare(a.researchQuestion);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Keyword:
                    return (a, b) => {
                        return b.keyword.localeCompare(a.keyword);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_LiteratureSources:
                    return (a, b) => {
                        return b.literatureSources.localeCompare(a.literatureSources);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_LiteratureLink:
                    return (a, b) => {
                        return b.literatureLink.localeCompare(a.literatureLink);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UploadfileUrl:
                    return (a, b) => {
                        return b.uploadfileUrl.localeCompare(a.uploadfileUrl);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsQuotethesis:
                    return (a, b) => {
                        if (b.isQuotethesis == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Checker:
                    return (a, b) => {
                        return b.checker.localeCompare(a.checker);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsChecked:
                    return (a, b) => {
                        if (b.isChecked == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorID:
                    return (a, b) => {
                        return b.majorID.localeCompare(a.majorID);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vMajorDirectionPaperRela]中不存在！(in ${exports.vMajorDirectionPaperRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vMajorDirectionPaperRela_SortFunByKey = vMajorDirectionPaperRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vMajorDirectionPaperRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionId:
                return (obj) => {
                    return obj.majorDirectionId === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionENName:
                return (obj) => {
                    return obj.majorDirectionENName === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionName:
                return (obj) => {
                    return obj.majorDirectionName === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionExplain:
                return (obj) => {
                    return obj.majorDirectionExplain === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsVisible:
                return (obj) => {
                    return obj.isVisible === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_PaperContent:
                return (obj) => {
                    return obj.paperContent === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Periodical:
                return (obj) => {
                    return obj.periodical === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_ResearchQuestion:
                return (obj) => {
                    return obj.researchQuestion === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Keyword:
                return (obj) => {
                    return obj.keyword === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_LiteratureSources:
                return (obj) => {
                    return obj.literatureSources === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_LiteratureLink:
                return (obj) => {
                    return obj.literatureLink === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UploadfileUrl:
                return (obj) => {
                    return obj.uploadfileUrl === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsQuotethesis:
                return (obj) => {
                    return obj.isQuotethesis === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Checker:
                return (obj) => {
                    return obj.checker === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsChecked:
                return (obj) => {
                    return obj.isChecked === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorID:
                return (obj) => {
                    return obj.majorID === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vMajorDirectionPaperRela]中不存在！(in ${exports.vMajorDirectionPaperRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vMajorDirectionPaperRela_FilterFunByKey = vMajorDirectionPaperRela_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vMajorDirectionPaperRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMajorDirectionPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMajorDirectionPaperRela_GetFirstIDAsync = vMajorDirectionPaperRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vMajorDirectionPaperRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMajorDirectionPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMajorDirectionPaperRela_GetFirstID = vMajorDirectionPaperRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vMajorDirectionPaperRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMajorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvMajorDirectionPaperRela = vMajorDirectionPaperRela_GetObjFromJsonObj(returnObj);
                return objvMajorDirectionPaperRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMajorDirectionPaperRela_GetFirstObjAsync = vMajorDirectionPaperRela_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vMajorDirectionPaperRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMajorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vMajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMajorDirectionPaperRela_GetObjLstAsync = vMajorDirectionPaperRela_GetObjLstAsync;
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
    async function vMajorDirectionPaperRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMajorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vMajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMajorDirectionPaperRela_GetObjLstBymIdLstAsync = vMajorDirectionPaperRela_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vMajorDirectionPaperRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMajorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vMajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMajorDirectionPaperRela_GetTopObjLstAsync = vMajorDirectionPaperRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vMajorDirectionPaperRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMajorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vMajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMajorDirectionPaperRela_GetObjLstByRangeAsync = vMajorDirectionPaperRela_GetObjLstByRangeAsync;
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
    async function vMajorDirectionPaperRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMajorDirectionPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMajorDirectionPaperRela_GetObjLstByRange = vMajorDirectionPaperRela_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vMajorDirectionPaperRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMajorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vMajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMajorDirectionPaperRela_GetObjLstByPagerAsync = vMajorDirectionPaperRela_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vMajorDirectionPaperRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMajorDirectionPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMajorDirectionPaperRela_IsExistRecordAsync = vMajorDirectionPaperRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vMajorDirectionPaperRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMajorDirectionPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMajorDirectionPaperRela_IsExist = vMajorDirectionPaperRela_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vMajorDirectionPaperRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMajorDirectionPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMajorDirectionPaperRela_IsExistAsync = vMajorDirectionPaperRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vMajorDirectionPaperRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMajorDirectionPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMajorDirectionPaperRela_GetRecCountByCondAsync = vMajorDirectionPaperRela_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vMajorDirectionPaperRela_GetWebApiUrl(strController, strAction) {
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
    exports.vMajorDirectionPaperRela_GetWebApiUrl = vMajorDirectionPaperRela_GetWebApiUrl;
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
    function vMajorDirectionPaperRela_GetJSONStrByObj(pobjvMajorDirectionPaperRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvMajorDirectionPaperRelaEN);
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
    exports.vMajorDirectionPaperRela_GetJSONStrByObj = vMajorDirectionPaperRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vMajorDirectionPaperRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvMajorDirectionPaperRelaObjLst = new Array();
        if (strJSON === "") {
            return arrvMajorDirectionPaperRelaObjLst;
        }
        try {
            arrvMajorDirectionPaperRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvMajorDirectionPaperRelaObjLst;
        }
        return arrvMajorDirectionPaperRelaObjLst;
    }
    exports.vMajorDirectionPaperRela_GetObjLstByJSONStr = vMajorDirectionPaperRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvMajorDirectionPaperRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vMajorDirectionPaperRela_GetObjLstByJSONObjLst(arrvMajorDirectionPaperRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvMajorDirectionPaperRelaObjLst = new Array();
        for (const objInFor of arrvMajorDirectionPaperRelaObjLstS) {
            const obj1 = vMajorDirectionPaperRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvMajorDirectionPaperRelaObjLst.push(obj1);
        }
        return arrvMajorDirectionPaperRelaObjLst;
    }
    exports.vMajorDirectionPaperRela_GetObjLstByJSONObjLst = vMajorDirectionPaperRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vMajorDirectionPaperRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN();
        if (strJSON === "") {
            return pobjvMajorDirectionPaperRelaEN;
        }
        try {
            pobjvMajorDirectionPaperRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvMajorDirectionPaperRelaEN;
        }
        return pobjvMajorDirectionPaperRelaEN;
    }
    exports.vMajorDirectionPaperRela_GetObjByJSONStr = vMajorDirectionPaperRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vMajorDirectionPaperRela_GetCombineCondition(objvMajorDirectionPaperRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_mId, objvMajorDirectionPaperRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionId) == true) {
            const strComparisonOp_MajorDirectionId = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionId, objvMajorDirectionPaperRela_Cond.majorDirectionId, strComparisonOp_MajorDirectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_PaperId, objvMajorDirectionPaperRela_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UpdDate, objvMajorDirectionPaperRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UpdUser, objvMajorDirectionPaperRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Memo, objvMajorDirectionPaperRela_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_id_XzMajor, objvMajorDirectionPaperRela_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionENName) == true) {
            const strComparisonOp_MajorDirectionENName = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionENName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionENName, objvMajorDirectionPaperRela_Cond.majorDirectionENName, strComparisonOp_MajorDirectionENName);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionName) == true) {
            const strComparisonOp_MajorDirectionName = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionName, objvMajorDirectionPaperRela_Cond.majorDirectionName, strComparisonOp_MajorDirectionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionExplain) == true) {
            const strComparisonOp_MajorDirectionExplain = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionExplain];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionExplain, objvMajorDirectionPaperRela_Cond.majorDirectionExplain, strComparisonOp_MajorDirectionExplain);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsVisible) == true) {
            if (objvMajorDirectionPaperRela_Cond.isVisible == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsVisible);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsVisible);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_PaperTitle, objvMajorDirectionPaperRela_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Periodical) == true) {
            const strComparisonOp_Periodical = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Periodical];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Periodical, objvMajorDirectionPaperRela_Cond.periodical, strComparisonOp_Periodical);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Author) == true) {
            const strComparisonOp_Author = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Author];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Author, objvMajorDirectionPaperRela_Cond.author, strComparisonOp_Author);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_ResearchQuestion) == true) {
            const strComparisonOp_ResearchQuestion = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_ResearchQuestion];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_ResearchQuestion, objvMajorDirectionPaperRela_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Keyword) == true) {
            const strComparisonOp_Keyword = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Keyword];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Keyword, objvMajorDirectionPaperRela_Cond.keyword, strComparisonOp_Keyword);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_LiteratureSources) == true) {
            const strComparisonOp_LiteratureSources = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_LiteratureSources];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_LiteratureSources, objvMajorDirectionPaperRela_Cond.literatureSources, strComparisonOp_LiteratureSources);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_LiteratureLink) == true) {
            const strComparisonOp_LiteratureLink = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_LiteratureLink];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_LiteratureLink, objvMajorDirectionPaperRela_Cond.literatureLink, strComparisonOp_LiteratureLink);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UploadfileUrl) == true) {
            const strComparisonOp_UploadfileUrl = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UploadfileUrl];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UploadfileUrl, objvMajorDirectionPaperRela_Cond.uploadfileUrl, strComparisonOp_UploadfileUrl);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsQuotethesis) == true) {
            if (objvMajorDirectionPaperRela_Cond.isQuotethesis == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsQuotethesis);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsQuotethesis);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Checker) == true) {
            const strComparisonOp_Checker = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Checker];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_Checker, objvMajorDirectionPaperRela_Cond.checker, strComparisonOp_Checker);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsChecked) == true) {
            if (objvMajorDirectionPaperRela_Cond.isChecked == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsChecked);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_IsChecked);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorID) == true) {
            const strComparisonOp_MajorID = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorID, objvMajorDirectionPaperRela_Cond.majorID, strComparisonOp_MajorID);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorName, objvMajorDirectionPaperRela_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_UserName, objvMajorDirectionPaperRela_Cond.userName, strComparisonOp_UserName);
        }
        return strWhereCond;
    }
    exports.vMajorDirectionPaperRela_GetCombineCondition = vMajorDirectionPaperRela_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvMajorDirectionPaperRelaENS:源对象
     * @param objvMajorDirectionPaperRelaENT:目标对象
    */
    function vMajorDirectionPaperRela_CopyObjTo(objvMajorDirectionPaperRelaENS, objvMajorDirectionPaperRelaENT) {
        objvMajorDirectionPaperRelaENT.mId = objvMajorDirectionPaperRelaENS.mId; //mId
        objvMajorDirectionPaperRelaENT.majorDirectionId = objvMajorDirectionPaperRelaENS.majorDirectionId; //研究方向Id
        objvMajorDirectionPaperRelaENT.paperId = objvMajorDirectionPaperRelaENS.paperId; //论文Id
        objvMajorDirectionPaperRelaENT.updDate = objvMajorDirectionPaperRelaENS.updDate; //修改日期
        objvMajorDirectionPaperRelaENT.updUser = objvMajorDirectionPaperRelaENS.updUser; //修改人
        objvMajorDirectionPaperRelaENT.memo = objvMajorDirectionPaperRelaENS.memo; //备注
        objvMajorDirectionPaperRelaENT.id_XzMajor = objvMajorDirectionPaperRelaENS.id_XzMajor; //专业流水号
        objvMajorDirectionPaperRelaENT.majorDirectionENName = objvMajorDirectionPaperRelaENS.majorDirectionENName; //研究方向英文名
        objvMajorDirectionPaperRelaENT.majorDirectionName = objvMajorDirectionPaperRelaENS.majorDirectionName; //研究方向名
        objvMajorDirectionPaperRelaENT.majorDirectionExplain = objvMajorDirectionPaperRelaENS.majorDirectionExplain; //专业方向说明
        objvMajorDirectionPaperRelaENT.isVisible = objvMajorDirectionPaperRelaENS.isVisible; //是否显示
        objvMajorDirectionPaperRelaENT.paperTitle = objvMajorDirectionPaperRelaENS.paperTitle; //论文标题
        objvMajorDirectionPaperRelaENT.paperContent = objvMajorDirectionPaperRelaENS.paperContent; //主题内容
        objvMajorDirectionPaperRelaENT.periodical = objvMajorDirectionPaperRelaENS.periodical; //期刊
        objvMajorDirectionPaperRelaENT.author = objvMajorDirectionPaperRelaENS.author; //作者
        objvMajorDirectionPaperRelaENT.researchQuestion = objvMajorDirectionPaperRelaENS.researchQuestion; //研究问题
        objvMajorDirectionPaperRelaENT.keyword = objvMajorDirectionPaperRelaENS.keyword; //关键字
        objvMajorDirectionPaperRelaENT.literatureSources = objvMajorDirectionPaperRelaENS.literatureSources; //文献来源
        objvMajorDirectionPaperRelaENT.literatureLink = objvMajorDirectionPaperRelaENS.literatureLink; //文献链接
        objvMajorDirectionPaperRelaENT.uploadfileUrl = objvMajorDirectionPaperRelaENS.uploadfileUrl; //文件地址
        objvMajorDirectionPaperRelaENT.isQuotethesis = objvMajorDirectionPaperRelaENS.isQuotethesis; //是否引用论文
        objvMajorDirectionPaperRelaENT.checker = objvMajorDirectionPaperRelaENS.checker; //审核人
        objvMajorDirectionPaperRelaENT.isChecked = objvMajorDirectionPaperRelaENS.isChecked; //是否检查
        objvMajorDirectionPaperRelaENT.majorID = objvMajorDirectionPaperRelaENS.majorID; //专业ID
        objvMajorDirectionPaperRelaENT.majorName = objvMajorDirectionPaperRelaENS.majorName; //专业名称
        objvMajorDirectionPaperRelaENT.userName = objvMajorDirectionPaperRelaENS.userName; //用户名
    }
    exports.vMajorDirectionPaperRela_CopyObjTo = vMajorDirectionPaperRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvMajorDirectionPaperRelaENS:源对象
     * @param objvMajorDirectionPaperRelaENT:目标对象
    */
    function vMajorDirectionPaperRela_GetObjFromJsonObj(objvMajorDirectionPaperRelaENS) {
        const objvMajorDirectionPaperRelaENT = new clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvMajorDirectionPaperRelaENT, objvMajorDirectionPaperRelaENS);
        return objvMajorDirectionPaperRelaENT;
    }
    exports.vMajorDirectionPaperRela_GetObjFromJsonObj = vMajorDirectionPaperRela_GetObjFromJsonObj;
});
