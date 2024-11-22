/**
* 类名:clsgs_TagsWApi
* 表名:gs_Tags(01120714)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:51:50
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/InteractManage/clsgs_TagsEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_Tags_GetObjFromJsonObj = exports.gs_Tags_CopyObjTo = exports.gs_Tags_GetUniCondStr4Update_PaperId_TagsId = exports.gs_Tags_GetUniCondStr_PaperId_TagsId = exports.gs_Tags_GetCombineCondition = exports.gs_Tags_GetObjByJSONStr = exports.gs_Tags_GetObjLstByJSONObjLst = exports.gs_Tags_GetObjLstByJSONStr = exports.gs_Tags_GetJSONStrByObj = exports.gs_Tags_CheckProperty4Update = exports.gs_Tags_CheckPropertyNew = exports.gs_Tags_ReFreshThisCache = exports.gs_Tags_ReFreshCache = exports.gs_Tags_GetWebApiUrl = exports.gs_Tags_GetMaxStrIdByPrefix = exports.gs_Tags_GetMaxStrIdAsync = exports.gs_Tags_GetRecCountByCond_Cache = exports.gs_Tags_GetRecCountByCondAsync = exports.gs_Tags_IsExistAsync = exports.gs_Tags_IsExist_Cache = exports.gs_Tags_IsExist = exports.gs_Tags_IsExistRecordAsync = exports.gs_Tags_IsExistRecord_Cache = exports.gs_Tags_UpdateWithConditionAsync = exports.gs_Tags_UpdateRecordAsync = exports.gs_Tags_AddNewRecordWithReturnKey = exports.gs_Tags_AddNewRecordWithReturnKeyAsync = exports.gs_Tags_ReOrderAsync = exports.gs_Tags_GoBottomAsync = exports.gs_Tags_DownMoveAsync = exports.gs_Tags_UpMoveAsync = exports.gs_Tags_GoTopAsync = exports.gs_Tags_AddNewRecordWithMaxIdAsync = exports.gs_Tags_AddNewRecordAsync = exports.gs_Tags_Delgs_TagssByCondAsync = exports.gs_Tags_Delgs_TagssAsync = exports.gs_Tags_DelRecordAsync = exports.gs_Tags_GetObjLstByPagerAsync = exports.gs_Tags_GetObjLstByPager_Cache = exports.gs_Tags_GetObjLstByRange = exports.gs_Tags_GetObjLstByRangeAsync = exports.gs_Tags_GetTopObjLstAsync = exports.gs_Tags_GetObjLstByTagsIdLst_Cache = exports.gs_Tags_GetObjLstByTagsIdLstAsync = exports.gs_Tags_GetSubObjLst_Cache = exports.gs_Tags_GetObjLst_PureCache = exports.gs_Tags_GetObjLst_Cache = exports.gs_Tags_GetObjLst_sessionStorage_PureCache = exports.gs_Tags_GetObjLst_sessionStorage = exports.gs_Tags_GetObjLstAsync = exports.gs_Tags_GetObjLst_localStorage_PureCache = exports.gs_Tags_GetObjLst_localStorage = exports.gs_Tags_GetObjLst_ClientCache = exports.gs_Tags_GetFirstObjAsync = exports.gs_Tags_GetFirstID = exports.gs_Tags_GetFirstIDAsync = exports.gs_Tags_funcKey = exports.gs_Tags_FilterFunByKey = exports.gs_Tags_SortFunByKey = exports.gs_Tags_SortFun_Defa_2Fld = exports.gs_Tags_SortFun_Defa = exports.gs_Tags_func = exports.gs_Tags_UpdateObjInLst_Cache = exports.gs_Tags_GetObjByTagsId_localStorage = exports.gs_Tags_GetObjByTagsId_Cache = exports.gs_Tags_GetObjByTagsIdAsync = exports.gs_Tags_ConstructorName = exports.gs_Tags_Controller = void 0;
    /**
     * 标注(gs_Tags)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_TagsEN_js_1 = require("../../L0_Entity/InteractManage/clsgs_TagsEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.gs_Tags_Controller = "gs_TagsApi";
    exports.gs_Tags_ConstructorName = "gs_Tags";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strTagsId:关键字
    * @returns 对象
    **/
    async function gs_Tags_GetObjByTagsIdAsync(strTagsId) {
        const strThisFuncName = "GetObjByTagsIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTagsId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTagsId]不能为空！(In clsgs_TagsWApi.GetObjByTagsIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTagsId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTagsId]的长度:[{0}]不正确！(clsgs_TagsWApi.GetObjByTagsIdAsync)", strTagsId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByTagsId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
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
                    return null;
                }
                //console.log(returnObj);
                const objgs_Tags = gs_Tags_GetObjFromJsonObj(returnObj);
                return objgs_Tags;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_GetObjByTagsIdAsync = gs_Tags_GetObjByTagsIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strTagsId:所给的关键字
     * @returns 对象
    */
    async function gs_Tags_GetObjByTagsId_Cache(strTagsId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByTagsId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTagsId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTagsId]不能为空！(In clsgs_TagsWApi.GetObjByTagsId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTagsId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTagsId]的长度:[{0}]不正确！(clsgs_TagsWApi.GetObjByTagsId_Cache)", strTagsId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_Cache();
        try {
            const arrgs_Tags_Sel = arrgs_TagsObjLst_Cache.filter(x => x.tagsId == strTagsId);
            let objgs_Tags;
            if (arrgs_Tags_Sel.length > 0) {
                objgs_Tags = arrgs_Tags_Sel[0];
                return objgs_Tags;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objgs_Tags_Const = await gs_Tags_GetObjByTagsIdAsync(strTagsId);
                    if (objgs_Tags_Const != null) {
                        gs_Tags_ReFreshThisCache();
                        return objgs_Tags_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTagsId, exports.gs_Tags_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_Tags_GetObjByTagsId_Cache = gs_Tags_GetObjByTagsId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strTagsId:所给的关键字
     * @returns 对象
    */
    async function gs_Tags_GetObjByTagsId_localStorage(strTagsId) {
        const strThisFuncName = "GetObjByTagsId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTagsId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTagsId]不能为空！(In clsgs_TagsWApi.GetObjByTagsId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTagsId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTagsId]的长度:[{0}]不正确！(clsgs_TagsWApi.GetObjByTagsId_localStorage)", strTagsId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_TagsEN_js_1.clsgs_TagsEN._CurrTabName, strTagsId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_Tags_Cache = JSON.parse(strTempObj);
            return objgs_Tags_Cache;
        }
        try {
            const objgs_Tags = await gs_Tags_GetObjByTagsIdAsync(strTagsId);
            if (objgs_Tags != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_Tags));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_Tags;
            }
            return objgs_Tags;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTagsId, exports.gs_Tags_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_Tags_GetObjByTagsId_localStorage = gs_Tags_GetObjByTagsId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_Tags:所给的对象
     * @returns 对象
    */
    async function gs_Tags_UpdateObjInLst_Cache(objgs_Tags) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_Cache();
            const obj = arrgs_TagsObjLst_Cache.find(x => x.paperId == objgs_Tags.paperId && x.tagsId == objgs_Tags.tagsId);
            if (obj != null) {
                objgs_Tags.tagsId = obj.tagsId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_Tags);
            }
            else {
                arrgs_TagsObjLst_Cache.push(objgs_Tags);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_Tags_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_Tags_UpdateObjInLst_Cache = gs_Tags_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function gs_Tags_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_TagsEN_js_1.clsgs_TagsEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsgs_TagsEN_js_1.clsgs_TagsEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strTagsId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objgs_Tags = await gs_Tags_GetObjByTagsId_Cache(strTagsId);
        if (objgs_Tags == null)
            return "";
        if (objgs_Tags.GetFldValue(strOutFldName) == null)
            return "";
        return objgs_Tags.GetFldValue(strOutFldName).toString();
    }
    exports.gs_Tags_func = gs_Tags_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_Tags_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.tagsId.localeCompare(b.tagsId);
    }
    exports.gs_Tags_SortFun_Defa = gs_Tags_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_Tags_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.tagsContent == b.tagsContent)
            return a.pdfContent.localeCompare(b.pdfContent);
        else
            return a.tagsContent.localeCompare(b.tagsContent);
    }
    exports.gs_Tags_SortFun_Defa_2Fld = gs_Tags_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_Tags_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsId:
                    return (a, b) => {
                        return a.tagsId.localeCompare(b.tagsId);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsContent:
                    return (a, b) => {
                        if (a.tagsContent == null)
                            return -1;
                        if (b.tagsContent == null)
                            return 1;
                        return a.tagsContent.localeCompare(b.tagsContent);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfContent:
                    return (a, b) => {
                        if (a.pdfContent == null)
                            return -1;
                        if (b.pdfContent == null)
                            return 1;
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_VoteCount:
                    return (a, b) => {
                        return a.voteCount - b.voteCount;
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_UserId:
                    return (a, b) => {
                        if (a.userId == null)
                            return -1;
                        if (b.userId == null)
                            return 1;
                        return a.userId.localeCompare(b.userId);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfLineNum:
                    return (a, b) => {
                        return a.pdfLineNum - b.pdfLineNum;
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfX:
                    return (a, b) => {
                        if (a.pdfX == null)
                            return -1;
                        if (b.pdfX == null)
                            return 1;
                        return a.pdfX.localeCompare(b.pdfX);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfY:
                    return (a, b) => {
                        if (a.pdfY == null)
                            return -1;
                        if (b.pdfY == null)
                            return 1;
                        return a.pdfY.localeCompare(b.pdfY);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_ShareId:
                    return (a, b) => {
                        if (a.shareId == null)
                            return -1;
                        if (b.shareId == null)
                            return 1;
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageNumIn:
                    return (a, b) => {
                        if (a.pdfPageNumIn == null)
                            return -1;
                        if (b.pdfPageNumIn == null)
                            return 1;
                        return a.pdfPageNumIn.localeCompare(b.pdfPageNumIn);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageTop:
                    return (a, b) => {
                        return a.pdfPageTop - b.pdfPageTop;
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfDivLet:
                    return (a, b) => {
                        if (a.pdfDivLet == null)
                            return -1;
                        if (b.pdfDivLet == null)
                            return 1;
                        return a.pdfDivLet.localeCompare(b.pdfDivLet);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfDivTop:
                    return (a, b) => {
                        if (a.pdfDivTop == null)
                            return -1;
                        if (b.pdfDivTop == null)
                            return 1;
                        return a.pdfDivTop.localeCompare(b.pdfDivTop);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfZoom:
                    return (a, b) => {
                        if (a.pdfZoom == null)
                            return -1;
                        if (b.pdfZoom == null)
                            return 1;
                        return a.pdfZoom.localeCompare(b.pdfZoom);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsTypeId:
                    return (a, b) => {
                        if (a.tagsTypeId == null)
                            return -1;
                        if (b.tagsTypeId == null)
                            return 1;
                        return a.tagsTypeId.localeCompare(b.tagsTypeId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_Tags]中不存在！(in ${exports.gs_Tags_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsId:
                    return (a, b) => {
                        return b.tagsId.localeCompare(a.tagsId);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsContent:
                    return (a, b) => {
                        if (b.tagsContent == null)
                            return -1;
                        if (a.tagsContent == null)
                            return 1;
                        return b.tagsContent.localeCompare(a.tagsContent);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfContent:
                    return (a, b) => {
                        if (b.pdfContent == null)
                            return -1;
                        if (a.pdfContent == null)
                            return 1;
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_VoteCount:
                    return (a, b) => {
                        return b.voteCount - a.voteCount;
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_UserId:
                    return (a, b) => {
                        if (b.userId == null)
                            return -1;
                        if (a.userId == null)
                            return 1;
                        return b.userId.localeCompare(a.userId);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfLineNum:
                    return (a, b) => {
                        return b.pdfLineNum - a.pdfLineNum;
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfX:
                    return (a, b) => {
                        if (b.pdfX == null)
                            return -1;
                        if (a.pdfX == null)
                            return 1;
                        return b.pdfX.localeCompare(a.pdfX);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfY:
                    return (a, b) => {
                        if (b.pdfY == null)
                            return -1;
                        if (a.pdfY == null)
                            return 1;
                        return b.pdfY.localeCompare(a.pdfY);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_ShareId:
                    return (a, b) => {
                        if (b.shareId == null)
                            return -1;
                        if (a.shareId == null)
                            return 1;
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageNumIn:
                    return (a, b) => {
                        if (b.pdfPageNumIn == null)
                            return -1;
                        if (a.pdfPageNumIn == null)
                            return 1;
                        return b.pdfPageNumIn.localeCompare(a.pdfPageNumIn);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageTop:
                    return (a, b) => {
                        return b.pdfPageTop - a.pdfPageTop;
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfDivLet:
                    return (a, b) => {
                        if (b.pdfDivLet == null)
                            return -1;
                        if (a.pdfDivLet == null)
                            return 1;
                        return b.pdfDivLet.localeCompare(a.pdfDivLet);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfDivTop:
                    return (a, b) => {
                        if (b.pdfDivTop == null)
                            return -1;
                        if (a.pdfDivTop == null)
                            return 1;
                        return b.pdfDivTop.localeCompare(a.pdfDivTop);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfZoom:
                    return (a, b) => {
                        if (b.pdfZoom == null)
                            return -1;
                        if (a.pdfZoom == null)
                            return 1;
                        return b.pdfZoom.localeCompare(a.pdfZoom);
                    };
                case clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsTypeId:
                    return (a, b) => {
                        if (b.tagsTypeId == null)
                            return -1;
                        if (a.tagsTypeId == null)
                            return 1;
                        return b.tagsTypeId.localeCompare(a.tagsTypeId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_Tags]中不存在！(in ${exports.gs_Tags_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_Tags_SortFunByKey = gs_Tags_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_Tags_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsId:
                return (obj) => {
                    return obj.tagsId === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsContent:
                return (obj) => {
                    return obj.tagsContent === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_VoteCount:
                return (obj) => {
                    return obj.voteCount === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfLineNum:
                return (obj) => {
                    return obj.pdfLineNum === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfX:
                return (obj) => {
                    return obj.pdfX === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfY:
                return (obj) => {
                    return obj.pdfY === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageNumIn:
                return (obj) => {
                    return obj.pdfPageNumIn === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageTop:
                return (obj) => {
                    return obj.pdfPageTop === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfDivLet:
                return (obj) => {
                    return obj.pdfDivLet === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfDivTop:
                return (obj) => {
                    return obj.pdfDivTop === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfZoom:
                return (obj) => {
                    return obj.pdfZoom === value;
                };
            case clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsTypeId:
                return (obj) => {
                    return obj.tagsTypeId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_Tags]中不存在！(in ${exports.gs_Tags_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_Tags_FilterFunByKey = gs_Tags_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function gs_Tags_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrgs_Tags = await gs_Tags_GetObjLst_Cache();
        if (arrgs_Tags == null)
            return [];
        let arrgs_Tags_Sel = arrgs_Tags;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrgs_Tags_Sel.length == 0)
            return [];
        return arrgs_Tags_Sel.map(x => x.tagsId);
    }
    exports.gs_Tags_funcKey = gs_Tags_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_Tags_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_GetFirstIDAsync = gs_Tags_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_Tags_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_GetFirstID = gs_Tags_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_Tags_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
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
                const objgs_Tags = gs_Tags_GetObjFromJsonObj(returnObj);
                return objgs_Tags;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_GetFirstObjAsync = gs_Tags_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_Tags_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_TagsEN_js_1.clsgs_TagsEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_TagsEN_js_1.clsgs_TagsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_TagsEN_js_1.clsgs_TagsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_TagsExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrgs_TagsObjLst_T = gs_Tags_GetObjLstByJSONObjLst(arrgs_TagsExObjLst_Cache);
            return arrgs_TagsObjLst_T;
        }
        try {
            const arrgs_TagsExObjLst = await gs_Tags_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrgs_TagsExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TagsExObjLst.length);
            console.log(strInfo);
            return arrgs_TagsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_Tags_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_Tags_GetObjLst_ClientCache = gs_Tags_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_Tags_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_TagsEN_js_1.clsgs_TagsEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_TagsEN_js_1.clsgs_TagsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_TagsEN_js_1.clsgs_TagsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_TagsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_TagsObjLst_T = gs_Tags_GetObjLstByJSONObjLst(arrgs_TagsExObjLst_Cache);
            return arrgs_TagsObjLst_T;
        }
        try {
            const arrgs_TagsExObjLst = await gs_Tags_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_TagsExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TagsExObjLst.length);
            console.log(strInfo);
            return arrgs_TagsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_Tags_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_Tags_GetObjLst_localStorage = gs_Tags_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_Tags_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_TagsEN_js_1.clsgs_TagsEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_TagsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_TagsObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_Tags_GetObjLst_localStorage_PureCache = gs_Tags_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_Tags_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_Tags_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_Tags_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_GetObjLstAsync = gs_Tags_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_Tags_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_TagsEN_js_1.clsgs_TagsEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_TagsEN_js_1.clsgs_TagsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_TagsEN_js_1.clsgs_TagsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_TagsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_TagsObjLst_T = gs_Tags_GetObjLstByJSONObjLst(arrgs_TagsExObjLst_Cache);
            return arrgs_TagsObjLst_T;
        }
        try {
            const arrgs_TagsExObjLst = await gs_Tags_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_TagsExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TagsExObjLst.length);
            console.log(strInfo);
            return arrgs_TagsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_Tags_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_Tags_GetObjLst_sessionStorage = gs_Tags_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_Tags_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_TagsEN_js_1.clsgs_TagsEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_TagsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_TagsObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_Tags_GetObjLst_sessionStorage_PureCache = gs_Tags_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_Tags_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrgs_TagsObjLst_Cache;
        switch (clsgs_TagsEN_js_1.clsgs_TagsEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_ClientCache();
                break;
            default:
                arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_ClientCache();
                break;
        }
        const arrgs_TagsObjLst = gs_Tags_GetObjLstByJSONObjLst(arrgs_TagsObjLst_Cache);
        return arrgs_TagsObjLst_Cache;
    }
    exports.gs_Tags_GetObjLst_Cache = gs_Tags_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_Tags_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_TagsObjLst_Cache;
        switch (clsgs_TagsEN_js_1.clsgs_TagsEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrgs_TagsObjLst_Cache = null;
                break;
            default:
                arrgs_TagsObjLst_Cache = null;
                break;
        }
        return arrgs_TagsObjLst_Cache;
    }
    exports.gs_Tags_GetObjLst_PureCache = gs_Tags_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrTagsId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_Tags_GetSubObjLst_Cache(objgs_Tags_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_Cache();
        let arrgs_Tags_Sel = arrgs_TagsObjLst_Cache;
        if (objgs_Tags_Cond.sf_FldComparisonOp == null || objgs_Tags_Cond.sf_FldComparisonOp == "")
            return arrgs_Tags_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_Tags_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TagsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_Tags_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_Tags_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_Tags_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_Tags_Cond), exports.gs_Tags_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_Tags_GetSubObjLst_Cache = gs_Tags_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrTagsId:关键字列表
    * @returns 对象列表
    **/
    async function gs_Tags_GetObjLstByTagsIdLstAsync(arrTagsId) {
        const strThisFuncName = "GetObjLstByTagsIdLstAsync";
        const strAction = "GetObjLstByTagsIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTagsId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_Tags_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_Tags_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_GetObjLstByTagsIdLstAsync = gs_Tags_GetObjLstByTagsIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrTagsIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_Tags_GetObjLstByTagsIdLst_Cache(arrTagsIdLst) {
        const strThisFuncName = "GetObjLstByTagsIdLst_Cache";
        try {
            const arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_Cache();
            const arrgs_Tags_Sel = arrgs_TagsObjLst_Cache.filter(x => arrTagsIdLst.indexOf(x.tagsId) > -1);
            return arrgs_Tags_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTagsIdLst.join(","), exports.gs_Tags_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.gs_Tags_GetObjLstByTagsIdLst_Cache = gs_Tags_GetObjLstByTagsIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_Tags_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_Tags_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_Tags_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_GetTopObjLstAsync = gs_Tags_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_Tags_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_Tags_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_Tags_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_GetObjLstByRangeAsync = gs_Tags_GetObjLstByRangeAsync;
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
    async function gs_Tags_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_GetObjLstByRange = gs_Tags_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_Tags_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_Cache();
        if (arrgs_TagsObjLst_Cache.length == 0)
            return arrgs_TagsObjLst_Cache;
        let arrgs_Tags_Sel = arrgs_TagsObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_Tags_Cond = new clsgs_TagsEN_js_1.clsgs_TagsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_Tags_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_TagsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_Tags_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_Tags_Sel.length == 0)
                return arrgs_Tags_Sel;
            let intStart = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
            if (intStart <= 0)
                intStart = 0;
            const intEnd = intStart + objPagerPara.pageSize;
            if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
                const sstrSplit = objPagerPara.orderBy.split(" ");
                let strSortType = "asc";
                const strSortFld = sstrSplit[0];
                if (sstrSplit.length > 1)
                    strSortType = sstrSplit[1];
                arrgs_Tags_Sel = arrgs_Tags_Sel.sort(gs_Tags_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_Tags_Sel = arrgs_Tags_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_Tags_Sel = arrgs_Tags_Sel.slice(intStart, intEnd);
            return arrgs_Tags_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_Tags_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_Tags_GetObjLstByPager_Cache = gs_Tags_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_Tags_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_Tags_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_Tags_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_GetObjLstByPagerAsync = gs_Tags_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strTagsId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_Tags_DelRecordAsync(strTagsId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strTagsId);
        try {
            const response = await axios_1.default.delete(strUrl);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_DelRecordAsync = gs_Tags_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrTagsId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_Tags_Delgs_TagssAsync(arrTagsId) {
        const strThisFuncName = "Delgs_TagssAsync";
        const strAction = "Delgs_Tagss";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTagsId);
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnInt;
            }
            else {
                console.error(data.errorMsg);
                throw data.errorMsg;
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_Delgs_TagssAsync = gs_Tags_Delgs_TagssAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_Tags_Delgs_TagssByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_TagssByCondAsync";
        const strAction = "Delgs_TagssByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_Delgs_TagssByCondAsync = gs_Tags_Delgs_TagssByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_TagsEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_Tags_AddNewRecordAsync(objgs_TagsEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_TagsEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TagsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_AddNewRecordAsync = gs_Tags_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_TagsEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_Tags_AddNewRecordWithMaxIdAsync(objgs_TagsEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TagsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_AddNewRecordWithMaxIdAsync = gs_Tags_AddNewRecordWithMaxIdAsync;
    /**
    * 把所给的关键字列表相关的记录移顶
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
    * @param objgs_TagsEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_Tags_GoTopAsync(objOrderByData) {
        const strThisFuncName = "GoTopAsync";
        let strMsg = "";
        const strAction = "GoTop";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_GoTopAsync = gs_Tags_GoTopAsync;
    /**
    * 把所给的关键字列表相关的记录上移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
    * @param objgs_TagsEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_Tags_UpMoveAsync(objOrderByData) {
        const strThisFuncName = "UpMoveAsync";
        let strMsg = "";
        const strAction = "UpMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objgs_TagsEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_UpMoveAsync = gs_Tags_UpMoveAsync;
    /**
    * 把所给的关键字列表相关的记录下移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
    * @param objgs_TagsEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_Tags_DownMoveAsync(objOrderByData) {
        const strThisFuncName = "DownMoveAsync";
        let strMsg = "";
        const strAction = "DownMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objgs_TagsEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_DownMoveAsync = gs_Tags_DownMoveAsync;
    /**
    * 把所给的关键字列表相关的记录移底
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
    * @param objgs_TagsEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_Tags_GoBottomAsync(objOrderByData) {
        const strThisFuncName = "GoBottomAsync";
        let strMsg = "";
        const strAction = "GoBottom";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objgs_TagsEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_GoBottomAsync = gs_Tags_GoBottomAsync;
    /**
    * 把列表记录重序
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
    * @param objgs_TagsEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_Tags_ReOrderAsync(objOrderByData) {
        const strThisFuncName = "ReOrderAsync";
        const strAction = "ReOrder";
        //var strJSON = JSON.stringify(objgs_TagsEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_ReOrderAsync = gs_Tags_ReOrderAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_TagsEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_Tags_AddNewRecordWithReturnKeyAsync(objgs_TagsEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TagsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_AddNewRecordWithReturnKeyAsync = gs_Tags_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_TagsEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_Tags_AddNewRecordWithReturnKey(objgs_TagsEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_TagsEN.tagsId === null || objgs_TagsEN.tagsId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TagsEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_AddNewRecordWithReturnKey = gs_Tags_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_TagsEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_Tags_UpdateRecordAsync(objgs_TagsEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_TagsEN.sf_UpdFldSetStr === undefined || objgs_TagsEN.sf_UpdFldSetStr === null || objgs_TagsEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TagsEN.tagsId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TagsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_UpdateRecordAsync = gs_Tags_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_TagsEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_Tags_UpdateWithConditionAsync(objgs_TagsEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_TagsEN.sf_UpdFldSetStr === undefined || objgs_TagsEN.sf_UpdFldSetStr === null || objgs_TagsEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TagsEN.tagsId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        objgs_TagsEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_TagsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_UpdateWithConditionAsync = gs_Tags_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrTagsId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_Tags_IsExistRecord_Cache(objgs_Tags_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_Cache();
        if (arrgs_TagsObjLst_Cache == null)
            return false;
        let arrgs_Tags_Sel = arrgs_TagsObjLst_Cache;
        if (objgs_Tags_Cond.sf_FldComparisonOp == null || objgs_Tags_Cond.sf_FldComparisonOp == "")
            return arrgs_Tags_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_Tags_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TagsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_Tags_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_Tags_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_Tags_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_Tags_Cond), exports.gs_Tags_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_Tags_IsExistRecord_Cache = gs_Tags_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_Tags_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_IsExistRecordAsync = gs_Tags_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strTagsId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_Tags_IsExist(strTagsId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_IsExist = gs_Tags_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strTagsId:所给的关键字
     * @returns 对象
    */
    async function gs_Tags_IsExist_Cache(strTagsId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_Cache();
        if (arrgs_TagsObjLst_Cache == null)
            return false;
        try {
            const arrgs_Tags_Sel = arrgs_TagsObjLst_Cache.filter(x => x.tagsId == strTagsId);
            if (arrgs_Tags_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTagsId, exports.gs_Tags_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_Tags_IsExist_Cache = gs_Tags_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strTagsId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_Tags_IsExistAsync(strTagsId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_IsExistAsync = gs_Tags_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_Tags_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_GetRecCountByCondAsync = gs_Tags_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_Tags_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_Tags_GetRecCountByCond_Cache(objgs_Tags_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_Cache();
        if (arrgs_TagsObjLst_Cache == null)
            return 0;
        let arrgs_Tags_Sel = arrgs_TagsObjLst_Cache;
        if (objgs_Tags_Cond.sf_FldComparisonOp == null || objgs_Tags_Cond.sf_FldComparisonOp == "")
            return arrgs_Tags_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_Tags_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TagsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_Tags_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_Tags_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_Tags_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_Tags_Cond), exports.gs_Tags_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_Tags_GetRecCountByCond_Cache = gs_Tags_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function gs_Tags_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_GetMaxStrIdAsync = gs_Tags_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_Tags_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Tags_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strPrefix": strPrefix }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Tags_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Tags_GetMaxStrIdByPrefix = gs_Tags_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_Tags_GetWebApiUrl(strController, strAction) {
        const strThisFuncName = "GetWebApiUrl";
        let strServiceUrl;
        let strCurrIPAddressAndPort = "";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort;
        }
        else {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local;
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx) == true) {
            strServiceUrl = (0, clsString_js_2.Format)("{0}/{1}/{2}", strCurrIPAddressAndPort, strController, strAction);
        }
        else {
            strServiceUrl = (0, clsString_js_2.Format)("{0}/{1}/{2}/{3}", strCurrIPAddressAndPort, clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx, strController, strAction);
        }
        return strServiceUrl;
    }
    exports.gs_Tags_GetWebApiUrl = gs_Tags_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_Tags_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsgs_TagsEN_js_1.clsgs_TagsEN._CurrTabName;
        switch (clsgs_TagsEN_js_1.clsgs_TagsEN.CacheModeId) {
            case "04": //sessionStorage
                sessionStorage.removeItem(strKey);
                break;
            case "03": //localStorage
                localStorage.removeItem(strKey);
                break;
            case "02": //ClientCache
                CacheHelper_js_1.CacheHelper.Remove(strKey);
                break;
            default:
                CacheHelper_js_1.CacheHelper.Remove(strKey);
                break;
        }
    }
    exports.gs_Tags_ReFreshCache = gs_Tags_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_Tags_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsgs_TagsEN_js_1.clsgs_TagsEN._CurrTabName;
            switch (clsgs_TagsEN_js_1.clsgs_TagsEN.CacheModeId) {
                case "04": //sessionStorage
                    sessionStorage.removeItem(strKey);
                    break;
                case "03": //localStorage
                    localStorage.removeItem(strKey);
                    break;
                case "02": //ClientCache
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
                    break;
                default:
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
                    break;
            }
            const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
            console.trace(strMsg);
        }
        else {
            const strMsg = (0, clsString_js_2.Format)("刷新缓存已经关闭。");
            console.trace(strMsg);
        }
    }
    exports.gs_Tags_ReFreshThisCache = gs_Tags_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_Tags_CheckPropertyNew(pobjgs_TagsEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.tagsId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.tagsId) > 10) {
            throw new Error("(errid:Watl000059)字段[标注Id(tagsId)]的长度不能超过10(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.tagsId)(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfContent) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfContent)(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.userId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.userId) > 18) {
            throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过18(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.userId)(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.updUser)(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.updDate)(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfX) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.pdfX) > 50) {
            throw new Error("(errid:Watl000059)字段[PdfX(pdfX)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfX)(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfY) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.pdfY) > 50) {
            throw new Error("(errid:Watl000059)字段[PdfY(pdfY)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfY)(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.memo)(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.id_CurrEduCls)(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.paperId)(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.shareId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.shareId) > 2) {
            throw new Error("(errid:Watl000059)字段[分享Id(shareId)]的长度不能超过2(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.shareId)(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfPageNumIn) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.pdfPageNumIn) > 50) {
            throw new Error("(errid:Watl000059)字段[PdfPageNumIn(pdfPageNumIn)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfPageNumIn)(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfDivLet) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.pdfDivLet) > 50) {
            throw new Error("(errid:Watl000059)字段[PdfDivLet(pdfDivLet)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfDivLet)(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfDivTop) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.pdfDivTop) > 50) {
            throw new Error("(errid:Watl000059)字段[PdfDivTop(pdfDivTop)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfDivTop)(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfZoom) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.pdfZoom) > 50) {
            throw new Error("(errid:Watl000059)字段[PdfZoom(pdfZoom)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfZoom)(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.tagsTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.tagsTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[标注类型ID(tagsTypeId)]的长度不能超过2(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.tagsTypeId)(clsgs_TagsBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.tagsId) == false && undefined !== pobjgs_TagsEN.tagsId && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.tagsId) === false) {
            throw new Error("(errid:Watl000060)字段[标注Id(tagsId)]的值:[$(pobjgs_TagsEN.tagsId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.tagsContent) == false && undefined !== pobjgs_TagsEN.tagsContent && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.tagsContent) === false) {
            throw new Error("(errid:Watl000060)字段[标注内容(tagsContent)]的值:[$(pobjgs_TagsEN.tagsContent)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfContent) == false && undefined !== pobjgs_TagsEN.pdfContent && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.pdfContent) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjgs_TagsEN.pdfContent)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if (null != pobjgs_TagsEN.pdfPageNum && undefined !== pobjgs_TagsEN.pdfPageNum && clsString_js_1.tzDataType.isNumber(pobjgs_TagsEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjgs_TagsEN.pdfPageNum)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if (null != pobjgs_TagsEN.voteCount && undefined !== pobjgs_TagsEN.voteCount && clsString_js_1.tzDataType.isNumber(pobjgs_TagsEN.voteCount) === false) {
            throw new Error("(errid:Watl000060)字段[点赞计数(voteCount)]的值:[$(pobjgs_TagsEN.voteCount)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.userId) == false && undefined !== pobjgs_TagsEN.userId && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.userId) === false) {
            throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjgs_TagsEN.userId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if (null != pobjgs_TagsEN.orderNum && undefined !== pobjgs_TagsEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjgs_TagsEN.orderNum) === false) {
            throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjgs_TagsEN.orderNum)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.updUser) == false && undefined !== pobjgs_TagsEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TagsEN.updUser)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.updDate) == false && undefined !== pobjgs_TagsEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TagsEN.updDate)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if (null != pobjgs_TagsEN.pdfLineNum && undefined !== pobjgs_TagsEN.pdfLineNum && clsString_js_1.tzDataType.isNumber(pobjgs_TagsEN.pdfLineNum) === false) {
            throw new Error("(errid:Watl000060)字段[pdf行号(pdfLineNum)]的值:[$(pobjgs_TagsEN.pdfLineNum)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfX) == false && undefined !== pobjgs_TagsEN.pdfX && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.pdfX) === false) {
            throw new Error("(errid:Watl000060)字段[PdfX(pdfX)]的值:[$(pobjgs_TagsEN.pdfX)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfY) == false && undefined !== pobjgs_TagsEN.pdfY && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.pdfY) === false) {
            throw new Error("(errid:Watl000060)字段[PdfY(pdfY)]的值:[$(pobjgs_TagsEN.pdfY)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.memo) == false && undefined !== pobjgs_TagsEN.memo && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TagsEN.memo)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.id_CurrEduCls) == false && undefined !== pobjgs_TagsEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TagsEN.id_CurrEduCls)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.paperId) == false && undefined !== pobjgs_TagsEN.paperId && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_TagsEN.paperId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.shareId) == false && undefined !== pobjgs_TagsEN.shareId && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.shareId) === false) {
            throw new Error("(errid:Watl000060)字段[分享Id(shareId)]的值:[$(pobjgs_TagsEN.shareId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfPageNumIn) == false && undefined !== pobjgs_TagsEN.pdfPageNumIn && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.pdfPageNumIn) === false) {
            throw new Error("(errid:Watl000060)字段[PdfPageNumIn(pdfPageNumIn)]的值:[$(pobjgs_TagsEN.pdfPageNumIn)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if (null != pobjgs_TagsEN.pdfPageTop && undefined !== pobjgs_TagsEN.pdfPageTop && clsString_js_1.tzDataType.isNumber(pobjgs_TagsEN.pdfPageTop) === false) {
            throw new Error("(errid:Watl000060)字段[pdf页面顶部位置(pdfPageTop)]的值:[$(pobjgs_TagsEN.pdfPageTop)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfDivLet) == false && undefined !== pobjgs_TagsEN.pdfDivLet && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.pdfDivLet) === false) {
            throw new Error("(errid:Watl000060)字段[PdfDivLet(pdfDivLet)]的值:[$(pobjgs_TagsEN.pdfDivLet)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfDivTop) == false && undefined !== pobjgs_TagsEN.pdfDivTop && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.pdfDivTop) === false) {
            throw new Error("(errid:Watl000060)字段[PdfDivTop(pdfDivTop)]的值:[$(pobjgs_TagsEN.pdfDivTop)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfZoom) == false && undefined !== pobjgs_TagsEN.pdfZoom && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.pdfZoom) === false) {
            throw new Error("(errid:Watl000060)字段[PdfZoom(pdfZoom)]的值:[$(pobjgs_TagsEN.pdfZoom)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.tagsTypeId) == false && undefined !== pobjgs_TagsEN.tagsTypeId && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.tagsTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[标注类型ID(tagsTypeId)]的值:[$(pobjgs_TagsEN.tagsTypeId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_TagsEN.SetIsCheckProperty(true);
    }
    exports.gs_Tags_CheckPropertyNew = gs_Tags_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_Tags_CheckProperty4Update(pobjgs_TagsEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.tagsId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.tagsId) > 10) {
            throw new Error("(errid:Watl000062)字段[标注Id(tagsId)]的长度不能超过10(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.tagsId)(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfContent) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfContent)(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.userId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.userId) > 18) {
            throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过18(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.userId)(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.updUser)(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.updDate)(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfX) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.pdfX) > 50) {
            throw new Error("(errid:Watl000062)字段[PdfX(pdfX)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfX)(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfY) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.pdfY) > 50) {
            throw new Error("(errid:Watl000062)字段[PdfY(pdfY)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfY)(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.memo)(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.id_CurrEduCls)(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.paperId)(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.shareId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.shareId) > 2) {
            throw new Error("(errid:Watl000062)字段[分享Id(shareId)]的长度不能超过2(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.shareId)(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfPageNumIn) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.pdfPageNumIn) > 50) {
            throw new Error("(errid:Watl000062)字段[PdfPageNumIn(pdfPageNumIn)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfPageNumIn)(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfDivLet) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.pdfDivLet) > 50) {
            throw new Error("(errid:Watl000062)字段[PdfDivLet(pdfDivLet)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfDivLet)(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfDivTop) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.pdfDivTop) > 50) {
            throw new Error("(errid:Watl000062)字段[PdfDivTop(pdfDivTop)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfDivTop)(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfZoom) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.pdfZoom) > 50) {
            throw new Error("(errid:Watl000062)字段[PdfZoom(pdfZoom)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfZoom)(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.tagsTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TagsEN.tagsTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[标注类型ID(tagsTypeId)]的长度不能超过2(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.tagsTypeId)(clsgs_TagsBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.tagsId) == false && undefined !== pobjgs_TagsEN.tagsId && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.tagsId) === false) {
            throw new Error("(errid:Watl000063)字段[标注Id(tagsId)]的值:[$(pobjgs_TagsEN.tagsId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.tagsContent) == false && undefined !== pobjgs_TagsEN.tagsContent && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.tagsContent) === false) {
            throw new Error("(errid:Watl000063)字段[标注内容(tagsContent)]的值:[$(pobjgs_TagsEN.tagsContent)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfContent) == false && undefined !== pobjgs_TagsEN.pdfContent && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.pdfContent) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjgs_TagsEN.pdfContent)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if (null != pobjgs_TagsEN.pdfPageNum && undefined !== pobjgs_TagsEN.pdfPageNum && clsString_js_1.tzDataType.isNumber(pobjgs_TagsEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjgs_TagsEN.pdfPageNum)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if (null != pobjgs_TagsEN.voteCount && undefined !== pobjgs_TagsEN.voteCount && clsString_js_1.tzDataType.isNumber(pobjgs_TagsEN.voteCount) === false) {
            throw new Error("(errid:Watl000063)字段[点赞计数(voteCount)]的值:[$(pobjgs_TagsEN.voteCount)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.userId) == false && undefined !== pobjgs_TagsEN.userId && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.userId) === false) {
            throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjgs_TagsEN.userId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if (null != pobjgs_TagsEN.orderNum && undefined !== pobjgs_TagsEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjgs_TagsEN.orderNum) === false) {
            throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjgs_TagsEN.orderNum)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.updUser) == false && undefined !== pobjgs_TagsEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TagsEN.updUser)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.updDate) == false && undefined !== pobjgs_TagsEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TagsEN.updDate)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if (null != pobjgs_TagsEN.pdfLineNum && undefined !== pobjgs_TagsEN.pdfLineNum && clsString_js_1.tzDataType.isNumber(pobjgs_TagsEN.pdfLineNum) === false) {
            throw new Error("(errid:Watl000063)字段[pdf行号(pdfLineNum)]的值:[$(pobjgs_TagsEN.pdfLineNum)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfX) == false && undefined !== pobjgs_TagsEN.pdfX && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.pdfX) === false) {
            throw new Error("(errid:Watl000063)字段[PdfX(pdfX)]的值:[$(pobjgs_TagsEN.pdfX)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfY) == false && undefined !== pobjgs_TagsEN.pdfY && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.pdfY) === false) {
            throw new Error("(errid:Watl000063)字段[PdfY(pdfY)]的值:[$(pobjgs_TagsEN.pdfY)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.memo) == false && undefined !== pobjgs_TagsEN.memo && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TagsEN.memo)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.id_CurrEduCls) == false && undefined !== pobjgs_TagsEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TagsEN.id_CurrEduCls)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.paperId) == false && undefined !== pobjgs_TagsEN.paperId && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_TagsEN.paperId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.shareId) == false && undefined !== pobjgs_TagsEN.shareId && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.shareId) === false) {
            throw new Error("(errid:Watl000063)字段[分享Id(shareId)]的值:[$(pobjgs_TagsEN.shareId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfPageNumIn) == false && undefined !== pobjgs_TagsEN.pdfPageNumIn && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.pdfPageNumIn) === false) {
            throw new Error("(errid:Watl000063)字段[PdfPageNumIn(pdfPageNumIn)]的值:[$(pobjgs_TagsEN.pdfPageNumIn)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if (null != pobjgs_TagsEN.pdfPageTop && undefined !== pobjgs_TagsEN.pdfPageTop && clsString_js_1.tzDataType.isNumber(pobjgs_TagsEN.pdfPageTop) === false) {
            throw new Error("(errid:Watl000063)字段[pdf页面顶部位置(pdfPageTop)]的值:[$(pobjgs_TagsEN.pdfPageTop)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfDivLet) == false && undefined !== pobjgs_TagsEN.pdfDivLet && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.pdfDivLet) === false) {
            throw new Error("(errid:Watl000063)字段[PdfDivLet(pdfDivLet)]的值:[$(pobjgs_TagsEN.pdfDivLet)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfDivTop) == false && undefined !== pobjgs_TagsEN.pdfDivTop && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.pdfDivTop) === false) {
            throw new Error("(errid:Watl000063)字段[PdfDivTop(pdfDivTop)]的值:[$(pobjgs_TagsEN.pdfDivTop)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.pdfZoom) == false && undefined !== pobjgs_TagsEN.pdfZoom && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.pdfZoom) === false) {
            throw new Error("(errid:Watl000063)字段[PdfZoom(pdfZoom)]的值:[$(pobjgs_TagsEN.pdfZoom)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.tagsTypeId) == false && undefined !== pobjgs_TagsEN.tagsTypeId && clsString_js_1.tzDataType.isString(pobjgs_TagsEN.tagsTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[标注类型ID(tagsTypeId)]的值:[$(pobjgs_TagsEN.tagsTypeId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TagsEN.tagsId) === true) {
            throw new Error("(errid:Watl000064)字段[标注Id]不能为空(In 标注)!(clsgs_TagsBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_TagsEN.SetIsCheckProperty(true);
    }
    exports.gs_Tags_CheckProperty4Update = gs_Tags_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_Tags_GetJSONStrByObj(pobjgs_TagsEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_TagsEN.sf_UpdFldSetStr = pobjgs_TagsEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_TagsEN);
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
    exports.gs_Tags_GetJSONStrByObj = gs_Tags_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_Tags_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_TagsObjLst = new Array();
        if (strJSON === "") {
            return arrgs_TagsObjLst;
        }
        try {
            arrgs_TagsObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_TagsObjLst;
        }
        return arrgs_TagsObjLst;
    }
    exports.gs_Tags_GetObjLstByJSONStr = gs_Tags_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_TagsObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_Tags_GetObjLstByJSONObjLst(arrgs_TagsObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_TagsObjLst = new Array();
        for (const objInFor of arrgs_TagsObjLstS) {
            const obj1 = gs_Tags_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_TagsObjLst.push(obj1);
        }
        return arrgs_TagsObjLst;
    }
    exports.gs_Tags_GetObjLstByJSONObjLst = gs_Tags_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_Tags_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_TagsEN = new clsgs_TagsEN_js_1.clsgs_TagsEN();
        if (strJSON === "") {
            return pobjgs_TagsEN;
        }
        try {
            pobjgs_TagsEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_TagsEN;
        }
        return pobjgs_TagsEN;
    }
    exports.gs_Tags_GetObjByJSONStr = gs_Tags_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_Tags_GetCombineCondition(objgs_Tags_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsId) == true) {
            const strComparisonOp_TagsId = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsId, objgs_Tags_Cond.tagsId, strComparisonOp_TagsId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfContent];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfContent, objgs_Tags_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageNum, objgs_Tags_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_VoteCount) == true) {
            const strComparisonOp_VoteCount = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_VoteCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_TagsEN_js_1.clsgs_TagsEN.con_VoteCount, objgs_Tags_Cond.voteCount, strComparisonOp_VoteCount);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_UserId) == true) {
            const strComparisonOp_UserId = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_UserId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TagsEN_js_1.clsgs_TagsEN.con_UserId, objgs_Tags_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_OrderNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_TagsEN_js_1.clsgs_TagsEN.con_OrderNum, objgs_Tags_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TagsEN_js_1.clsgs_TagsEN.con_UpdUser, objgs_Tags_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TagsEN_js_1.clsgs_TagsEN.con_UpdDate, objgs_Tags_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfLineNum) == true) {
            const strComparisonOp_PdfLineNum = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfLineNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfLineNum, objgs_Tags_Cond.pdfLineNum, strComparisonOp_PdfLineNum);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfX) == true) {
            const strComparisonOp_PdfX = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfX];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfX, objgs_Tags_Cond.pdfX, strComparisonOp_PdfX);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfY) == true) {
            const strComparisonOp_PdfY = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfY];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfY, objgs_Tags_Cond.pdfY, strComparisonOp_PdfY);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TagsEN_js_1.clsgs_TagsEN.con_Memo, objgs_Tags_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TagsEN_js_1.clsgs_TagsEN.con_id_CurrEduCls, objgs_Tags_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_PaperId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TagsEN_js_1.clsgs_TagsEN.con_PaperId, objgs_Tags_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_ShareId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TagsEN_js_1.clsgs_TagsEN.con_ShareId, objgs_Tags_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageNumIn) == true) {
            const strComparisonOp_PdfPageNumIn = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageNumIn];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageNumIn, objgs_Tags_Cond.pdfPageNumIn, strComparisonOp_PdfPageNumIn);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageTop) == true) {
            const strComparisonOp_PdfPageTop = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageTop];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfPageTop, objgs_Tags_Cond.pdfPageTop, strComparisonOp_PdfPageTop);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfDivLet) == true) {
            const strComparisonOp_PdfDivLet = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfDivLet];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfDivLet, objgs_Tags_Cond.pdfDivLet, strComparisonOp_PdfDivLet);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfDivTop) == true) {
            const strComparisonOp_PdfDivTop = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfDivTop];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfDivTop, objgs_Tags_Cond.pdfDivTop, strComparisonOp_PdfDivTop);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfZoom) == true) {
            const strComparisonOp_PdfZoom = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfZoom];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TagsEN_js_1.clsgs_TagsEN.con_PdfZoom, objgs_Tags_Cond.pdfZoom, strComparisonOp_PdfZoom);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsTypeId) == true) {
            const strComparisonOp_TagsTypeId = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TagsEN_js_1.clsgs_TagsEN.con_TagsTypeId, objgs_Tags_Cond.tagsTypeId, strComparisonOp_TagsTypeId);
        }
        return strWhereCond;
    }
    exports.gs_Tags_GetCombineCondition = gs_Tags_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_Tags(标注),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @param strTagsId: 标注Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_Tags_GetUniCondStr_PaperId_TagsId(objgs_TagsEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PaperId = '{0}'", objgs_TagsEN.paperId);
        strWhereCond += (0, clsString_js_2.Format)(" and TagsId = '{0}'", objgs_TagsEN.tagsId);
        return strWhereCond;
    }
    exports.gs_Tags_GetUniCondStr_PaperId_TagsId = gs_Tags_GetUniCondStr_PaperId_TagsId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_Tags(标注),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @param strTagsId: 标注Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_Tags_GetUniCondStr4Update_PaperId_TagsId(objgs_TagsEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and TagsId <> '{0}'", objgs_TagsEN.tagsId);
        strWhereCond += (0, clsString_js_2.Format)(" and PaperId = '{0}'", objgs_TagsEN.paperId);
        strWhereCond += (0, clsString_js_2.Format)(" and TagsId = '{0}'", objgs_TagsEN.tagsId);
        return strWhereCond;
    }
    exports.gs_Tags_GetUniCondStr4Update_PaperId_TagsId = gs_Tags_GetUniCondStr4Update_PaperId_TagsId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_TagsENS:源对象
     * @param objgs_TagsENT:目标对象
    */
    function gs_Tags_CopyObjTo(objgs_TagsENS, objgs_TagsENT) {
        objgs_TagsENT.tagsId = objgs_TagsENS.tagsId; //标注Id
        objgs_TagsENT.tagsContent = objgs_TagsENS.tagsContent; //标注内容
        objgs_TagsENT.pdfContent = objgs_TagsENS.pdfContent; //Pdf内容
        objgs_TagsENT.pdfPageNum = objgs_TagsENS.pdfPageNum; //Pdf页码
        objgs_TagsENT.voteCount = objgs_TagsENS.voteCount; //点赞计数
        objgs_TagsENT.userId = objgs_TagsENS.userId; //用户ID
        objgs_TagsENT.orderNum = objgs_TagsENS.orderNum; //序号
        objgs_TagsENT.updUser = objgs_TagsENS.updUser; //修改人
        objgs_TagsENT.updDate = objgs_TagsENS.updDate; //修改日期
        objgs_TagsENT.pdfLineNum = objgs_TagsENS.pdfLineNum; //pdf行号
        objgs_TagsENT.pdfX = objgs_TagsENS.pdfX; //PdfX
        objgs_TagsENT.pdfY = objgs_TagsENS.pdfY; //PdfY
        objgs_TagsENT.memo = objgs_TagsENS.memo; //备注
        objgs_TagsENT.id_CurrEduCls = objgs_TagsENS.id_CurrEduCls; //教学班流水号
        objgs_TagsENT.paperId = objgs_TagsENS.paperId; //论文Id
        objgs_TagsENT.shareId = objgs_TagsENS.shareId; //分享Id
        objgs_TagsENT.pdfPageNumIn = objgs_TagsENS.pdfPageNumIn; //PdfPageNumIn
        objgs_TagsENT.pdfPageTop = objgs_TagsENS.pdfPageTop; //pdf页面顶部位置
        objgs_TagsENT.pdfDivLet = objgs_TagsENS.pdfDivLet; //PdfDivLet
        objgs_TagsENT.pdfDivTop = objgs_TagsENS.pdfDivTop; //PdfDivTop
        objgs_TagsENT.pdfZoom = objgs_TagsENS.pdfZoom; //PdfZoom
        objgs_TagsENT.tagsTypeId = objgs_TagsENS.tagsTypeId; //标注类型ID
        objgs_TagsENT.sf_UpdFldSetStr = objgs_TagsENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_Tags_CopyObjTo = gs_Tags_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_TagsENS:源对象
     * @param objgs_TagsENT:目标对象
    */
    function gs_Tags_GetObjFromJsonObj(objgs_TagsENS) {
        const objgs_TagsENT = new clsgs_TagsEN_js_1.clsgs_TagsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TagsENT, objgs_TagsENS);
        return objgs_TagsENT;
    }
    exports.gs_Tags_GetObjFromJsonObj = gs_Tags_GetObjFromJsonObj;
});
