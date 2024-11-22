/**
* 类名:clsvRTSysSkillWApi
* 表名:vRTSysSkill(01120656)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:54
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvRTSysSkillEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vRTSysSkill_GetObjFromJsonObj = exports.vRTSysSkill_CopyObjTo = exports.vRTSysSkill_GetUniCondStr4Update_mId = exports.vRTSysSkill_GetUniCondStr_mId = exports.vRTSysSkill_GetCombineCondition = exports.vRTSysSkill_GetObjByJSONStr = exports.vRTSysSkill_GetObjLstByJSONObjLst = exports.vRTSysSkill_GetObjLstByJSONStr = exports.vRTSysSkill_GetJSONStrByObj = exports.vRTSysSkill__Cache = exports.vRTSysSkill_ReFreshThisCache = exports.vRTSysSkill_GetWebApiUrl = exports.vRTSysSkill_GetRecCountByCond_Cache = exports.vRTSysSkill_GetRecCountByCondAsync = exports.vRTSysSkill_IsExistAsync = exports.vRTSysSkill_IsExist_Cache = exports.vRTSysSkill_IsExist = exports.vRTSysSkill_IsExistRecordAsync = exports.vRTSysSkill_IsExistRecord_Cache = exports.vRTSysSkill_ReOrderAsync = exports.vRTSysSkill_GoBottomAsync = exports.vRTSysSkill_DownMoveAsync = exports.vRTSysSkill_UpMoveAsync = exports.vRTSysSkill_GoTopAsync = exports.vRTSysSkill_GetObjLstByPagerAsync = exports.vRTSysSkill_GetObjLstByPager_Cache = exports.vRTSysSkill_GetObjLstByRange = exports.vRTSysSkill_GetObjLstByRangeAsync = exports.vRTSysSkill_GetTopObjLstAsync = exports.vRTSysSkill_GetObjLstBymIdLst_Cache = exports.vRTSysSkill_GetObjLstBymIdLstAsync = exports.vRTSysSkill_GetSubObjLst_Cache = exports.vRTSysSkill_GetObjLst_PureCache = exports.vRTSysSkill_GetObjLst_Cache = exports.vRTSysSkill_GetObjLst_sessionStorage_PureCache = exports.vRTSysSkill_GetObjLst_sessionStorage = exports.vRTSysSkill_GetObjLstAsync = exports.vRTSysSkill_GetObjLst_localStorage_PureCache = exports.vRTSysSkill_GetObjLst_localStorage = exports.vRTSysSkill_GetObjLst_ClientCache = exports.vRTSysSkill_GetFirstObjAsync = exports.vRTSysSkill_GetFirstID = exports.vRTSysSkill_GetFirstIDAsync = exports.vRTSysSkill_FilterFunByKey = exports.vRTSysSkill_SortFunByKey = exports.vRTSysSkill_SortFun_Defa_2Fld = exports.vRTSysSkill_SortFun_Defa = exports.vRTSysSkill_func = exports.vRTSysSkill_GetNameBymId_Cache = exports.vRTSysSkill_GetObjBymId_localStorage = exports.vRTSysSkill_GetObjBymId_Cache = exports.vRTSysSkill_GetObjBymIdAsync = exports.vRTSysSkill_ConstructorName = exports.vRTSysSkill_Controller = void 0;
    /**
     * vRTSysSkill(vRTSysSkill)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvRTSysSkillEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvRTSysSkillEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vRTSysSkill_Controller = "vRTSysSkillApi";
    exports.vRTSysSkill_ConstructorName = "vRTSysSkill";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vRTSysSkill_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTSysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvRTSysSkill = vRTSysSkill_GetObjFromJsonObj(returnObj);
                return objvRTSysSkill;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_GetObjBymIdAsync = vRTSysSkill_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTSysSkill_GetObjBymId_Cache(lngmId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_Cache();
        try {
            const arrvRTSysSkill_Sel = arrvRTSysSkillObjLst_Cache.filter(x => x.mId == lngmId);
            let objvRTSysSkill;
            if (arrvRTSysSkill_Sel.length > 0) {
                objvRTSysSkill = arrvRTSysSkill_Sel[0];
                return objvRTSysSkill;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvRTSysSkill = await vRTSysSkill_GetObjBymIdAsync(lngmId);
                    if (objvRTSysSkill != null) {
                        vRTSysSkill_ReFreshThisCache();
                        return objvRTSysSkill;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vRTSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vRTSysSkill_GetObjBymId_Cache = vRTSysSkill_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTSysSkill_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvRTSysSkill_Cache = JSON.parse(strTempObj);
            return objvRTSysSkill_Cache;
        }
        try {
            const objvRTSysSkill = await vRTSysSkill_GetObjBymIdAsync(lngmId);
            if (objvRTSysSkill != null) {
                localStorage.setItem(strKey, JSON.stringify(objvRTSysSkill));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvRTSysSkill;
            }
            return objvRTSysSkill;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vRTSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vRTSysSkill_GetObjBymId_localStorage = vRTSysSkill_GetObjBymId_localStorage;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTSysSkill_GetNameBymId_Cache(lngmId) {
        const strThisFuncName = "GetNameBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetNameBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_Cache();
        if (arrvRTSysSkillObjLst_Cache == null)
            return "";
        try {
            const arrvRTSysSkill_Sel = arrvRTSysSkillObjLst_Cache.filter(x => x.mId == lngmId);
            let objvRTSysSkill;
            if (arrvRTSysSkill_Sel.length > 0) {
                objvRTSysSkill = arrvRTSysSkill_Sel[0];
                return objvRTSysSkill.operationTypeId;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, lngmId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.vRTSysSkill_GetNameBymId_Cache = vRTSysSkill_GetNameBymId_Cache;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function vRTSysSkill_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objvRTSysSkill = await vRTSysSkill_GetObjBymId_Cache(lngmId);
        if (objvRTSysSkill == null)
            return "";
        return objvRTSysSkill.GetFldValue(strOutFldName).toString();
    }
    exports.vRTSysSkill_func = vRTSysSkill_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTSysSkill_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vRTSysSkill_SortFun_Defa = vRTSysSkill_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTSysSkill_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicName == b.topicName)
            return a.skillName.localeCompare(b.skillName);
        else
            return a.topicName.localeCompare(b.topicName);
    }
    exports.vRTSysSkill_SortFun_Defa_2Fld = vRTSysSkill_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTSysSkill_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicName:
                    return (a, b) => {
                        return a.topicName.localeCompare(b.topicName);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillName:
                    return (a, b) => {
                        return a.skillName.localeCompare(b.skillName);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OperationTypeId:
                    return (a, b) => {
                        return a.operationTypeId.localeCompare(b.operationTypeId);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_Process:
                    return (a, b) => {
                        return a.process.localeCompare(b.process);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_LevelId:
                    return (a, b) => {
                        return a.levelId.localeCompare(b.levelId);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_LevelName:
                    return (a, b) => {
                        return a.levelName.localeCompare(b.levelName);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillUpdUser:
                    return (a, b) => {
                        return a.skillUpdUser.localeCompare(b.skillUpdUser);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillUpdDate:
                    return (a, b) => {
                        return a.skillUpdDate.localeCompare(b.skillUpdDate);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicProposePeople:
                    return (a, b) => {
                        return a.topicProposePeople.localeCompare(b.topicProposePeople);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicContent:
                    return (a, b) => {
                        return a.topicContent.localeCompare(b.topicContent);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_PdfContent:
                    return (a, b) => {
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CitationCount:
                    return (a, b) => {
                        return a.citationCount - b.citationCount;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OperationTypeName:
                    return (a, b) => {
                        return a.operationTypeName.localeCompare(b.operationTypeName);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CitationId:
                    return (a, b) => {
                        return a.citationId.localeCompare(b.citationId);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillId:
                    return (a, b) => {
                        return a.skillId.localeCompare(b.skillId);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CreateDate:
                    return (a, b) => {
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_ClassificationId:
                    return (a, b) => {
                        return a.classificationId.localeCompare(b.classificationId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vRTSysSkill]中不存在！(in ${exports.vRTSysSkill_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicName:
                    return (a, b) => {
                        return b.topicName.localeCompare(a.topicName);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillName:
                    return (a, b) => {
                        return b.skillName.localeCompare(a.skillName);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OperationTypeId:
                    return (a, b) => {
                        return b.operationTypeId.localeCompare(a.operationTypeId);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_Process:
                    return (a, b) => {
                        return b.process.localeCompare(a.process);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_LevelId:
                    return (a, b) => {
                        return b.levelId.localeCompare(a.levelId);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_LevelName:
                    return (a, b) => {
                        return b.levelName.localeCompare(a.levelName);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillUpdUser:
                    return (a, b) => {
                        return b.skillUpdUser.localeCompare(a.skillUpdUser);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillUpdDate:
                    return (a, b) => {
                        return b.skillUpdDate.localeCompare(a.skillUpdDate);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicProposePeople:
                    return (a, b) => {
                        return b.topicProposePeople.localeCompare(a.topicProposePeople);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicContent:
                    return (a, b) => {
                        return b.topicContent.localeCompare(a.topicContent);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_PdfContent:
                    return (a, b) => {
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CitationCount:
                    return (a, b) => {
                        return b.citationCount - a.citationCount;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OperationTypeName:
                    return (a, b) => {
                        return b.operationTypeName.localeCompare(a.operationTypeName);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CitationId:
                    return (a, b) => {
                        return b.citationId.localeCompare(a.citationId);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillId:
                    return (a, b) => {
                        return b.skillId.localeCompare(a.skillId);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CreateDate:
                    return (a, b) => {
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_ClassificationId:
                    return (a, b) => {
                        return b.classificationId.localeCompare(a.classificationId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vRTSysSkill]中不存在！(in ${exports.vRTSysSkill_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vRTSysSkill_SortFunByKey = vRTSysSkill_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vRTSysSkill_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicName:
                return (obj) => {
                    return obj.topicName === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillName:
                return (obj) => {
                    return obj.skillName === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OperationTypeId:
                return (obj) => {
                    return obj.operationTypeId === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_Process:
                return (obj) => {
                    return obj.process === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_LevelId:
                return (obj) => {
                    return obj.levelId === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_LevelName:
                return (obj) => {
                    return obj.levelName === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillUpdUser:
                return (obj) => {
                    return obj.skillUpdUser === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillUpdDate:
                return (obj) => {
                    return obj.skillUpdDate === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicProposePeople:
                return (obj) => {
                    return obj.topicProposePeople === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicContent:
                return (obj) => {
                    return obj.topicContent === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CitationCount:
                return (obj) => {
                    return obj.citationCount === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OperationTypeName:
                return (obj) => {
                    return obj.operationTypeName === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CitationId:
                return (obj) => {
                    return obj.citationId === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillId:
                return (obj) => {
                    return obj.skillId === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_ClassificationId:
                return (obj) => {
                    return obj.classificationId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vRTSysSkill]中不存在！(in ${exports.vRTSysSkill_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vRTSysSkill_FilterFunByKey = vRTSysSkill_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vRTSysSkill_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_GetFirstIDAsync = vRTSysSkill_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vRTSysSkill_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_GetFirstID = vRTSysSkill_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vRTSysSkill_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTSysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvRTSysSkill = vRTSysSkill_GetObjFromJsonObj(returnObj);
                return objvRTSysSkill;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_GetFirstObjAsync = vRTSysSkill_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTSysSkill_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvRTSysSkillEN_js_1.clsvRTSysSkillEN._CurrTabName;
        clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvRTSysSkillEN_js_1.clsvRTSysSkillEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvRTSysSkillExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvRTSysSkillObjLst_T = vRTSysSkill_GetObjLstByJSONObjLst(arrvRTSysSkillExObjLst_Cache);
            return arrvRTSysSkillObjLst_T;
        }
        try {
            const arrvRTSysSkillExObjLst = await vRTSysSkill_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvRTSysSkillExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTSysSkillExObjLst.length);
            console.log(strInfo);
            return arrvRTSysSkillExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTSysSkill_GetObjLst_ClientCache = vRTSysSkill_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTSysSkill_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvRTSysSkillEN_js_1.clsvRTSysSkillEN._CurrTabName;
        clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvRTSysSkillEN_js_1.clsvRTSysSkillEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvRTSysSkillExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvRTSysSkillObjLst_T = vRTSysSkill_GetObjLstByJSONObjLst(arrvRTSysSkillExObjLst_Cache);
            return arrvRTSysSkillObjLst_T;
        }
        try {
            const arrvRTSysSkillExObjLst = await vRTSysSkill_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvRTSysSkillExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTSysSkillExObjLst.length);
            console.log(strInfo);
            return arrvRTSysSkillExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTSysSkill_GetObjLst_localStorage = vRTSysSkill_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTSysSkill_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvRTSysSkillEN_js_1.clsvRTSysSkillEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvRTSysSkillObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvRTSysSkillObjLst_Cache;
        }
        else
            return null;
    }
    exports.vRTSysSkill_GetObjLst_localStorage_PureCache = vRTSysSkill_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vRTSysSkill_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTSysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTSysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_GetObjLstAsync = vRTSysSkill_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTSysSkill_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvRTSysSkillEN_js_1.clsvRTSysSkillEN._CurrTabName;
        clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvRTSysSkillEN_js_1.clsvRTSysSkillEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvRTSysSkillExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvRTSysSkillObjLst_T = vRTSysSkill_GetObjLstByJSONObjLst(arrvRTSysSkillExObjLst_Cache);
            return arrvRTSysSkillObjLst_T;
        }
        try {
            const arrvRTSysSkillExObjLst = await vRTSysSkill_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvRTSysSkillExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTSysSkillExObjLst.length);
            console.log(strInfo);
            return arrvRTSysSkillExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTSysSkill_GetObjLst_sessionStorage = vRTSysSkill_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTSysSkill_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvRTSysSkillEN_js_1.clsvRTSysSkillEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvRTSysSkillObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvRTSysSkillObjLst_Cache;
        }
        else
            return null;
    }
    exports.vRTSysSkill_GetObjLst_sessionStorage_PureCache = vRTSysSkill_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTSysSkill_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvRTSysSkillObjLst_Cache;
        switch (clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.CacheModeId) {
            case "04": //sessionStorage
                arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_ClientCache();
                break;
            default:
                arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_ClientCache();
                break;
        }
        const arrvRTSysSkillObjLst = vRTSysSkill_GetObjLstByJSONObjLst(arrvRTSysSkillObjLst_Cache);
        return arrvRTSysSkillObjLst_Cache;
    }
    exports.vRTSysSkill_GetObjLst_Cache = vRTSysSkill_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTSysSkill_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvRTSysSkillObjLst_Cache;
        switch (clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.CacheModeId) {
            case "04": //sessionStorage
                arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvRTSysSkillObjLst_Cache = null;
                break;
            default:
                arrvRTSysSkillObjLst_Cache = null;
                break;
        }
        return arrvRTSysSkillObjLst_Cache;
    }
    exports.vRTSysSkill_GetObjLst_PureCache = vRTSysSkill_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vRTSysSkill_GetSubObjLst_Cache(objvRTSysSkill_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_Cache();
        let arrvRTSysSkill_Sel = arrvRTSysSkillObjLst_Cache;
        if (objvRTSysSkill_Cond.sf_FldComparisonOp == null || objvRTSysSkill_Cond.sf_FldComparisonOp == "")
            return arrvRTSysSkill_Sel;
        const dicFldComparisonOp = JSON.parse(objvRTSysSkill_Cond.sf_FldComparisonOp);
        //console.log("clsvRTSysSkillWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTSysSkill_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTSysSkill_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvRTSysSkill_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvRTSysSkill_Cond), exports.vRTSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vRTSysSkill_GetSubObjLst_Cache = vRTSysSkill_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function vRTSysSkill_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTSysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTSysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_GetObjLstBymIdLstAsync = vRTSysSkill_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function vRTSysSkill_GetObjLstBymIdLst_Cache(arrmIdLst) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_Cache();
            const arrvRTSysSkill_Sel = arrvRTSysSkillObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrvRTSysSkill_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.vRTSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vRTSysSkill_GetObjLstBymIdLst_Cache = vRTSysSkill_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vRTSysSkill_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTSysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTSysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_GetTopObjLstAsync = vRTSysSkill_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vRTSysSkill_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTSysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTSysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_GetObjLstByRangeAsync = vRTSysSkill_GetObjLstByRangeAsync;
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
    async function vRTSysSkill_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_GetObjLstByRange = vRTSysSkill_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vRTSysSkill_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_Cache();
        if (arrvRTSysSkillObjLst_Cache.length == 0)
            return arrvRTSysSkillObjLst_Cache;
        let arrvRTSysSkill_Sel = arrvRTSysSkillObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvRTSysSkill_Cond = new clsvRTSysSkillEN_js_1.clsvRTSysSkillEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvRTSysSkill_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvRTSysSkillWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTSysSkill_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvRTSysSkill_Sel.length == 0)
                return arrvRTSysSkill_Sel;
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
                arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.sort(vRTSysSkill_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.sort(objPagerPara.sortFun);
            }
            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.slice(intStart, intEnd);
            return arrvRTSysSkill_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vRTSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vRTSysSkill_GetObjLstByPager_Cache = vRTSysSkill_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vRTSysSkill_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTSysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTSysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_GetObjLstByPagerAsync = vRTSysSkill_GetObjLstByPagerAsync;
    /**
    * 把所给的关键字列表相关的记录移顶
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
    * @param objvRTSysSkillEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function vRTSysSkill_GoTopAsync(objOrderByData) {
        const strThisFuncName = "GoTopAsync";
        let strMsg = "";
        const strAction = "GoTop";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_GoTopAsync = vRTSysSkill_GoTopAsync;
    /**
    * 把所给的关键字列表相关的记录上移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
    * @param objvRTSysSkillEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function vRTSysSkill_UpMoveAsync(objOrderByData) {
        const strThisFuncName = "UpMoveAsync";
        let strMsg = "";
        const strAction = "UpMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objvRTSysSkillEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_UpMoveAsync = vRTSysSkill_UpMoveAsync;
    /**
    * 把所给的关键字列表相关的记录下移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
    * @param objvRTSysSkillEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function vRTSysSkill_DownMoveAsync(objOrderByData) {
        const strThisFuncName = "DownMoveAsync";
        let strMsg = "";
        const strAction = "DownMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objvRTSysSkillEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_DownMoveAsync = vRTSysSkill_DownMoveAsync;
    /**
    * 把所给的关键字列表相关的记录移底
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
    * @param objvRTSysSkillEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function vRTSysSkill_GoBottomAsync(objOrderByData) {
        const strThisFuncName = "GoBottomAsync";
        let strMsg = "";
        const strAction = "GoBottom";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objvRTSysSkillEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_GoBottomAsync = vRTSysSkill_GoBottomAsync;
    /**
    * 把列表记录重序
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
    * @param objvRTSysSkillEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function vRTSysSkill_ReOrderAsync(objOrderByData) {
        const strThisFuncName = "ReOrderAsync";
        const strAction = "ReOrder";
        //var strJSON = JSON.stringify(objvRTSysSkillEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_ReOrderAsync = vRTSysSkill_ReOrderAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vRTSysSkill_IsExistRecord_Cache(objvRTSysSkill_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_Cache();
        if (arrvRTSysSkillObjLst_Cache == null)
            return false;
        let arrvRTSysSkill_Sel = arrvRTSysSkillObjLst_Cache;
        if (objvRTSysSkill_Cond.sf_FldComparisonOp == null || objvRTSysSkill_Cond.sf_FldComparisonOp == "")
            return arrvRTSysSkill_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvRTSysSkill_Cond.sf_FldComparisonOp);
        //console.log("clsvRTSysSkillWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTSysSkill_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTSysSkill_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvRTSysSkill_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvRTSysSkill_Cond), exports.vRTSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vRTSysSkill_IsExistRecord_Cache = vRTSysSkill_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vRTSysSkill_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_IsExistRecordAsync = vRTSysSkill_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vRTSysSkill_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_IsExist = vRTSysSkill_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTSysSkill_IsExist_Cache(lngmId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_Cache();
        if (arrvRTSysSkillObjLst_Cache == null)
            return false;
        try {
            const arrvRTSysSkill_Sel = arrvRTSysSkillObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrvRTSysSkill_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.vRTSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vRTSysSkill_IsExist_Cache = vRTSysSkill_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vRTSysSkill_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_IsExistAsync = vRTSysSkill_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vRTSysSkill_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSkill_GetRecCountByCondAsync = vRTSysSkill_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvRTSysSkill_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vRTSysSkill_GetRecCountByCond_Cache(objvRTSysSkill_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_Cache();
        if (arrvRTSysSkillObjLst_Cache == null)
            return 0;
        let arrvRTSysSkill_Sel = arrvRTSysSkillObjLst_Cache;
        if (objvRTSysSkill_Cond.sf_FldComparisonOp == null || objvRTSysSkill_Cond.sf_FldComparisonOp == "")
            return arrvRTSysSkill_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvRTSysSkill_Cond.sf_FldComparisonOp);
        //console.log("clsvRTSysSkillWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTSysSkill_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTSysSkill_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvRTSysSkill_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvRTSysSkill_Cond), exports.vRTSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vRTSysSkill_GetRecCountByCond_Cache = vRTSysSkill_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vRTSysSkill_GetWebApiUrl(strController, strAction) {
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
    exports.vRTSysSkill_GetWebApiUrl = vRTSysSkill_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vRTSysSkill_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvRTSysSkillEN_js_1.clsvRTSysSkillEN._CurrTabName;
            switch (clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.CacheModeId) {
                case "04": //sessionStorage
                    sessionStorage.removeItem(strKey);
                    break;
                case "03": //localStorage
                    localStorage.removeItem(strKey);
                    break;
                case "02": //ClientCache
                    CacheHelper_js_2.CacheHelper.Remove(strKey);
                    break;
                default:
                    CacheHelper_js_2.CacheHelper.Remove(strKey);
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
    exports.vRTSysSkill_ReFreshThisCache = vRTSysSkill_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function vRTSysSkill__Cache(strDivName, strDdlName) {
        const strThisFuncName = "_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In )", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：_Cache");
        const arrObjLst_Sel = await vRTSysSkill_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv_V)(strDivName, strDdlName, arrObjLst_Sel, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_mId, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OperationTypeId, "vRTSysSkill");
    }
    exports.vRTSysSkill__Cache = vRTSysSkill__Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vRTSysSkill_GetJSONStrByObj(pobjvRTSysSkillEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvRTSysSkillEN);
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
    exports.vRTSysSkill_GetJSONStrByObj = vRTSysSkill_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vRTSysSkill_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvRTSysSkillObjLst = new Array();
        if (strJSON === "") {
            return arrvRTSysSkillObjLst;
        }
        try {
            arrvRTSysSkillObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvRTSysSkillObjLst;
        }
        return arrvRTSysSkillObjLst;
    }
    exports.vRTSysSkill_GetObjLstByJSONStr = vRTSysSkill_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvRTSysSkillObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vRTSysSkill_GetObjLstByJSONObjLst(arrvRTSysSkillObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvRTSysSkillObjLst = new Array();
        for (const objInFor of arrvRTSysSkillObjLstS) {
            const obj1 = vRTSysSkill_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvRTSysSkillObjLst.push(obj1);
        }
        return arrvRTSysSkillObjLst;
    }
    exports.vRTSysSkill_GetObjLstByJSONObjLst = vRTSysSkill_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vRTSysSkill_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvRTSysSkillEN = new clsvRTSysSkillEN_js_1.clsvRTSysSkillEN();
        if (strJSON === "") {
            return pobjvRTSysSkillEN;
        }
        try {
            pobjvRTSysSkillEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvRTSysSkillEN;
        }
        return pobjvRTSysSkillEN;
    }
    exports.vRTSysSkill_GetObjByJSONStr = vRTSysSkill_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vRTSysSkill_GetCombineCondition(objvRTSysSkill_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicName) == true) {
            const strComparisonOp_TopicName = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicName, objvRTSysSkill_Cond.topicName, strComparisonOp_TopicName);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillName) == true) {
            const strComparisonOp_SkillName = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillName, objvRTSysSkill_Cond.skillName, strComparisonOp_SkillName);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OperationTypeId) == true) {
            const strComparisonOp_OperationTypeId = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OperationTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OperationTypeId, objvRTSysSkill_Cond.operationTypeId, strComparisonOp_OperationTypeId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_LevelId) == true) {
            const strComparisonOp_LevelId = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_LevelId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_LevelId, objvRTSysSkill_Cond.levelId, strComparisonOp_LevelId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_LevelName) == true) {
            const strComparisonOp_LevelName = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_LevelName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_LevelName, objvRTSysSkill_Cond.levelName, strComparisonOp_LevelName);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillUpdUser) == true) {
            const strComparisonOp_SkillUpdUser = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillUpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillUpdUser, objvRTSysSkill_Cond.skillUpdUser, strComparisonOp_SkillUpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillUpdDate) == true) {
            const strComparisonOp_SkillUpdDate = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillUpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillUpdDate, objvRTSysSkill_Cond.skillUpdDate, strComparisonOp_SkillUpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OrderNum, objvRTSysSkill_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_id_CurrEduCls, objvRTSysSkill_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicProposePeople) == true) {
            const strComparisonOp_TopicProposePeople = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicProposePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicProposePeople, objvRTSysSkill_Cond.topicProposePeople, strComparisonOp_TopicProposePeople);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_IsSubmit) == true) {
            if (objvRTSysSkill_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_AppraiseCount, objvRTSysSkill_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_score) == true) {
            const strComparisonOp_score = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_score, objvRTSysSkill_Cond.score, strComparisonOp_score);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_StuScore, objvRTSysSkill_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TeaScore, objvRTSysSkill_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_PdfContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_PdfContent, objvRTSysSkill_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_PdfPageNum, objvRTSysSkill_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CitationCount) == true) {
            const strComparisonOp_CitationCount = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CitationCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CitationCount, objvRTSysSkill_Cond.citationCount, strComparisonOp_CitationCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_VersionCount, objvRTSysSkill_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OperationTypeName) == true) {
            const strComparisonOp_OperationTypeName = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OperationTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OperationTypeName, objvRTSysSkill_Cond.operationTypeName, strComparisonOp_OperationTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_OkCount, objvRTSysSkill_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CitationId) == true) {
            const strComparisonOp_CitationId = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CitationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CitationId, objvRTSysSkill_Cond.citationId, strComparisonOp_CitationId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_mId) == true) {
            const strComparisonOp_mId = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_mId, objvRTSysSkill_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicId, objvRTSysSkill_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillId) == true) {
            const strComparisonOp_SkillId = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_SkillId, objvRTSysSkill_Cond.skillId, strComparisonOp_SkillId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_UpdDate, objvRTSysSkill_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_Memo, objvRTSysSkill_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_UpdUser, objvRTSysSkill_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_CreateDate, objvRTSysSkill_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_ShareId, objvRTSysSkill_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_ClassificationId) == true) {
            const strComparisonOp_ClassificationId = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_ClassificationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_ClassificationId, objvRTSysSkill_Cond.classificationId, strComparisonOp_ClassificationId);
        }
        return strWhereCond;
    }
    exports.vRTSysSkill_GetCombineCondition = vRTSysSkill_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--vRTSysSkill(vRTSysSkill),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vRTSysSkill_GetUniCondStr_mId(objvRTSysSkillEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objvRTSysSkillEN.mId);
        return strWhereCond;
    }
    exports.vRTSysSkill_GetUniCondStr_mId = vRTSysSkill_GetUniCondStr_mId;
    /**
    *获取唯一性条件串(Uniqueness)--vRTSysSkill(vRTSysSkill),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vRTSysSkill_GetUniCondStr4Update_mId(objvRTSysSkillEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objvRTSysSkillEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objvRTSysSkillEN.mId);
        return strWhereCond;
    }
    exports.vRTSysSkill_GetUniCondStr4Update_mId = vRTSysSkill_GetUniCondStr4Update_mId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvRTSysSkillENS:源对象
     * @param objvRTSysSkillENT:目标对象
    */
    function vRTSysSkill_CopyObjTo(objvRTSysSkillENS, objvRTSysSkillENT) {
        objvRTSysSkillENT.topicName = objvRTSysSkillENS.topicName; //栏目主题
        objvRTSysSkillENT.skillName = objvRTSysSkillENS.skillName; //技能名称
        objvRTSysSkillENT.operationTypeId = objvRTSysSkillENS.operationTypeId; //操作类型ID
        objvRTSysSkillENT.process = objvRTSysSkillENS.process; //实施过程
        objvRTSysSkillENT.levelId = objvRTSysSkillENS.levelId; //级别Id
        objvRTSysSkillENT.levelName = objvRTSysSkillENS.levelName; //级别名称
        objvRTSysSkillENT.skillUpdUser = objvRTSysSkillENS.skillUpdUser; //SkillUpdUser
        objvRTSysSkillENT.skillUpdDate = objvRTSysSkillENS.skillUpdDate; //SkillUpdDate
        objvRTSysSkillENT.orderNum = objvRTSysSkillENS.orderNum; //序号
        objvRTSysSkillENT.id_CurrEduCls = objvRTSysSkillENS.id_CurrEduCls; //教学班流水号
        objvRTSysSkillENT.topicProposePeople = objvRTSysSkillENS.topicProposePeople; //主题提出人
        objvRTSysSkillENT.topicContent = objvRTSysSkillENS.topicContent; //主题内容
        objvRTSysSkillENT.isSubmit = objvRTSysSkillENS.isSubmit; //是否提交
        objvRTSysSkillENT.appraiseCount = objvRTSysSkillENS.appraiseCount; //评论数
        objvRTSysSkillENT.score = objvRTSysSkillENS.score; //评分
        objvRTSysSkillENT.stuScore = objvRTSysSkillENS.stuScore; //学生平均分
        objvRTSysSkillENT.teaScore = objvRTSysSkillENS.teaScore; //教师评分
        objvRTSysSkillENT.pdfContent = objvRTSysSkillENS.pdfContent; //Pdf内容
        objvRTSysSkillENT.pdfPageNum = objvRTSysSkillENS.pdfPageNum; //Pdf页码
        objvRTSysSkillENT.citationCount = objvRTSysSkillENS.citationCount; //引用统计
        objvRTSysSkillENT.versionCount = objvRTSysSkillENS.versionCount; //版本统计
        objvRTSysSkillENT.operationTypeName = objvRTSysSkillENS.operationTypeName; //操作类型名
        objvRTSysSkillENT.okCount = objvRTSysSkillENS.okCount; //点赞统计
        objvRTSysSkillENT.citationId = objvRTSysSkillENS.citationId; //引用Id
        objvRTSysSkillENT.mId = objvRTSysSkillENS.mId; //mId
        objvRTSysSkillENT.topicId = objvRTSysSkillENS.topicId; //主题Id
        objvRTSysSkillENT.skillId = objvRTSysSkillENS.skillId; //技能Id
        objvRTSysSkillENT.updDate = objvRTSysSkillENS.updDate; //修改日期
        objvRTSysSkillENT.memo = objvRTSysSkillENS.memo; //备注
        objvRTSysSkillENT.updUser = objvRTSysSkillENS.updUser; //修改人
        objvRTSysSkillENT.createDate = objvRTSysSkillENS.createDate; //建立日期
        objvRTSysSkillENT.shareId = objvRTSysSkillENS.shareId; //分享Id
        objvRTSysSkillENT.classificationId = objvRTSysSkillENS.classificationId; //分类Id
    }
    exports.vRTSysSkill_CopyObjTo = vRTSysSkill_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvRTSysSkillENS:源对象
     * @param objvRTSysSkillENT:目标对象
    */
    function vRTSysSkill_GetObjFromJsonObj(objvRTSysSkillENS) {
        const objvRTSysSkillENT = new clsvRTSysSkillEN_js_1.clsvRTSysSkillEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvRTSysSkillENT, objvRTSysSkillENS);
        return objvRTSysSkillENT;
    }
    exports.vRTSysSkill_GetObjFromJsonObj = vRTSysSkill_GetObjFromJsonObj;
});
