/**
* 类名:clsvqa_PaperWApi
* 表名:vqa_Paper(01120637)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:53:32
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/InteractManage/clsvqa_PaperEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vqa_Paper_GetObjFromJsonObj = exports.vqa_Paper_CopyObjTo = exports.vqa_Paper_GetCombineCondition = exports.vqa_Paper_GetObjByJSONStr = exports.vqa_Paper_GetObjLstByJSONObjLst = exports.vqa_Paper_GetObjLstByJSONStr = exports.vqa_Paper_GetJSONStrByObj = exports.vqa_Paper_ReFreshThisCache = exports.vqa_Paper_GetWebApiUrl = exports.vqa_Paper_GetRecCountByCond_Cache = exports.vqa_Paper_GetRecCountByCondAsync = exports.vqa_Paper_IsExistAsync = exports.vqa_Paper_IsExist_Cache = exports.vqa_Paper_IsExist = exports.vqa_Paper_IsExistRecordAsync = exports.vqa_Paper_IsExistRecord_Cache = exports.vqa_Paper_GetObjLstByPagerAsync = exports.vqa_Paper_GetObjLstByPager_Cache = exports.vqa_Paper_GetObjLstByRange = exports.vqa_Paper_GetObjLstByRangeAsync = exports.vqa_Paper_GetTopObjLstAsync = exports.vqa_Paper_GetObjLstByqa_PaperIdLst_Cache = exports.vqa_Paper_GetObjLstByqa_PaperIdLstAsync = exports.vqa_Paper_GetSubObjLst_Cache = exports.vqa_Paper_GetObjLst_PureCache = exports.vqa_Paper_GetObjLst_Cache = exports.vqa_Paper_GetObjLst_sessionStorage_PureCache = exports.vqa_Paper_GetObjLst_sessionStorage = exports.vqa_Paper_GetObjLstAsync = exports.vqa_Paper_GetObjLst_localStorage_PureCache = exports.vqa_Paper_GetObjLst_localStorage = exports.vqa_Paper_GetObjLst_ClientCache = exports.vqa_Paper_GetFirstObjAsync = exports.vqa_Paper_GetFirstID = exports.vqa_Paper_GetFirstIDAsync = exports.vqa_Paper_funcKey = exports.vqa_Paper_FilterFunByKey = exports.vqa_Paper_SortFunByKey = exports.vqa_Paper_SortFun_Defa_2Fld = exports.vqa_Paper_SortFun_Defa = exports.vqa_Paper_func = exports.vqa_Paper_GetObjByqa_PaperId_localStorage = exports.vqa_Paper_GetObjByqa_PaperId_Cache = exports.vqa_Paper_GetObjByqa_PaperIdAsync = exports.vqa_Paper_ConstructorName = exports.vqa_Paper_Controller = void 0;
    /**
     * v论文答疑(vqa_Paper)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvqa_PaperEN_js_1 = require("../../L0_Entity/InteractManage/clsvqa_PaperEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vqa_Paper_Controller = "vqa_PaperApi";
    exports.vqa_Paper_ConstructorName = "vqa_Paper";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strqa_PaperId:关键字
    * @returns 对象
    **/
    async function vqa_Paper_GetObjByqa_PaperIdAsync(strqa_PaperId) {
        const strThisFuncName = "GetObjByqa_PaperIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strqa_PaperId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strqa_PaperId]不能为空！(In clsvqa_PaperWApi.GetObjByqa_PaperIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strqa_PaperId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strqa_PaperId]的长度:[{0}]不正确！(clsvqa_PaperWApi.GetObjByqa_PaperIdAsync)", strqa_PaperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByqa_PaperId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Paper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strqa_PaperId": strqa_PaperId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvqa_Paper = vqa_Paper_GetObjFromJsonObj(returnObj);
                return objvqa_Paper;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Paper_GetObjByqa_PaperIdAsync = vqa_Paper_GetObjByqa_PaperIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strqa_PaperId:所给的关键字
     * @returns 对象
    */
    async function vqa_Paper_GetObjByqa_PaperId_Cache(strqa_PaperId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByqa_PaperId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strqa_PaperId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strqa_PaperId]不能为空！(In clsvqa_PaperWApi.GetObjByqa_PaperId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strqa_PaperId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strqa_PaperId]的长度:[{0}]不正确！(clsvqa_PaperWApi.GetObjByqa_PaperId_Cache)", strqa_PaperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvqa_Paper_Sel = arrvqa_PaperObjLst_Cache.filter(x => x.qa_PaperId == strqa_PaperId);
            let objvqa_Paper;
            if (arrvqa_Paper_Sel.length > 0) {
                objvqa_Paper = arrvqa_Paper_Sel[0];
                return objvqa_Paper;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvqa_Paper_Const = await vqa_Paper_GetObjByqa_PaperIdAsync(strqa_PaperId);
                    if (objvqa_Paper_Const != null) {
                        vqa_Paper_ReFreshThisCache(strid_CurrEduCls);
                        return objvqa_Paper_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strqa_PaperId, exports.vqa_Paper_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vqa_Paper_GetObjByqa_PaperId_Cache = vqa_Paper_GetObjByqa_PaperId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strqa_PaperId:所给的关键字
     * @returns 对象
    */
    async function vqa_Paper_GetObjByqa_PaperId_localStorage(strqa_PaperId) {
        const strThisFuncName = "GetObjByqa_PaperId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strqa_PaperId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strqa_PaperId]不能为空！(In clsvqa_PaperWApi.GetObjByqa_PaperId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strqa_PaperId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strqa_PaperId]的长度:[{0}]不正确！(clsvqa_PaperWApi.GetObjByqa_PaperId_localStorage)", strqa_PaperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvqa_PaperEN_js_1.clsvqa_PaperEN._CurrTabName, strqa_PaperId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvqa_Paper_Cache = JSON.parse(strTempObj);
            return objvqa_Paper_Cache;
        }
        try {
            const objvqa_Paper = await vqa_Paper_GetObjByqa_PaperIdAsync(strqa_PaperId);
            if (objvqa_Paper != null) {
                localStorage.setItem(strKey, JSON.stringify(objvqa_Paper));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvqa_Paper;
            }
            return objvqa_Paper;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strqa_PaperId, exports.vqa_Paper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vqa_Paper_GetObjByqa_PaperId_localStorage = vqa_Paper_GetObjByqa_PaperId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function vqa_Paper_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvqa_PaperWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvqa_PaperWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_qa_PaperId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvqa_PaperEN_js_1.clsvqa_PaperEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvqa_PaperEN_js_1.clsvqa_PaperEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strqa_PaperId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvqa_Paper = await vqa_Paper_GetObjByqa_PaperId_Cache(strqa_PaperId, strid_CurrEduCls_C);
        if (objvqa_Paper == null)
            return "";
        if (objvqa_Paper.GetFldValue(strOutFldName) == null)
            return "";
        return objvqa_Paper.GetFldValue(strOutFldName).toString();
    }
    exports.vqa_Paper_func = vqa_Paper_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vqa_Paper_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.qa_PaperId.localeCompare(b.qa_PaperId);
    }
    exports.vqa_Paper_SortFun_Defa = vqa_Paper_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vqa_Paper_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.questionsCount - b.questionsCount;
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.vqa_Paper_SortFun_Defa_2Fld = vqa_Paper_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vqa_Paper_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_qa_PaperId:
                    return (a, b) => {
                        return a.qa_PaperId.localeCompare(b.qa_PaperId);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_QuestionsCount:
                    return (a, b) => {
                        return a.questionsCount - b.questionsCount;
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsDelete:
                    return (a, b) => {
                        if (a.isDelete == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsPublic:
                    return (a, b) => {
                        if (a.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UserName:
                    return (a, b) => {
                        if (a.userName == null)
                            return -1;
                        if (b.userName == null)
                            return 1;
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_PaperTitle:
                    return (a, b) => {
                        if (a.paperTitle == null)
                            return -1;
                        if (b.paperTitle == null)
                            return 1;
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_AttachmentCount:
                    return (a, b) => {
                        return a.attachmentCount - b.attachmentCount;
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_PaperContent:
                    return (a, b) => {
                        if (a.paperContent == null)
                            return -1;
                        if (b.paperContent == null)
                            return 1;
                        return a.paperContent.localeCompare(b.paperContent);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Periodical:
                    return (a, b) => {
                        if (a.periodical == null)
                            return -1;
                        if (b.periodical == null)
                            return 1;
                        return a.periodical.localeCompare(b.periodical);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Author:
                    return (a, b) => {
                        if (a.author == null)
                            return -1;
                        if (b.author == null)
                            return 1;
                        return a.author.localeCompare(b.author);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_ResearchQuestion:
                    return (a, b) => {
                        if (a.researchQuestion == null)
                            return -1;
                        if (b.researchQuestion == null)
                            return 1;
                        return a.researchQuestion.localeCompare(b.researchQuestion);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_LiteratureSources:
                    return (a, b) => {
                        if (a.literatureSources == null)
                            return -1;
                        if (b.literatureSources == null)
                            return 1;
                        return a.literatureSources.localeCompare(b.literatureSources);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UploadfileUrl:
                    return (a, b) => {
                        if (a.uploadfileUrl == null)
                            return -1;
                        if (b.uploadfileUrl == null)
                            return 1;
                        return a.uploadfileUrl.localeCompare(b.uploadfileUrl);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_id_XzMajor:
                    return (a, b) => {
                        if (a.id_XzMajor == null)
                            return -1;
                        if (b.id_XzMajor == null)
                            return 1;
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_MajorName:
                    return (a, b) => {
                        if (a.majorName == null)
                            return -1;
                        if (b.majorName == null)
                            return 1;
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_AnswerCount:
                    return (a, b) => {
                        return a.answerCount - b.answerCount;
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_ShareId:
                    return (a, b) => {
                        if (a.shareId == null)
                            return -1;
                        if (b.shareId == null)
                            return 1;
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_TagsCount:
                    return (a, b) => {
                        return a.tagsCount - b.tagsCount;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vqa_Paper]中不存在！(in ${exports.vqa_Paper_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_qa_PaperId:
                    return (a, b) => {
                        return b.qa_PaperId.localeCompare(a.qa_PaperId);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_QuestionsCount:
                    return (a, b) => {
                        return b.questionsCount - a.questionsCount;
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsDelete:
                    return (a, b) => {
                        if (b.isDelete == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsPublic:
                    return (a, b) => {
                        if (b.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UserName:
                    return (a, b) => {
                        if (b.userName == null)
                            return -1;
                        if (a.userName == null)
                            return 1;
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_PaperTitle:
                    return (a, b) => {
                        if (b.paperTitle == null)
                            return -1;
                        if (a.paperTitle == null)
                            return 1;
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_AttachmentCount:
                    return (a, b) => {
                        return b.attachmentCount - a.attachmentCount;
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_PaperContent:
                    return (a, b) => {
                        if (b.paperContent == null)
                            return -1;
                        if (a.paperContent == null)
                            return 1;
                        return b.paperContent.localeCompare(a.paperContent);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Periodical:
                    return (a, b) => {
                        if (b.periodical == null)
                            return -1;
                        if (a.periodical == null)
                            return 1;
                        return b.periodical.localeCompare(a.periodical);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Author:
                    return (a, b) => {
                        if (b.author == null)
                            return -1;
                        if (a.author == null)
                            return 1;
                        return b.author.localeCompare(a.author);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_ResearchQuestion:
                    return (a, b) => {
                        if (b.researchQuestion == null)
                            return -1;
                        if (a.researchQuestion == null)
                            return 1;
                        return b.researchQuestion.localeCompare(a.researchQuestion);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_LiteratureSources:
                    return (a, b) => {
                        if (b.literatureSources == null)
                            return -1;
                        if (a.literatureSources == null)
                            return 1;
                        return b.literatureSources.localeCompare(a.literatureSources);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UploadfileUrl:
                    return (a, b) => {
                        if (b.uploadfileUrl == null)
                            return -1;
                        if (a.uploadfileUrl == null)
                            return 1;
                        return b.uploadfileUrl.localeCompare(a.uploadfileUrl);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_id_XzMajor:
                    return (a, b) => {
                        if (b.id_XzMajor == null)
                            return -1;
                        if (a.id_XzMajor == null)
                            return 1;
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_MajorName:
                    return (a, b) => {
                        if (b.majorName == null)
                            return -1;
                        if (a.majorName == null)
                            return 1;
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_AnswerCount:
                    return (a, b) => {
                        return b.answerCount - a.answerCount;
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_ShareId:
                    return (a, b) => {
                        if (b.shareId == null)
                            return -1;
                        if (a.shareId == null)
                            return 1;
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_TagsCount:
                    return (a, b) => {
                        return b.tagsCount - a.tagsCount;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vqa_Paper]中不存在！(in ${exports.vqa_Paper_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vqa_Paper_SortFunByKey = vqa_Paper_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vqa_Paper_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_qa_PaperId:
                return (obj) => {
                    return obj.qa_PaperId === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_QuestionsCount:
                return (obj) => {
                    return obj.questionsCount === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsDelete:
                return (obj) => {
                    return obj.isDelete === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsPublic:
                return (obj) => {
                    return obj.isPublic === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_AttachmentCount:
                return (obj) => {
                    return obj.attachmentCount === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_PaperContent:
                return (obj) => {
                    return obj.paperContent === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Periodical:
                return (obj) => {
                    return obj.periodical === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_ResearchQuestion:
                return (obj) => {
                    return obj.researchQuestion === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_LiteratureSources:
                return (obj) => {
                    return obj.literatureSources === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UploadfileUrl:
                return (obj) => {
                    return obj.uploadfileUrl === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_AnswerCount:
                return (obj) => {
                    return obj.answerCount === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_TagsCount:
                return (obj) => {
                    return obj.tagsCount === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vqa_Paper]中不存在！(in ${exports.vqa_Paper_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vqa_Paper_FilterFunByKey = vqa_Paper_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个关键字值列表
    */
    async function vqa_Paper_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvqa_PaperWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvqa_PaperWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_qa_PaperId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvqa_Paper = await vqa_Paper_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrvqa_Paper == null)
            return [];
        let arrvqa_Paper_Sel = arrvqa_Paper;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvqa_Paper_Sel.length == 0)
            return [];
        return arrvqa_Paper_Sel.map(x => x.qa_PaperId);
    }
    exports.vqa_Paper_funcKey = vqa_Paper_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vqa_Paper_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Paper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Paper_GetFirstIDAsync = vqa_Paper_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vqa_Paper_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Paper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Paper_GetFirstID = vqa_Paper_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vqa_Paper_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Paper_Controller, strAction);
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
                const objvqa_Paper = vqa_Paper_GetObjFromJsonObj(returnObj);
                return objvqa_Paper;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Paper_GetFirstObjAsync = vqa_Paper_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Paper_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvqa_PaperEN_js_1.clsvqa_PaperEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvqa_PaperEN_js_1.clsvqa_PaperEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvqa_PaperEN_js_1.clsvqa_PaperEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvqa_PaperEN_js_1.clsvqa_PaperEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvqa_PaperEN_js_1.clsvqa_PaperEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvqa_PaperExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvqa_PaperObjLst_T = vqa_Paper_GetObjLstByJSONObjLst(arrvqa_PaperExObjLst_Cache);
            return arrvqa_PaperObjLst_T;
        }
        try {
            const arrvqa_PaperExObjLst = await vqa_Paper_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvqa_PaperExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvqa_PaperExObjLst.length);
            console.log(strInfo);
            return arrvqa_PaperExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vqa_Paper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vqa_Paper_GetObjLst_ClientCache = vqa_Paper_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Paper_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvqa_PaperEN_js_1.clsvqa_PaperEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvqa_PaperEN_js_1.clsvqa_PaperEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvqa_PaperEN_js_1.clsvqa_PaperEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvqa_PaperEN_js_1.clsvqa_PaperEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvqa_PaperEN_js_1.clsvqa_PaperEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvqa_PaperExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvqa_PaperObjLst_T = vqa_Paper_GetObjLstByJSONObjLst(arrvqa_PaperExObjLst_Cache);
            return arrvqa_PaperObjLst_T;
        }
        try {
            const arrvqa_PaperExObjLst = await vqa_Paper_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvqa_PaperExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvqa_PaperExObjLst.length);
            console.log(strInfo);
            return arrvqa_PaperExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vqa_Paper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vqa_Paper_GetObjLst_localStorage = vqa_Paper_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Paper_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvqa_PaperEN_js_1.clsvqa_PaperEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvqa_PaperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvqa_PaperObjLst_Cache;
        }
        else
            return null;
    }
    exports.vqa_Paper_GetObjLst_localStorage_PureCache = vqa_Paper_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vqa_Paper_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Paper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Paper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Paper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Paper_GetObjLstAsync = vqa_Paper_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Paper_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvqa_PaperEN_js_1.clsvqa_PaperEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvqa_PaperEN_js_1.clsvqa_PaperEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvqa_PaperEN_js_1.clsvqa_PaperEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvqa_PaperEN_js_1.clsvqa_PaperEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvqa_PaperEN_js_1.clsvqa_PaperEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvqa_PaperExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvqa_PaperObjLst_T = vqa_Paper_GetObjLstByJSONObjLst(arrvqa_PaperExObjLst_Cache);
            return arrvqa_PaperObjLst_T;
        }
        try {
            const arrvqa_PaperExObjLst = await vqa_Paper_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvqa_PaperExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvqa_PaperExObjLst.length);
            console.log(strInfo);
            return arrvqa_PaperExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vqa_Paper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vqa_Paper_GetObjLst_sessionStorage = vqa_Paper_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Paper_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvqa_PaperEN_js_1.clsvqa_PaperEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvqa_PaperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvqa_PaperObjLst_Cache;
        }
        else
            return null;
    }
    exports.vqa_Paper_GetObjLst_sessionStorage_PureCache = vqa_Paper_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Paper_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvqa_PaperWApi.vqa_Paper_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvqa_PaperWApi.vqa_Paper_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvqa_PaperObjLst_Cache;
        switch (clsvqa_PaperEN_js_1.clsvqa_PaperEN.CacheModeId) {
            case "04": //sessionStorage
                arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvqa_PaperObjLst = vqa_Paper_GetObjLstByJSONObjLst(arrvqa_PaperObjLst_Cache);
        return arrvqa_PaperObjLst_Cache;
    }
    exports.vqa_Paper_GetObjLst_Cache = vqa_Paper_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Paper_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvqa_PaperObjLst_Cache;
        switch (clsvqa_PaperEN_js_1.clsvqa_PaperEN.CacheModeId) {
            case "04": //sessionStorage
                arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvqa_PaperObjLst_Cache = null;
                break;
            default:
                arrvqa_PaperObjLst_Cache = null;
                break;
        }
        return arrvqa_PaperObjLst_Cache;
    }
    exports.vqa_Paper_GetObjLst_PureCache = vqa_Paper_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrqa_PaperId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vqa_Paper_GetSubObjLst_Cache(objvqa_Paper_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_Cache(strid_CurrEduCls);
        let arrvqa_Paper_Sel = arrvqa_PaperObjLst_Cache;
        if (objvqa_Paper_Cond.sf_FldComparisonOp == null || objvqa_Paper_Cond.sf_FldComparisonOp == "")
            return arrvqa_Paper_Sel;
        const dicFldComparisonOp = JSON.parse(objvqa_Paper_Cond.sf_FldComparisonOp);
        //console.log("clsvqa_PaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvqa_Paper_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvqa_Paper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvqa_Paper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvqa_Paper_Cond), exports.vqa_Paper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vqa_Paper_GetSubObjLst_Cache = vqa_Paper_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrqa_PaperId:关键字列表
    * @returns 对象列表
    **/
    async function vqa_Paper_GetObjLstByqa_PaperIdLstAsync(arrqa_PaperId) {
        const strThisFuncName = "GetObjLstByqa_PaperIdLstAsync";
        const strAction = "GetObjLstByqa_PaperIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Paper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrqa_PaperId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Paper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Paper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Paper_GetObjLstByqa_PaperIdLstAsync = vqa_Paper_GetObjLstByqa_PaperIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrqa_PaperIdLst:关键字列表
     * @returns 对象列表
    */
    async function vqa_Paper_GetObjLstByqa_PaperIdLst_Cache(arrqa_PaperIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByqa_PaperIdLst_Cache";
        try {
            const arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_Cache(strid_CurrEduCls);
            const arrvqa_Paper_Sel = arrvqa_PaperObjLst_Cache.filter(x => arrqa_PaperIdLst.indexOf(x.qa_PaperId) > -1);
            return arrvqa_Paper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrqa_PaperIdLst.join(","), exports.vqa_Paper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vqa_Paper_GetObjLstByqa_PaperIdLst_Cache = vqa_Paper_GetObjLstByqa_PaperIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vqa_Paper_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Paper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Paper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Paper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Paper_GetTopObjLstAsync = vqa_Paper_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vqa_Paper_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Paper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Paper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Paper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Paper_GetObjLstByRangeAsync = vqa_Paper_GetObjLstByRangeAsync;
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
    async function vqa_Paper_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Paper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Paper_GetObjLstByRange = vqa_Paper_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vqa_Paper_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvqa_PaperObjLst_Cache.length == 0)
            return arrvqa_PaperObjLst_Cache;
        let arrvqa_Paper_Sel = arrvqa_PaperObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvqa_Paper_Cond = new clsvqa_PaperEN_js_1.clsvqa_PaperEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvqa_Paper_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvqa_PaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvqa_Paper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvqa_Paper_Sel.length == 0)
                return arrvqa_Paper_Sel;
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
                arrvqa_Paper_Sel = arrvqa_Paper_Sel.sort(vqa_Paper_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvqa_Paper_Sel = arrvqa_Paper_Sel.sort(objPagerPara.sortFun);
            }
            arrvqa_Paper_Sel = arrvqa_Paper_Sel.slice(intStart, intEnd);
            return arrvqa_Paper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vqa_Paper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vqa_Paper_GetObjLstByPager_Cache = vqa_Paper_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vqa_Paper_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Paper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Paper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Paper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Paper_GetObjLstByPagerAsync = vqa_Paper_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrqa_PaperId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vqa_Paper_IsExistRecord_Cache(objvqa_Paper_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvqa_PaperObjLst_Cache == null)
            return false;
        let arrvqa_Paper_Sel = arrvqa_PaperObjLst_Cache;
        if (objvqa_Paper_Cond.sf_FldComparisonOp == null || objvqa_Paper_Cond.sf_FldComparisonOp == "")
            return arrvqa_Paper_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvqa_Paper_Cond.sf_FldComparisonOp);
        //console.log("clsvqa_PaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvqa_Paper_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvqa_Paper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvqa_Paper_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvqa_Paper_Cond), exports.vqa_Paper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vqa_Paper_IsExistRecord_Cache = vqa_Paper_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vqa_Paper_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Paper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Paper_IsExistRecordAsync = vqa_Paper_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strqa_PaperId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vqa_Paper_IsExist(strqa_PaperId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Paper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "qa_PaperId": strqa_PaperId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Paper_IsExist = vqa_Paper_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strqa_PaperId:所给的关键字
     * @returns 对象
    */
    async function vqa_Paper_IsExist_Cache(strqa_PaperId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvqa_PaperObjLst_Cache == null)
            return false;
        try {
            const arrvqa_Paper_Sel = arrvqa_PaperObjLst_Cache.filter(x => x.qa_PaperId == strqa_PaperId);
            if (arrvqa_Paper_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strqa_PaperId, exports.vqa_Paper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vqa_Paper_IsExist_Cache = vqa_Paper_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strqa_PaperId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vqa_Paper_IsExistAsync(strqa_PaperId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Paper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strqa_PaperId": strqa_PaperId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Paper_IsExistAsync = vqa_Paper_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vqa_Paper_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Paper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Paper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Paper_GetRecCountByCondAsync = vqa_Paper_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvqa_Paper_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vqa_Paper_GetRecCountByCond_Cache(objvqa_Paper_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvqa_PaperObjLst_Cache == null)
            return 0;
        let arrvqa_Paper_Sel = arrvqa_PaperObjLst_Cache;
        if (objvqa_Paper_Cond.sf_FldComparisonOp == null || objvqa_Paper_Cond.sf_FldComparisonOp == "")
            return arrvqa_Paper_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvqa_Paper_Cond.sf_FldComparisonOp);
        //console.log("clsvqa_PaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvqa_Paper_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvqa_Paper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvqa_Paper_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvqa_Paper_Cond), exports.vqa_Paper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vqa_Paper_GetRecCountByCond_Cache = vqa_Paper_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vqa_Paper_GetWebApiUrl(strController, strAction) {
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
    exports.vqa_Paper_GetWebApiUrl = vqa_Paper_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vqa_Paper_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvqa_PaperEN_js_1.clsvqa_PaperEN._CurrTabName, strid_CurrEduCls);
            switch (clsvqa_PaperEN_js_1.clsvqa_PaperEN.CacheModeId) {
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
            const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
            console.trace(strMsg);
        }
        else {
            const strMsg = (0, clsString_js_1.Format)("刷新缓存已经关闭。");
            console.trace(strMsg);
        }
    }
    exports.vqa_Paper_ReFreshThisCache = vqa_Paper_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vqa_Paper_GetJSONStrByObj(pobjvqa_PaperEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvqa_PaperEN);
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
    exports.vqa_Paper_GetJSONStrByObj = vqa_Paper_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vqa_Paper_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvqa_PaperObjLst = new Array();
        if (strJSON === "") {
            return arrvqa_PaperObjLst;
        }
        try {
            arrvqa_PaperObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvqa_PaperObjLst;
        }
        return arrvqa_PaperObjLst;
    }
    exports.vqa_Paper_GetObjLstByJSONStr = vqa_Paper_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvqa_PaperObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vqa_Paper_GetObjLstByJSONObjLst(arrvqa_PaperObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvqa_PaperObjLst = new Array();
        for (const objInFor of arrvqa_PaperObjLstS) {
            const obj1 = vqa_Paper_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvqa_PaperObjLst.push(obj1);
        }
        return arrvqa_PaperObjLst;
    }
    exports.vqa_Paper_GetObjLstByJSONObjLst = vqa_Paper_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vqa_Paper_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvqa_PaperEN = new clsvqa_PaperEN_js_1.clsvqa_PaperEN();
        if (strJSON === "") {
            return pobjvqa_PaperEN;
        }
        try {
            pobjvqa_PaperEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvqa_PaperEN;
        }
        return pobjvqa_PaperEN;
    }
    exports.vqa_Paper_GetObjByJSONStr = vqa_Paper_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vqa_Paper_GetCombineCondition(objvqa_Paper_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_qa_PaperId) == true) {
            const strComparisonOp_qa_PaperId = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_qa_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_qa_PaperId, objvqa_Paper_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_PaperId, objvqa_Paper_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_QuestionsCount) == true) {
            const strComparisonOp_QuestionsCount = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_QuestionsCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_QuestionsCount, objvqa_Paper_Cond.questionsCount, strComparisonOp_QuestionsCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsDelete) == true) {
            if (objvqa_Paper_Cond.isDelete == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsDelete);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsDelete);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsPublic) == true) {
            if (objvqa_Paper_Cond.isPublic == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsPublic);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsPublic);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsSubmit) == true) {
            if (objvqa_Paper_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UpdUser, objvqa_Paper_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UserName, objvqa_Paper_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UpdDate, objvqa_Paper_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Memo, objvqa_Paper_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_PaperTitle, objvqa_Paper_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_AttachmentCount) == true) {
            const strComparisonOp_AttachmentCount = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_AttachmentCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_AttachmentCount, objvqa_Paper_Cond.attachmentCount, strComparisonOp_AttachmentCount);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Periodical) == true) {
            const strComparisonOp_Periodical = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Periodical];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Periodical, objvqa_Paper_Cond.periodical, strComparisonOp_Periodical);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Author) == true) {
            const strComparisonOp_Author = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Author];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_Author, objvqa_Paper_Cond.author, strComparisonOp_Author);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_ResearchQuestion) == true) {
            const strComparisonOp_ResearchQuestion = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_ResearchQuestion];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_ResearchQuestion, objvqa_Paper_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_LiteratureSources) == true) {
            const strComparisonOp_LiteratureSources = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_LiteratureSources];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_LiteratureSources, objvqa_Paper_Cond.literatureSources, strComparisonOp_LiteratureSources);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UploadfileUrl) == true) {
            const strComparisonOp_UploadfileUrl = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UploadfileUrl];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_UploadfileUrl, objvqa_Paper_Cond.uploadfileUrl, strComparisonOp_UploadfileUrl);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_id_XzMajor, objvqa_Paper_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_MajorName, objvqa_Paper_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_id_CurrEduCls, objvqa_Paper_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_AnswerCount) == true) {
            const strComparisonOp_AnswerCount = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_AnswerCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_AnswerCount, objvqa_Paper_Cond.answerCount, strComparisonOp_AnswerCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_ShareId, objvqa_Paper_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_TagsCount) == true) {
            const strComparisonOp_TagsCount = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_TagsCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_PaperEN_js_1.clsvqa_PaperEN.con_TagsCount, objvqa_Paper_Cond.tagsCount, strComparisonOp_TagsCount);
        }
        return strWhereCond;
    }
    exports.vqa_Paper_GetCombineCondition = vqa_Paper_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvqa_PaperENS:源对象
     * @param objvqa_PaperENT:目标对象
    */
    function vqa_Paper_CopyObjTo(objvqa_PaperENS, objvqa_PaperENT) {
        objvqa_PaperENT.qa_PaperId = objvqa_PaperENS.qa_PaperId; //论文答疑Id
        objvqa_PaperENT.paperId = objvqa_PaperENS.paperId; //论文Id
        objvqa_PaperENT.questionsCount = objvqa_PaperENS.questionsCount; //提问计数
        objvqa_PaperENT.isDelete = objvqa_PaperENS.isDelete; //是否删除
        objvqa_PaperENT.isPublic = objvqa_PaperENS.isPublic; //是否公开
        objvqa_PaperENT.isSubmit = objvqa_PaperENS.isSubmit; //是否提交
        objvqa_PaperENT.updUser = objvqa_PaperENS.updUser; //修改人
        objvqa_PaperENT.userName = objvqa_PaperENS.userName; //用户名
        objvqa_PaperENT.updDate = objvqa_PaperENS.updDate; //修改日期
        objvqa_PaperENT.memo = objvqa_PaperENS.memo; //备注
        objvqa_PaperENT.paperTitle = objvqa_PaperENS.paperTitle; //论文标题
        objvqa_PaperENT.attachmentCount = objvqa_PaperENS.attachmentCount; //附件计数
        objvqa_PaperENT.paperContent = objvqa_PaperENS.paperContent; //主题内容
        objvqa_PaperENT.periodical = objvqa_PaperENS.periodical; //期刊
        objvqa_PaperENT.author = objvqa_PaperENS.author; //作者
        objvqa_PaperENT.researchQuestion = objvqa_PaperENS.researchQuestion; //研究问题
        objvqa_PaperENT.literatureSources = objvqa_PaperENS.literatureSources; //文献来源
        objvqa_PaperENT.uploadfileUrl = objvqa_PaperENS.uploadfileUrl; //文件地址
        objvqa_PaperENT.id_XzMajor = objvqa_PaperENS.id_XzMajor; //专业流水号
        objvqa_PaperENT.majorName = objvqa_PaperENS.majorName; //专业名称
        objvqa_PaperENT.id_CurrEduCls = objvqa_PaperENS.id_CurrEduCls; //教学班流水号
        objvqa_PaperENT.answerCount = objvqa_PaperENS.answerCount; //回答计数
        objvqa_PaperENT.shareId = objvqa_PaperENS.shareId; //分享Id
        objvqa_PaperENT.tagsCount = objvqa_PaperENS.tagsCount; //论文标注数
    }
    exports.vqa_Paper_CopyObjTo = vqa_Paper_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvqa_PaperENS:源对象
     * @param objvqa_PaperENT:目标对象
    */
    function vqa_Paper_GetObjFromJsonObj(objvqa_PaperENS) {
        const objvqa_PaperENT = new clsvqa_PaperEN_js_1.clsvqa_PaperEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvqa_PaperENT, objvqa_PaperENS);
        return objvqa_PaperENT;
    }
    exports.vqa_Paper_GetObjFromJsonObj = vqa_Paper_GetObjFromJsonObj;
});
