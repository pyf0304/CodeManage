/**
* 类名:clsvgs_TagsWApi
* 表名:vgs_Tags(01120757)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:33
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
        define(["require", "exports", "axios", "../../L0_Entity/InteractManage/clsvgs_TagsEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_Tags_GetObjFromJsonObj = exports.vgs_Tags_CopyObjTo = exports.vgs_Tags_GetCombineCondition = exports.vgs_Tags_GetObjByJSONStr = exports.vgs_Tags_GetObjLstByJSONObjLst = exports.vgs_Tags_GetObjLstByJSONStr = exports.vgs_Tags_GetJSONStrByObj = exports.vgs_Tags_GetWebApiUrl = exports.vgs_Tags_GetRecCountByCondAsync = exports.vgs_Tags_IsExistAsync = exports.vgs_Tags_IsExist = exports.vgs_Tags_IsExistRecordAsync = exports.vgs_Tags_GetObjLstByPagerAsync = exports.vgs_Tags_GetObjLstByRange = exports.vgs_Tags_GetObjLstByRangeAsync = exports.vgs_Tags_GetTopObjLstAsync = exports.vgs_Tags_GetObjLstByTagsIdLstAsync = exports.vgs_Tags_GetObjLstAsync = exports.vgs_Tags_GetFirstObjAsync = exports.vgs_Tags_GetFirstID = exports.vgs_Tags_GetFirstIDAsync = exports.vgs_Tags_FilterFunByKey = exports.vgs_Tags_SortFunByKey = exports.vgs_Tags_SortFun_Defa_2Fld = exports.vgs_Tags_SortFun_Defa = exports.vgs_Tags_GetObjByTagsIdAsync = exports.vgs_Tags_ConstructorName = exports.vgs_Tags_Controller = void 0;
    /**
     * 论文标注视图(vgs_Tags)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvgs_TagsEN_js_1 = require("../../L0_Entity/InteractManage/clsvgs_TagsEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vgs_Tags_Controller = "vgs_TagsApi";
    exports.vgs_Tags_ConstructorName = "vgs_Tags";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strTagsId:关键字
    * @returns 对象
    **/
    async function vgs_Tags_GetObjByTagsIdAsync(strTagsId) {
        const strThisFuncName = "GetObjByTagsIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTagsId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTagsId]不能为空！(In GetObjByTagsIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTagsId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTagsId]的长度:[{0}]不正确！", strTagsId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByTagsId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strTagsId": strTagsId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_Tags_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvgs_Tags = vgs_Tags_GetObjFromJsonObj(returnObj);
                return objvgs_Tags;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_Tags_GetObjByTagsIdAsync = vgs_Tags_GetObjByTagsIdAsync;
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
    function vgs_Tags_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.tagsId.localeCompare(b.tagsId);
    }
    exports.vgs_Tags_SortFun_Defa = vgs_Tags_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_Tags_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.tagsContent == b.tagsContent)
            return a.pdfContent.localeCompare(b.pdfContent);
        else
            return a.tagsContent.localeCompare(b.tagsContent);
    }
    exports.vgs_Tags_SortFun_Defa_2Fld = vgs_Tags_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_Tags_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_TagsId:
                    return (a, b) => {
                        return a.tagsId.localeCompare(b.tagsId);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_TagsContent:
                    return (a, b) => {
                        return a.tagsContent.localeCompare(b.tagsContent);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfContent:
                    return (a, b) => {
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_VoteCount:
                    return (a, b) => {
                        return a.voteCount - b.voteCount;
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfLineNum:
                    return (a, b) => {
                        return a.pdfLineNum - b.pdfLineNum;
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfX:
                    return (a, b) => {
                        return a.pdfX.localeCompare(b.pdfX);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfY:
                    return (a, b) => {
                        return a.pdfY.localeCompare(b.pdfY);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageNumIn:
                    return (a, b) => {
                        return a.pdfPageNumIn.localeCompare(b.pdfPageNumIn);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageTop:
                    return (a, b) => {
                        return a.pdfPageTop - b.pdfPageTop;
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfDivLet:
                    return (a, b) => {
                        return a.pdfDivLet.localeCompare(b.pdfDivLet);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfDivTop:
                    return (a, b) => {
                        return a.pdfDivTop.localeCompare(b.pdfDivTop);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfZoom:
                    return (a, b) => {
                        return a.pdfZoom.localeCompare(b.pdfZoom);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_TagsTypeId:
                    return (a, b) => {
                        return a.tagsTypeId.localeCompare(b.tagsTypeId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_Tags]中不存在！(in ${exports.vgs_Tags_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_TagsId:
                    return (a, b) => {
                        return b.tagsId.localeCompare(a.tagsId);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_TagsContent:
                    return (a, b) => {
                        return b.tagsContent.localeCompare(a.tagsContent);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfContent:
                    return (a, b) => {
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_VoteCount:
                    return (a, b) => {
                        return b.voteCount - a.voteCount;
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfLineNum:
                    return (a, b) => {
                        return b.pdfLineNum - a.pdfLineNum;
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfX:
                    return (a, b) => {
                        return b.pdfX.localeCompare(a.pdfX);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfY:
                    return (a, b) => {
                        return b.pdfY.localeCompare(a.pdfY);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageNumIn:
                    return (a, b) => {
                        return b.pdfPageNumIn.localeCompare(a.pdfPageNumIn);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageTop:
                    return (a, b) => {
                        return b.pdfPageTop - a.pdfPageTop;
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfDivLet:
                    return (a, b) => {
                        return b.pdfDivLet.localeCompare(a.pdfDivLet);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfDivTop:
                    return (a, b) => {
                        return b.pdfDivTop.localeCompare(a.pdfDivTop);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfZoom:
                    return (a, b) => {
                        return b.pdfZoom.localeCompare(a.pdfZoom);
                    };
                case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_TagsTypeId:
                    return (a, b) => {
                        return b.tagsTypeId.localeCompare(a.tagsTypeId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_Tags]中不存在！(in ${exports.vgs_Tags_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vgs_Tags_SortFunByKey = vgs_Tags_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_Tags_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_TagsId:
                return (obj) => {
                    return obj.tagsId === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_TagsContent:
                return (obj) => {
                    return obj.tagsContent === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_VoteCount:
                return (obj) => {
                    return obj.voteCount === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfLineNum:
                return (obj) => {
                    return obj.pdfLineNum === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfX:
                return (obj) => {
                    return obj.pdfX === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfY:
                return (obj) => {
                    return obj.pdfY === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageNumIn:
                return (obj) => {
                    return obj.pdfPageNumIn === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageTop:
                return (obj) => {
                    return obj.pdfPageTop === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfDivLet:
                return (obj) => {
                    return obj.pdfDivLet === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfDivTop:
                return (obj) => {
                    return obj.pdfDivTop === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfZoom:
                return (obj) => {
                    return obj.pdfZoom === value;
                };
            case clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_TagsTypeId:
                return (obj) => {
                    return obj.tagsTypeId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vgs_Tags]中不存在！(in ${exports.vgs_Tags_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vgs_Tags_FilterFunByKey = vgs_Tags_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vgs_Tags_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_Tags_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_Tags_GetFirstIDAsync = vgs_Tags_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vgs_Tags_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_Tags_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_Tags_GetFirstID = vgs_Tags_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vgs_Tags_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_Tags_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvgs_Tags = vgs_Tags_GetObjFromJsonObj(returnObj);
                return objvgs_Tags;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_Tags_GetFirstObjAsync = vgs_Tags_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vgs_Tags_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_Tags_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_Tags_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_Tags_GetObjLstAsync = vgs_Tags_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrTagsId:关键字列表
    * @returns 对象列表
    **/
    async function vgs_Tags_GetObjLstByTagsIdLstAsync(arrTagsId) {
        const strThisFuncName = "GetObjLstByTagsIdLstAsync";
        const strAction = "GetObjLstByTagsIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTagsId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_Tags_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_Tags_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_Tags_GetObjLstByTagsIdLstAsync = vgs_Tags_GetObjLstByTagsIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vgs_Tags_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_Tags_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_Tags_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_Tags_GetTopObjLstAsync = vgs_Tags_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_Tags_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_Tags_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_Tags_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_Tags_GetObjLstByRangeAsync = vgs_Tags_GetObjLstByRangeAsync;
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
    async function vgs_Tags_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_Tags_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_Tags_GetObjLstByRange = vgs_Tags_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_Tags_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_Tags_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_Tags_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_Tags_GetObjLstByPagerAsync = vgs_Tags_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vgs_Tags_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_Tags_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_Tags_IsExistRecordAsync = vgs_Tags_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strTagsId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vgs_Tags_IsExist(strTagsId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "TagsId": strTagsId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_Tags_IsExist = vgs_Tags_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strTagsId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vgs_Tags_IsExistAsync(strTagsId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strTagsId": strTagsId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_Tags_IsExistAsync = vgs_Tags_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vgs_Tags_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_Tags_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_Tags_GetRecCountByCondAsync = vgs_Tags_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vgs_Tags_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_Tags_GetWebApiUrl = vgs_Tags_GetWebApiUrl;
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
    function vgs_Tags_GetJSONStrByObj(pobjvgs_TagsEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvgs_TagsEN);
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
    exports.vgs_Tags_GetJSONStrByObj = vgs_Tags_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vgs_Tags_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvgs_TagsObjLst = new Array();
        if (strJSON === "") {
            return arrvgs_TagsObjLst;
        }
        try {
            arrvgs_TagsObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvgs_TagsObjLst;
        }
        return arrvgs_TagsObjLst;
    }
    exports.vgs_Tags_GetObjLstByJSONStr = vgs_Tags_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvgs_TagsObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vgs_Tags_GetObjLstByJSONObjLst(arrvgs_TagsObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvgs_TagsObjLst = new Array();
        for (const objInFor of arrvgs_TagsObjLstS) {
            const obj1 = vgs_Tags_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvgs_TagsObjLst.push(obj1);
        }
        return arrvgs_TagsObjLst;
    }
    exports.vgs_Tags_GetObjLstByJSONObjLst = vgs_Tags_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_Tags_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvgs_TagsEN = new clsvgs_TagsEN_js_1.clsvgs_TagsEN();
        if (strJSON === "") {
            return pobjvgs_TagsEN;
        }
        try {
            pobjvgs_TagsEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvgs_TagsEN;
        }
        return pobjvgs_TagsEN;
    }
    exports.vgs_Tags_GetObjByJSONStr = vgs_Tags_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vgs_Tags_GetCombineCondition(objvgs_Tags_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_TagsId) == true) {
            const strComparisonOp_TagsId = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_TagsId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_TagsId, objvgs_Tags_Cond.tagsId, strComparisonOp_TagsId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfContent, objvgs_Tags_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageNum, objvgs_Tags_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_VoteCount) == true) {
            const strComparisonOp_VoteCount = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_VoteCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_VoteCount, objvgs_Tags_Cond.voteCount, strComparisonOp_VoteCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_OrderNum, objvgs_Tags_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_UpdUser, objvgs_Tags_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_UpdDate, objvgs_Tags_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfLineNum) == true) {
            const strComparisonOp_PdfLineNum = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfLineNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfLineNum, objvgs_Tags_Cond.pdfLineNum, strComparisonOp_PdfLineNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfX) == true) {
            const strComparisonOp_PdfX = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfX];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfX, objvgs_Tags_Cond.pdfX, strComparisonOp_PdfX);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfY) == true) {
            const strComparisonOp_PdfY = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfY];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfY, objvgs_Tags_Cond.pdfY, strComparisonOp_PdfY);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_Memo, objvgs_Tags_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_id_CurrEduCls, objvgs_Tags_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PaperTitle, objvgs_Tags_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PaperId, objvgs_Tags_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_ShareId, objvgs_Tags_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageNumIn) == true) {
            const strComparisonOp_PdfPageNumIn = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageNumIn];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageNumIn, objvgs_Tags_Cond.pdfPageNumIn, strComparisonOp_PdfPageNumIn);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageTop) == true) {
            const strComparisonOp_PdfPageTop = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageTop];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfPageTop, objvgs_Tags_Cond.pdfPageTop, strComparisonOp_PdfPageTop);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfDivLet) == true) {
            const strComparisonOp_PdfDivLet = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfDivLet];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfDivLet, objvgs_Tags_Cond.pdfDivLet, strComparisonOp_PdfDivLet);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfDivTop) == true) {
            const strComparisonOp_PdfDivTop = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfDivTop];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfDivTop, objvgs_Tags_Cond.pdfDivTop, strComparisonOp_PdfDivTop);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfZoom) == true) {
            const strComparisonOp_PdfZoom = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfZoom];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_PdfZoom, objvgs_Tags_Cond.pdfZoom, strComparisonOp_PdfZoom);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_Tags_Cond.dicFldComparisonOp, clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_TagsTypeId) == true) {
            const strComparisonOp_TagsTypeId = objvgs_Tags_Cond.dicFldComparisonOp[clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_TagsTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TagsEN_js_1.clsvgs_TagsEN.con_TagsTypeId, objvgs_Tags_Cond.tagsTypeId, strComparisonOp_TagsTypeId);
        }
        return strWhereCond;
    }
    exports.vgs_Tags_GetCombineCondition = vgs_Tags_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvgs_TagsENS:源对象
     * @param objvgs_TagsENT:目标对象
    */
    function vgs_Tags_CopyObjTo(objvgs_TagsENS, objvgs_TagsENT) {
        objvgs_TagsENT.tagsId = objvgs_TagsENS.tagsId; //标注Id
        objvgs_TagsENT.tagsContent = objvgs_TagsENS.tagsContent; //标注内容
        objvgs_TagsENT.pdfContent = objvgs_TagsENS.pdfContent; //Pdf内容
        objvgs_TagsENT.pdfPageNum = objvgs_TagsENS.pdfPageNum; //Pdf页码
        objvgs_TagsENT.voteCount = objvgs_TagsENS.voteCount; //点赞计数
        objvgs_TagsENT.orderNum = objvgs_TagsENS.orderNum; //序号
        objvgs_TagsENT.updUser = objvgs_TagsENS.updUser; //修改人
        objvgs_TagsENT.updDate = objvgs_TagsENS.updDate; //修改日期
        objvgs_TagsENT.pdfLineNum = objvgs_TagsENS.pdfLineNum; //pdf行号
        objvgs_TagsENT.pdfX = objvgs_TagsENS.pdfX; //PdfX
        objvgs_TagsENT.pdfY = objvgs_TagsENS.pdfY; //PdfY
        objvgs_TagsENT.memo = objvgs_TagsENS.memo; //备注
        objvgs_TagsENT.id_CurrEduCls = objvgs_TagsENS.id_CurrEduCls; //教学班流水号
        objvgs_TagsENT.paperTitle = objvgs_TagsENS.paperTitle; //论文标题
        objvgs_TagsENT.paperId = objvgs_TagsENS.paperId; //论文Id
        objvgs_TagsENT.shareId = objvgs_TagsENS.shareId; //分享Id
        objvgs_TagsENT.pdfPageNumIn = objvgs_TagsENS.pdfPageNumIn; //PdfPageNumIn
        objvgs_TagsENT.pdfPageTop = objvgs_TagsENS.pdfPageTop; //pdf页面顶部位置
        objvgs_TagsENT.pdfDivLet = objvgs_TagsENS.pdfDivLet; //PdfDivLet
        objvgs_TagsENT.pdfDivTop = objvgs_TagsENS.pdfDivTop; //PdfDivTop
        objvgs_TagsENT.pdfZoom = objvgs_TagsENS.pdfZoom; //PdfZoom
        objvgs_TagsENT.tagsTypeId = objvgs_TagsENS.tagsTypeId; //标注类型ID
    }
    exports.vgs_Tags_CopyObjTo = vgs_Tags_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvgs_TagsENS:源对象
     * @param objvgs_TagsENT:目标对象
    */
    function vgs_Tags_GetObjFromJsonObj(objvgs_TagsENS) {
        const objvgs_TagsENT = new clsvgs_TagsEN_js_1.clsvgs_TagsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_TagsENT, objvgs_TagsENS);
        return objvgs_TagsENT;
    }
    exports.vgs_Tags_GetObjFromJsonObj = vgs_Tags_GetObjFromJsonObj;
});
