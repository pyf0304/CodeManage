/**
* 类名:clsSysSkillWApi
* 表名:SysSkill(01120646)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:48:13
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsSysSkillEN.js", "../../L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysSkill_GetObjFromJsonObj = exports.SysSkill_CopyObjTo = exports.SysSkill_GetUniCondStr4Update_SkillId = exports.SysSkill_GetUniCondStr_SkillId = exports.SysSkill_GetCombineCondition = exports.SysSkill_GetObjByJSONStr = exports.SysSkill_GetObjLstByJSONObjLst = exports.SysSkill_GetObjLstByJSONStr = exports.SysSkill_GetJSONStrByObj = exports.SysSkill_CheckProperty4Update = exports.SysSkill_CheckPropertyNew = exports.SysSkill_ReFreshThisCache = exports.SysSkill_ReFreshCache = exports.SysSkill_GetWebApiUrl = exports.SysSkill_GetMaxStrIdByPrefix = exports.SysSkill_GetMaxStrIdAsync = exports.SysSkill_GetRecCountByCond_Cache = exports.SysSkill_GetRecCountByCondAsync = exports.SysSkill_IsExistAsync = exports.SysSkill_IsExist_Cache = exports.SysSkill_IsExist = exports.SysSkill_IsExistRecordAsync = exports.SysSkill_IsExistRecord_Cache = exports.SysSkill_UpdateWithConditionAsync = exports.SysSkill_UpdateRecordAsync = exports.SysSkill_AddNewRecordWithReturnKey = exports.SysSkill_AddNewRecordWithReturnKeyAsync = exports.SysSkill_AddNewRecordWithMaxIdAsync = exports.SysSkill_AddNewRecordAsync = exports.SysSkill_DelSysSkillsByCondAsync = exports.SysSkill_DelSysSkillsAsync = exports.SysSkill_DelRecordAsync = exports.SysSkill_GetObjLstByPagerAsync = exports.SysSkill_GetObjLstByPager_Cache = exports.SysSkill_GetObjLstByRange = exports.SysSkill_GetObjLstByRangeAsync = exports.SysSkill_GetTopObjLstAsync = exports.SysSkill_GetObjLstBySkillIdLst_Cache = exports.SysSkill_GetObjLstBySkillIdLstAsync = exports.SysSkill_GetSubObjLst_Cache = exports.SysSkill_GetObjLst_PureCache = exports.SysSkill_GetObjLst_Cache = exports.SysSkill_GetObjLst_sessionStorage_PureCache = exports.SysSkill_GetObjLst_sessionStorage = exports.SysSkill_GetObjLstAsync = exports.SysSkill_GetObjLst_localStorage_PureCache = exports.SysSkill_GetObjLst_localStorage = exports.SysSkill_GetObjLst_ClientCache = exports.SysSkill_GetFirstObjAsync = exports.SysSkill_GetFirstID = exports.SysSkill_GetFirstIDAsync = exports.SysSkill_funcKey = exports.SysSkill_FilterFunByKey = exports.SysSkill_SortFunByKey = exports.SysSkill_SortFun_Defa_2Fld = exports.SysSkill_SortFun_Defa = exports.SysSkill_func = exports.SysSkill_UpdateObjInLst_Cache = exports.SysSkill_GetObjBySkillId_localStorage = exports.SysSkill_GetObjBySkillId_Cache = exports.SysSkill_GetObjBySkillIdAsync = exports.sysSkill_ConstructorName = exports.sysSkill_Controller = void 0;
    /**
     * 技能表(SysSkill)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsSysSkillEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsSysSkillEN.js");
    const clsvSysSkillWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.sysSkill_Controller = "SysSkillApi";
    exports.sysSkill_ConstructorName = "sysSkill";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strSkillId:关键字
    * @returns 对象
    **/
    async function SysSkill_GetObjBySkillIdAsync(strSkillId) {
        const strThisFuncName = "GetObjBySkillIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strSkillId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strSkillId]不能为空！(In clsSysSkillWApi.GetObjBySkillIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSkillId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strSkillId]的长度:[{0}]不正确！(clsSysSkillWApi.GetObjBySkillIdAsync)", strSkillId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBySkillId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strSkillId": strSkillId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objSysSkill = SysSkill_GetObjFromJsonObj(returnObj);
                return objSysSkill;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_GetObjBySkillIdAsync = SysSkill_GetObjBySkillIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strSkillId:所给的关键字
     * @returns 对象
    */
    async function SysSkill_GetObjBySkillId_Cache(strSkillId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBySkillId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strSkillId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strSkillId]不能为空！(In clsSysSkillWApi.GetObjBySkillId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSkillId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strSkillId]的长度:[{0}]不正确！(clsSysSkillWApi.GetObjBySkillId_Cache)", strSkillId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrSysSkill_Sel = arrSysSkillObjLst_Cache.filter(x => x.skillId == strSkillId);
            let objSysSkill;
            if (arrSysSkill_Sel.length > 0) {
                objSysSkill = arrSysSkill_Sel[0];
                return objSysSkill;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objSysSkill_Const = await SysSkill_GetObjBySkillIdAsync(strSkillId);
                    if (objSysSkill_Const != null) {
                        SysSkill_ReFreshThisCache(strid_CurrEduCls);
                        return objSysSkill_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSkillId, exports.sysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.SysSkill_GetObjBySkillId_Cache = SysSkill_GetObjBySkillId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strSkillId:所给的关键字
     * @returns 对象
    */
    async function SysSkill_GetObjBySkillId_localStorage(strSkillId) {
        const strThisFuncName = "GetObjBySkillId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strSkillId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strSkillId]不能为空！(In clsSysSkillWApi.GetObjBySkillId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSkillId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strSkillId]的长度:[{0}]不正确！(clsSysSkillWApi.GetObjBySkillId_localStorage)", strSkillId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSysSkillEN_js_1.clsSysSkillEN._CurrTabName, strSkillId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objSysSkill_Cache = JSON.parse(strTempObj);
            return objSysSkill_Cache;
        }
        try {
            const objSysSkill = await SysSkill_GetObjBySkillIdAsync(strSkillId);
            if (objSysSkill != null) {
                localStorage.setItem(strKey, JSON.stringify(objSysSkill));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objSysSkill;
            }
            return objSysSkill;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSkillId, exports.sysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.SysSkill_GetObjBySkillId_localStorage = SysSkill_GetObjBySkillId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objSysSkill:所给的对象
     * @returns 对象
    */
    async function SysSkill_UpdateObjInLst_Cache(objSysSkill, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrSysSkillObjLst_Cache.find(x => x.skillId == objSysSkill.skillId);
            if (obj != null) {
                objSysSkill.skillId = obj.skillId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objSysSkill);
            }
            else {
                arrSysSkillObjLst_Cache.push(objSysSkill);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.sysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.SysSkill_UpdateObjInLst_Cache = SysSkill_UpdateObjInLst_Cache;
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
    async function SysSkill_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsSysSkillWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsSysSkillWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsSysSkillEN_js_1.clsSysSkillEN.con_SkillId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsSysSkillEN_js_1.clsSysSkillEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsSysSkillEN_js_1.clsSysSkillEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strSkillId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objSysSkill = await SysSkill_GetObjBySkillId_Cache(strSkillId, strid_CurrEduCls_C);
        if (objSysSkill == null)
            return "";
        if (objSysSkill.GetFldValue(strOutFldName) == null)
            return "";
        return objSysSkill.GetFldValue(strOutFldName).toString();
    }
    exports.SysSkill_func = SysSkill_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysSkill_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.skillId.localeCompare(b.skillId);
    }
    exports.SysSkill_SortFun_Defa = SysSkill_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysSkill_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.skillName == b.skillName)
            return a.operationTypeId.localeCompare(b.operationTypeId);
        else
            return a.skillName.localeCompare(b.skillName);
    }
    exports.SysSkill_SortFun_Defa_2Fld = SysSkill_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysSkill_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSysSkillEN_js_1.clsSysSkillEN.con_SkillId:
                    return (a, b) => {
                        return a.skillId.localeCompare(b.skillId);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_SkillName:
                    return (a, b) => {
                        if (a.skillName == null)
                            return -1;
                        if (b.skillName == null)
                            return 1;
                        return a.skillName.localeCompare(b.skillName);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_OperationTypeId:
                    return (a, b) => {
                        if (a.operationTypeId == null)
                            return -1;
                        if (b.operationTypeId == null)
                            return 1;
                        return a.operationTypeId.localeCompare(b.operationTypeId);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_Process:
                    return (a, b) => {
                        if (a.process == null)
                            return -1;
                        if (b.process == null)
                            return 1;
                        return a.process.localeCompare(b.process);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_LevelId:
                    return (a, b) => {
                        if (a.levelId == null)
                            return -1;
                        if (b.levelId == null)
                            return 1;
                        return a.levelId.localeCompare(b.levelId);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_CitationId:
                    return (a, b) => {
                        if (a.citationId == null)
                            return -1;
                        if (b.citationId == null)
                            return 1;
                        return a.citationId.localeCompare(b.citationId);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_PdfContent:
                    return (a, b) => {
                        if (a.pdfContent == null)
                            return -1;
                        if (b.pdfContent == null)
                            return 1;
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_CitationCount:
                    return (a, b) => {
                        return a.citationCount - b.citationCount;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_ShareId:
                    return (a, b) => {
                        if (a.shareId == null)
                            return -1;
                        if (b.shareId == null)
                            return 1;
                        return a.shareId.localeCompare(b.shareId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysSkill]中不存在！(in ${exports.sysSkill_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSysSkillEN_js_1.clsSysSkillEN.con_SkillId:
                    return (a, b) => {
                        return b.skillId.localeCompare(a.skillId);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_SkillName:
                    return (a, b) => {
                        if (b.skillName == null)
                            return -1;
                        if (a.skillName == null)
                            return 1;
                        return b.skillName.localeCompare(a.skillName);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_OperationTypeId:
                    return (a, b) => {
                        if (b.operationTypeId == null)
                            return -1;
                        if (a.operationTypeId == null)
                            return 1;
                        return b.operationTypeId.localeCompare(a.operationTypeId);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_Process:
                    return (a, b) => {
                        if (b.process == null)
                            return -1;
                        if (a.process == null)
                            return 1;
                        return b.process.localeCompare(a.process);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_LevelId:
                    return (a, b) => {
                        if (b.levelId == null)
                            return -1;
                        if (a.levelId == null)
                            return 1;
                        return b.levelId.localeCompare(a.levelId);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_CitationId:
                    return (a, b) => {
                        if (b.citationId == null)
                            return -1;
                        if (a.citationId == null)
                            return 1;
                        return b.citationId.localeCompare(a.citationId);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_PdfContent:
                    return (a, b) => {
                        if (b.pdfContent == null)
                            return -1;
                        if (a.pdfContent == null)
                            return 1;
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_CitationCount:
                    return (a, b) => {
                        return b.citationCount - a.citationCount;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsSysSkillEN_js_1.clsSysSkillEN.con_ShareId:
                    return (a, b) => {
                        if (b.shareId == null)
                            return -1;
                        if (a.shareId == null)
                            return 1;
                        return b.shareId.localeCompare(a.shareId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysSkill]中不存在！(in ${exports.sysSkill_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.SysSkill_SortFunByKey = SysSkill_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SysSkill_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSysSkillEN_js_1.clsSysSkillEN.con_SkillId:
                return (obj) => {
                    return obj.skillId === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_SkillName:
                return (obj) => {
                    return obj.skillName === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_OperationTypeId:
                return (obj) => {
                    return obj.operationTypeId === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_Process:
                return (obj) => {
                    return obj.process === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_LevelId:
                return (obj) => {
                    return obj.levelId === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_CitationId:
                return (obj) => {
                    return obj.citationId === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_CitationCount:
                return (obj) => {
                    return obj.citationCount === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsSysSkillEN_js_1.clsSysSkillEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[SysSkill]中不存在！(in ${exports.sysSkill_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.SysSkill_FilterFunByKey = SysSkill_FilterFunByKey;
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
    async function SysSkill_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsSysSkillWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsSysSkillWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsSysSkillEN_js_1.clsSysSkillEN.con_SkillId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrSysSkill = await SysSkill_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrSysSkill == null)
            return [];
        let arrSysSkill_Sel = arrSysSkill;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrSysSkill_Sel = arrSysSkill_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrSysSkill_Sel.length == 0)
            return [];
        return arrSysSkill_Sel.map(x => x.skillId);
    }
    exports.SysSkill_funcKey = SysSkill_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysSkill_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_GetFirstIDAsync = SysSkill_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function SysSkill_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_GetFirstID = SysSkill_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function SysSkill_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
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
                const objSysSkill = SysSkill_GetObjFromJsonObj(returnObj);
                return objSysSkill;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_GetFirstObjAsync = SysSkill_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSkill_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysSkillEN_js_1.clsSysSkillEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsSysSkillEN_js_1.clsSysSkillEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSysSkillEN_js_1.clsSysSkillEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysSkillEN_js_1.clsSysSkillEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsSysSkillEN_js_1.clsSysSkillEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrSysSkillExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrSysSkillObjLst_T = SysSkill_GetObjLstByJSONObjLst(arrSysSkillExObjLst_Cache);
            return arrSysSkillObjLst_T;
        }
        try {
            const arrSysSkillExObjLst = await SysSkill_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrSysSkillExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysSkillExObjLst.length);
            console.log(strInfo);
            return arrSysSkillExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysSkill_GetObjLst_ClientCache = SysSkill_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSkill_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysSkillEN_js_1.clsSysSkillEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsSysSkillEN_js_1.clsSysSkillEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSysSkillEN_js_1.clsSysSkillEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysSkillEN_js_1.clsSysSkillEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsSysSkillEN_js_1.clsSysSkillEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSysSkillExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSysSkillObjLst_T = SysSkill_GetObjLstByJSONObjLst(arrSysSkillExObjLst_Cache);
            return arrSysSkillObjLst_T;
        }
        try {
            const arrSysSkillExObjLst = await SysSkill_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrSysSkillExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysSkillExObjLst.length);
            console.log(strInfo);
            return arrSysSkillExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysSkill_GetObjLst_localStorage = SysSkill_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSkill_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSysSkillEN_js_1.clsSysSkillEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSysSkillObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSysSkillObjLst_Cache;
        }
        else
            return null;
    }
    exports.SysSkill_GetObjLst_localStorage_PureCache = SysSkill_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function SysSkill_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_GetObjLstAsync = SysSkill_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSkill_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysSkillEN_js_1.clsSysSkillEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsSysSkillEN_js_1.clsSysSkillEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSysSkillEN_js_1.clsSysSkillEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysSkillEN_js_1.clsSysSkillEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsSysSkillEN_js_1.clsSysSkillEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSysSkillExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSysSkillObjLst_T = SysSkill_GetObjLstByJSONObjLst(arrSysSkillExObjLst_Cache);
            return arrSysSkillObjLst_T;
        }
        try {
            const arrSysSkillExObjLst = await SysSkill_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrSysSkillExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysSkillExObjLst.length);
            console.log(strInfo);
            return arrSysSkillExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysSkill_GetObjLst_sessionStorage = SysSkill_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSkill_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSysSkillEN_js_1.clsSysSkillEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSysSkillObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSysSkillObjLst_Cache;
        }
        else
            return null;
    }
    exports.SysSkill_GetObjLst_sessionStorage_PureCache = SysSkill_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSkill_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsSysSkillWApi.SysSkill_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsSysSkillWApi.SysSkill_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrSysSkillObjLst_Cache;
        switch (clsSysSkillEN_js_1.clsSysSkillEN.CacheModeId) {
            case "04": //sessionStorage
                arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrSysSkillObjLst = SysSkill_GetObjLstByJSONObjLst(arrSysSkillObjLst_Cache);
        return arrSysSkillObjLst_Cache;
    }
    exports.SysSkill_GetObjLst_Cache = SysSkill_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSkill_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrSysSkillObjLst_Cache;
        switch (clsSysSkillEN_js_1.clsSysSkillEN.CacheModeId) {
            case "04": //sessionStorage
                arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrSysSkillObjLst_Cache = null;
                break;
            default:
                arrSysSkillObjLst_Cache = null;
                break;
        }
        return arrSysSkillObjLst_Cache;
    }
    exports.SysSkill_GetObjLst_PureCache = SysSkill_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrSkillId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function SysSkill_GetSubObjLst_Cache(objSysSkill_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_Cache(strid_CurrEduCls);
        let arrSysSkill_Sel = arrSysSkillObjLst_Cache;
        if (objSysSkill_Cond.sf_FldComparisonOp == null || objSysSkill_Cond.sf_FldComparisonOp == "")
            return arrSysSkill_Sel;
        const dicFldComparisonOp = JSON.parse(objSysSkill_Cond.sf_FldComparisonOp);
        //console.log("clsSysSkillWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysSkill_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysSkill_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSysSkill_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objSysSkill_Cond), exports.sysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysSkill_GetSubObjLst_Cache = SysSkill_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrSkillId:关键字列表
    * @returns 对象列表
    **/
    async function SysSkill_GetObjLstBySkillIdLstAsync(arrSkillId) {
        const strThisFuncName = "GetObjLstBySkillIdLstAsync";
        const strAction = "GetObjLstBySkillIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSkillId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_GetObjLstBySkillIdLstAsync = SysSkill_GetObjLstBySkillIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrSkillIdLst:关键字列表
     * @returns 对象列表
    */
    async function SysSkill_GetObjLstBySkillIdLst_Cache(arrSkillIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstBySkillIdLst_Cache";
        try {
            const arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_Cache(strid_CurrEduCls);
            const arrSysSkill_Sel = arrSysSkillObjLst_Cache.filter(x => arrSkillIdLst.indexOf(x.skillId) > -1);
            return arrSysSkill_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrSkillIdLst.join(","), exports.sysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.SysSkill_GetObjLstBySkillIdLst_Cache = SysSkill_GetObjLstBySkillIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function SysSkill_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_GetTopObjLstAsync = SysSkill_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysSkill_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_GetObjLstByRangeAsync = SysSkill_GetObjLstByRangeAsync;
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
    async function SysSkill_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_GetObjLstByRange = SysSkill_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function SysSkill_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_Cache(strid_CurrEduCls);
        if (arrSysSkillObjLst_Cache.length == 0)
            return arrSysSkillObjLst_Cache;
        let arrSysSkill_Sel = arrSysSkillObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objSysSkill_Cond = new clsSysSkillEN_js_1.clsSysSkillEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysSkill_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsSysSkillWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysSkill_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSysSkill_Sel.length == 0)
                return arrSysSkill_Sel;
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
                arrSysSkill_Sel = arrSysSkill_Sel.sort(SysSkill_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrSysSkill_Sel = arrSysSkill_Sel.sort(objPagerPara.sortFun);
            }
            arrSysSkill_Sel = arrSysSkill_Sel.slice(intStart, intEnd);
            return arrSysSkill_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysSkill_GetObjLstByPager_Cache = SysSkill_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysSkill_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_GetObjLstByPagerAsync = SysSkill_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strSkillId:关键字
    * @returns 获取删除的结果
    **/
    async function SysSkill_DelRecordAsync(strSkillId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strSkillId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_DelRecordAsync = SysSkill_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrSkillId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function SysSkill_DelSysSkillsAsync(arrSkillId) {
        const strThisFuncName = "DelSysSkillsAsync";
        const strAction = "DelSysSkills";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSkillId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_DelSysSkillsAsync = SysSkill_DelSysSkillsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function SysSkill_DelSysSkillsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSysSkillsByCondAsync";
        const strAction = "DelSysSkillsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_DelSysSkillsByCondAsync = SysSkill_DelSysSkillsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSysSkillEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysSkill_AddNewRecordAsync(objSysSkillEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objSysSkillEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSkillEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_AddNewRecordAsync = SysSkill_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objSysSkillEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysSkill_AddNewRecordWithMaxIdAsync(objSysSkillEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSkillEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_AddNewRecordWithMaxIdAsync = SysSkill_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSysSkillEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function SysSkill_AddNewRecordWithReturnKeyAsync(objSysSkillEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSkillEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_AddNewRecordWithReturnKeyAsync = SysSkill_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSysSkillEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function SysSkill_AddNewRecordWithReturnKey(objSysSkillEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSysSkillEN.skillId === null || objSysSkillEN.skillId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSkillEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_AddNewRecordWithReturnKey = SysSkill_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSysSkillEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function SysSkill_UpdateRecordAsync(objSysSkillEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSysSkillEN.sf_UpdFldSetStr === undefined || objSysSkillEN.sf_UpdFldSetStr === null || objSysSkillEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSkillEN.skillId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSkillEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_UpdateRecordAsync = SysSkill_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSysSkillEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysSkill_UpdateWithConditionAsync(objSysSkillEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSysSkillEN.sf_UpdFldSetStr === undefined || objSysSkillEN.sf_UpdFldSetStr === null || objSysSkillEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSkillEN.skillId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
        objSysSkillEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSysSkillEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_UpdateWithConditionAsync = SysSkill_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrSkillId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function SysSkill_IsExistRecord_Cache(objSysSkill_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_Cache(strid_CurrEduCls);
        if (arrSysSkillObjLst_Cache == null)
            return false;
        let arrSysSkill_Sel = arrSysSkillObjLst_Cache;
        if (objSysSkill_Cond.sf_FldComparisonOp == null || objSysSkill_Cond.sf_FldComparisonOp == "")
            return arrSysSkill_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objSysSkill_Cond.sf_FldComparisonOp);
        //console.log("clsSysSkillWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysSkill_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysSkill_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSysSkill_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objSysSkill_Cond), exports.sysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.SysSkill_IsExistRecord_Cache = SysSkill_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function SysSkill_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_IsExistRecordAsync = SysSkill_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strSkillId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function SysSkill_IsExist(strSkillId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "SkillId": strSkillId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_IsExist = SysSkill_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strSkillId:所给的关键字
     * @returns 对象
    */
    async function SysSkill_IsExist_Cache(strSkillId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_Cache(strid_CurrEduCls);
        if (arrSysSkillObjLst_Cache == null)
            return false;
        try {
            const arrSysSkill_Sel = arrSysSkillObjLst_Cache.filter(x => x.skillId == strSkillId);
            if (arrSysSkill_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strSkillId, exports.sysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.SysSkill_IsExist_Cache = SysSkill_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strSkillId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function SysSkill_IsExistAsync(strSkillId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strSkillId": strSkillId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_IsExistAsync = SysSkill_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function SysSkill_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_GetRecCountByCondAsync = SysSkill_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objSysSkill_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function SysSkill_GetRecCountByCond_Cache(objSysSkill_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_Cache(strid_CurrEduCls);
        if (arrSysSkillObjLst_Cache == null)
            return 0;
        let arrSysSkill_Sel = arrSysSkillObjLst_Cache;
        if (objSysSkill_Cond.sf_FldComparisonOp == null || objSysSkill_Cond.sf_FldComparisonOp == "")
            return arrSysSkill_Sel.length;
        const dicFldComparisonOp = JSON.parse(objSysSkill_Cond.sf_FldComparisonOp);
        //console.log("clsSysSkillWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysSkill_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysSkill_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSysSkill_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objSysSkill_Cond), exports.sysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.SysSkill_GetRecCountByCond_Cache = SysSkill_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function SysSkill_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_GetMaxStrIdAsync = SysSkill_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function SysSkill_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkill_GetMaxStrIdByPrefix = SysSkill_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function SysSkill_GetWebApiUrl(strController, strAction) {
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
    exports.SysSkill_GetWebApiUrl = SysSkill_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function SysSkill_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls]不能为空！(In clsSysSkillWApi.clsSysSkillWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsSysSkillWApi.clsSysSkillWApi.ReFreshCache)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSysSkillEN_js_1.clsSysSkillEN._CurrTabName, strid_CurrEduCls);
        switch (clsSysSkillEN_js_1.clsSysSkillEN.CacheModeId) {
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
        (0, clsvSysSkillWApi_js_1.vSysSkill_ReFreshThisCache)(strid_CurrEduCls);
    }
    exports.SysSkill_ReFreshCache = SysSkill_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function SysSkill_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSysSkillEN_js_1.clsSysSkillEN._CurrTabName, strid_CurrEduCls);
            switch (clsSysSkillEN_js_1.clsSysSkillEN.CacheModeId) {
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
    exports.SysSkill_ReFreshThisCache = SysSkill_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysSkill_CheckPropertyNew(pobjSysSkillEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.skillId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.skillId) > 10) {
            throw new Error("(errid:Watl000059)字段[技能Id(skillId)]的长度不能超过10(In 技能表(SysSkill))!值:$(pobjSysSkillEN.skillId)(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.skillName) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.skillName) > 200) {
            throw new Error("(errid:Watl000059)字段[技能名称(skillName)]的长度不能超过200(In 技能表(SysSkill))!值:$(pobjSysSkillEN.skillName)(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.operationTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.operationTypeId) > 4) {
            throw new Error("(errid:Watl000059)字段[操作类型ID(operationTypeId)]的长度不能超过4(In 技能表(SysSkill))!值:$(pobjSysSkillEN.operationTypeId)(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.levelId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.levelId) > 2) {
            throw new Error("(errid:Watl000059)字段[级别Id(levelId)]的长度不能超过2(In 技能表(SysSkill))!值:$(pobjSysSkillEN.levelId)(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 技能表(SysSkill))!值:$(pobjSysSkillEN.updUser)(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 技能表(SysSkill))!值:$(pobjSysSkillEN.updDate)(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.citationId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.citationId) > 8) {
            throw new Error("(errid:Watl000059)字段[引用Id(citationId)]的长度不能超过8(In 技能表(SysSkill))!值:$(pobjSysSkillEN.citationId)(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 技能表(SysSkill))!值:$(pobjSysSkillEN.id_CurrEduCls)(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.pdfContent) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 技能表(SysSkill))!值:$(pobjSysSkillEN.pdfContent)(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 技能表(SysSkill))!值:$(pobjSysSkillEN.memo)(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.createDate) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.createDate) > 20) {
            throw new Error("(errid:Watl000059)字段[建立日期(createDate)]的长度不能超过20(In 技能表(SysSkill))!值:$(pobjSysSkillEN.createDate)(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.shareId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.shareId) > 2) {
            throw new Error("(errid:Watl000059)字段[分享Id(shareId)]的长度不能超过2(In 技能表(SysSkill))!值:$(pobjSysSkillEN.shareId)(clsSysSkillBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.skillId) == false && undefined !== pobjSysSkillEN.skillId && clsString_js_1.tzDataType.isString(pobjSysSkillEN.skillId) === false) {
            throw new Error("(errid:Watl000060)字段[技能Id(skillId)]的值:[$(pobjSysSkillEN.skillId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.skillName) == false && undefined !== pobjSysSkillEN.skillName && clsString_js_1.tzDataType.isString(pobjSysSkillEN.skillName) === false) {
            throw new Error("(errid:Watl000060)字段[技能名称(skillName)]的值:[$(pobjSysSkillEN.skillName)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.operationTypeId) == false && undefined !== pobjSysSkillEN.operationTypeId && clsString_js_1.tzDataType.isString(pobjSysSkillEN.operationTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[操作类型ID(operationTypeId)]的值:[$(pobjSysSkillEN.operationTypeId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.process) == false && undefined !== pobjSysSkillEN.process && clsString_js_1.tzDataType.isString(pobjSysSkillEN.process) === false) {
            throw new Error("(errid:Watl000060)字段[实施过程(process)]的值:[$(pobjSysSkillEN.process)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.levelId) == false && undefined !== pobjSysSkillEN.levelId && clsString_js_1.tzDataType.isString(pobjSysSkillEN.levelId) === false) {
            throw new Error("(errid:Watl000060)字段[级别Id(levelId)]的值:[$(pobjSysSkillEN.levelId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.updUser) == false && undefined !== pobjSysSkillEN.updUser && clsString_js_1.tzDataType.isString(pobjSysSkillEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysSkillEN.updUser)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.updDate) == false && undefined !== pobjSysSkillEN.updDate && clsString_js_1.tzDataType.isString(pobjSysSkillEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysSkillEN.updDate)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if (null != pobjSysSkillEN.isSubmit && undefined !== pobjSysSkillEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjSysSkillEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjSysSkillEN.isSubmit)], 非法，应该为布尔型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.citationId) == false && undefined !== pobjSysSkillEN.citationId && clsString_js_1.tzDataType.isString(pobjSysSkillEN.citationId) === false) {
            throw new Error("(errid:Watl000060)字段[引用Id(citationId)]的值:[$(pobjSysSkillEN.citationId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if (null != pobjSysSkillEN.okCount && undefined !== pobjSysSkillEN.okCount && clsString_js_1.tzDataType.isNumber(pobjSysSkillEN.okCount) === false) {
            throw new Error("(errid:Watl000060)字段[点赞统计(okCount)]的值:[$(pobjSysSkillEN.okCount)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if (null != pobjSysSkillEN.appraiseCount && undefined !== pobjSysSkillEN.appraiseCount && clsString_js_1.tzDataType.isNumber(pobjSysSkillEN.appraiseCount) === false) {
            throw new Error("(errid:Watl000060)字段[评论数(appraiseCount)]的值:[$(pobjSysSkillEN.appraiseCount)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if (null != pobjSysSkillEN.score && undefined !== pobjSysSkillEN.score && clsString_js_1.tzDataType.isNumber(pobjSysSkillEN.score) === false) {
            throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjSysSkillEN.score)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if (null != pobjSysSkillEN.stuScore && undefined !== pobjSysSkillEN.stuScore && clsString_js_1.tzDataType.isNumber(pobjSysSkillEN.stuScore) === false) {
            throw new Error("(errid:Watl000060)字段[学生平均分(stuScore)]的值:[$(pobjSysSkillEN.stuScore)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if (null != pobjSysSkillEN.teaScore && undefined !== pobjSysSkillEN.teaScore && clsString_js_1.tzDataType.isNumber(pobjSysSkillEN.teaScore) === false) {
            throw new Error("(errid:Watl000060)字段[教师评分(teaScore)]的值:[$(pobjSysSkillEN.teaScore)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.id_CurrEduCls) == false && undefined !== pobjSysSkillEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjSysSkillEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysSkillEN.id_CurrEduCls)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.pdfContent) == false && undefined !== pobjSysSkillEN.pdfContent && clsString_js_1.tzDataType.isString(pobjSysSkillEN.pdfContent) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjSysSkillEN.pdfContent)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if (null != pobjSysSkillEN.pdfPageNum && undefined !== pobjSysSkillEN.pdfPageNum && clsString_js_1.tzDataType.isNumber(pobjSysSkillEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjSysSkillEN.pdfPageNum)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if (null != pobjSysSkillEN.citationCount && undefined !== pobjSysSkillEN.citationCount && clsString_js_1.tzDataType.isNumber(pobjSysSkillEN.citationCount) === false) {
            throw new Error("(errid:Watl000060)字段[引用统计(citationCount)]的值:[$(pobjSysSkillEN.citationCount)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if (null != pobjSysSkillEN.versionCount && undefined !== pobjSysSkillEN.versionCount && clsString_js_1.tzDataType.isNumber(pobjSysSkillEN.versionCount) === false) {
            throw new Error("(errid:Watl000060)字段[版本统计(versionCount)]的值:[$(pobjSysSkillEN.versionCount)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.memo) == false && undefined !== pobjSysSkillEN.memo && clsString_js_1.tzDataType.isString(pobjSysSkillEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysSkillEN.memo)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.createDate) == false && undefined !== pobjSysSkillEN.createDate && clsString_js_1.tzDataType.isString(pobjSysSkillEN.createDate) === false) {
            throw new Error("(errid:Watl000060)字段[建立日期(createDate)]的值:[$(pobjSysSkillEN.createDate)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.shareId) == false && undefined !== pobjSysSkillEN.shareId && clsString_js_1.tzDataType.isString(pobjSysSkillEN.shareId) === false) {
            throw new Error("(errid:Watl000060)字段[分享Id(shareId)]的值:[$(pobjSysSkillEN.shareId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSysSkillEN.SetIsCheckProperty(true);
    }
    exports.SysSkill_CheckPropertyNew = SysSkill_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysSkill_CheckProperty4Update(pobjSysSkillEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.skillId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.skillId) > 10) {
            throw new Error("(errid:Watl000062)字段[技能Id(skillId)]的长度不能超过10(In 技能表(SysSkill))!值:$(pobjSysSkillEN.skillId)(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.skillName) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.skillName) > 200) {
            throw new Error("(errid:Watl000062)字段[技能名称(skillName)]的长度不能超过200(In 技能表(SysSkill))!值:$(pobjSysSkillEN.skillName)(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.operationTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.operationTypeId) > 4) {
            throw new Error("(errid:Watl000062)字段[操作类型ID(operationTypeId)]的长度不能超过4(In 技能表(SysSkill))!值:$(pobjSysSkillEN.operationTypeId)(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.levelId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.levelId) > 2) {
            throw new Error("(errid:Watl000062)字段[级别Id(levelId)]的长度不能超过2(In 技能表(SysSkill))!值:$(pobjSysSkillEN.levelId)(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 技能表(SysSkill))!值:$(pobjSysSkillEN.updUser)(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 技能表(SysSkill))!值:$(pobjSysSkillEN.updDate)(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.citationId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.citationId) > 8) {
            throw new Error("(errid:Watl000062)字段[引用Id(citationId)]的长度不能超过8(In 技能表(SysSkill))!值:$(pobjSysSkillEN.citationId)(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 技能表(SysSkill))!值:$(pobjSysSkillEN.id_CurrEduCls)(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.pdfContent) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 技能表(SysSkill))!值:$(pobjSysSkillEN.pdfContent)(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 技能表(SysSkill))!值:$(pobjSysSkillEN.memo)(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.createDate) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.createDate) > 20) {
            throw new Error("(errid:Watl000062)字段[建立日期(createDate)]的长度不能超过20(In 技能表(SysSkill))!值:$(pobjSysSkillEN.createDate)(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.shareId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillEN.shareId) > 2) {
            throw new Error("(errid:Watl000062)字段[分享Id(shareId)]的长度不能超过2(In 技能表(SysSkill))!值:$(pobjSysSkillEN.shareId)(clsSysSkillBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.skillId) == false && undefined !== pobjSysSkillEN.skillId && clsString_js_1.tzDataType.isString(pobjSysSkillEN.skillId) === false) {
            throw new Error("(errid:Watl000063)字段[技能Id(skillId)]的值:[$(pobjSysSkillEN.skillId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.skillName) == false && undefined !== pobjSysSkillEN.skillName && clsString_js_1.tzDataType.isString(pobjSysSkillEN.skillName) === false) {
            throw new Error("(errid:Watl000063)字段[技能名称(skillName)]的值:[$(pobjSysSkillEN.skillName)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.operationTypeId) == false && undefined !== pobjSysSkillEN.operationTypeId && clsString_js_1.tzDataType.isString(pobjSysSkillEN.operationTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[操作类型ID(operationTypeId)]的值:[$(pobjSysSkillEN.operationTypeId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.process) == false && undefined !== pobjSysSkillEN.process && clsString_js_1.tzDataType.isString(pobjSysSkillEN.process) === false) {
            throw new Error("(errid:Watl000063)字段[实施过程(process)]的值:[$(pobjSysSkillEN.process)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.levelId) == false && undefined !== pobjSysSkillEN.levelId && clsString_js_1.tzDataType.isString(pobjSysSkillEN.levelId) === false) {
            throw new Error("(errid:Watl000063)字段[级别Id(levelId)]的值:[$(pobjSysSkillEN.levelId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.updUser) == false && undefined !== pobjSysSkillEN.updUser && clsString_js_1.tzDataType.isString(pobjSysSkillEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysSkillEN.updUser)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.updDate) == false && undefined !== pobjSysSkillEN.updDate && clsString_js_1.tzDataType.isString(pobjSysSkillEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysSkillEN.updDate)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if (null != pobjSysSkillEN.isSubmit && undefined !== pobjSysSkillEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjSysSkillEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjSysSkillEN.isSubmit)], 非法，应该为布尔型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.citationId) == false && undefined !== pobjSysSkillEN.citationId && clsString_js_1.tzDataType.isString(pobjSysSkillEN.citationId) === false) {
            throw new Error("(errid:Watl000063)字段[引用Id(citationId)]的值:[$(pobjSysSkillEN.citationId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if (null != pobjSysSkillEN.okCount && undefined !== pobjSysSkillEN.okCount && clsString_js_1.tzDataType.isNumber(pobjSysSkillEN.okCount) === false) {
            throw new Error("(errid:Watl000063)字段[点赞统计(okCount)]的值:[$(pobjSysSkillEN.okCount)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if (null != pobjSysSkillEN.appraiseCount && undefined !== pobjSysSkillEN.appraiseCount && clsString_js_1.tzDataType.isNumber(pobjSysSkillEN.appraiseCount) === false) {
            throw new Error("(errid:Watl000063)字段[评论数(appraiseCount)]的值:[$(pobjSysSkillEN.appraiseCount)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if (null != pobjSysSkillEN.score && undefined !== pobjSysSkillEN.score && clsString_js_1.tzDataType.isNumber(pobjSysSkillEN.score) === false) {
            throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjSysSkillEN.score)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if (null != pobjSysSkillEN.stuScore && undefined !== pobjSysSkillEN.stuScore && clsString_js_1.tzDataType.isNumber(pobjSysSkillEN.stuScore) === false) {
            throw new Error("(errid:Watl000063)字段[学生平均分(stuScore)]的值:[$(pobjSysSkillEN.stuScore)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if (null != pobjSysSkillEN.teaScore && undefined !== pobjSysSkillEN.teaScore && clsString_js_1.tzDataType.isNumber(pobjSysSkillEN.teaScore) === false) {
            throw new Error("(errid:Watl000063)字段[教师评分(teaScore)]的值:[$(pobjSysSkillEN.teaScore)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.id_CurrEduCls) == false && undefined !== pobjSysSkillEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjSysSkillEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysSkillEN.id_CurrEduCls)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.pdfContent) == false && undefined !== pobjSysSkillEN.pdfContent && clsString_js_1.tzDataType.isString(pobjSysSkillEN.pdfContent) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjSysSkillEN.pdfContent)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if (null != pobjSysSkillEN.pdfPageNum && undefined !== pobjSysSkillEN.pdfPageNum && clsString_js_1.tzDataType.isNumber(pobjSysSkillEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjSysSkillEN.pdfPageNum)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if (null != pobjSysSkillEN.citationCount && undefined !== pobjSysSkillEN.citationCount && clsString_js_1.tzDataType.isNumber(pobjSysSkillEN.citationCount) === false) {
            throw new Error("(errid:Watl000063)字段[引用统计(citationCount)]的值:[$(pobjSysSkillEN.citationCount)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if (null != pobjSysSkillEN.versionCount && undefined !== pobjSysSkillEN.versionCount && clsString_js_1.tzDataType.isNumber(pobjSysSkillEN.versionCount) === false) {
            throw new Error("(errid:Watl000063)字段[版本统计(versionCount)]的值:[$(pobjSysSkillEN.versionCount)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.memo) == false && undefined !== pobjSysSkillEN.memo && clsString_js_1.tzDataType.isString(pobjSysSkillEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysSkillEN.memo)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.createDate) == false && undefined !== pobjSysSkillEN.createDate && clsString_js_1.tzDataType.isString(pobjSysSkillEN.createDate) === false) {
            throw new Error("(errid:Watl000063)字段[建立日期(createDate)]的值:[$(pobjSysSkillEN.createDate)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.shareId) == false && undefined !== pobjSysSkillEN.shareId && clsString_js_1.tzDataType.isString(pobjSysSkillEN.shareId) === false) {
            throw new Error("(errid:Watl000063)字段[分享Id(shareId)]的值:[$(pobjSysSkillEN.shareId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillEN.skillId) === true) {
            throw new Error("(errid:Watl000064)字段[技能Id]不能为空(In 技能表)!(clsSysSkillBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSysSkillEN.SetIsCheckProperty(true);
    }
    exports.SysSkill_CheckProperty4Update = SysSkill_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysSkill_GetJSONStrByObj(pobjSysSkillEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSysSkillEN.sf_UpdFldSetStr = pobjSysSkillEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSysSkillEN);
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
    exports.SysSkill_GetJSONStrByObj = SysSkill_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function SysSkill_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSysSkillObjLst = new Array();
        if (strJSON === "") {
            return arrSysSkillObjLst;
        }
        try {
            arrSysSkillObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSysSkillObjLst;
        }
        return arrSysSkillObjLst;
    }
    exports.SysSkill_GetObjLstByJSONStr = SysSkill_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSysSkillObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function SysSkill_GetObjLstByJSONObjLst(arrSysSkillObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSysSkillObjLst = new Array();
        for (const objInFor of arrSysSkillObjLstS) {
            const obj1 = SysSkill_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSysSkillObjLst.push(obj1);
        }
        return arrSysSkillObjLst;
    }
    exports.SysSkill_GetObjLstByJSONObjLst = SysSkill_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysSkill_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSysSkillEN = new clsSysSkillEN_js_1.clsSysSkillEN();
        if (strJSON === "") {
            return pobjSysSkillEN;
        }
        try {
            pobjSysSkillEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSysSkillEN;
        }
        return pobjSysSkillEN;
    }
    exports.SysSkill_GetObjByJSONStr = SysSkill_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function SysSkill_GetCombineCondition(objSysSkill_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_SkillId) == true) {
            const strComparisonOp_SkillId = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_SkillId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillEN_js_1.clsSysSkillEN.con_SkillId, objSysSkill_Cond.skillId, strComparisonOp_SkillId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_SkillName) == true) {
            const strComparisonOp_SkillName = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_SkillName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillEN_js_1.clsSysSkillEN.con_SkillName, objSysSkill_Cond.skillName, strComparisonOp_SkillName);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_OperationTypeId) == true) {
            const strComparisonOp_OperationTypeId = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_OperationTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillEN_js_1.clsSysSkillEN.con_OperationTypeId, objSysSkill_Cond.operationTypeId, strComparisonOp_OperationTypeId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_LevelId) == true) {
            const strComparisonOp_LevelId = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_LevelId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillEN_js_1.clsSysSkillEN.con_LevelId, objSysSkill_Cond.levelId, strComparisonOp_LevelId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillEN_js_1.clsSysSkillEN.con_UpdUser, objSysSkill_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillEN_js_1.clsSysSkillEN.con_UpdDate, objSysSkill_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_IsSubmit) == true) {
            if (objSysSkill_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsSysSkillEN_js_1.clsSysSkillEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsSysSkillEN_js_1.clsSysSkillEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_CitationId) == true) {
            const strComparisonOp_CitationId = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_CitationId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillEN_js_1.clsSysSkillEN.con_CitationId, objSysSkill_Cond.citationId, strComparisonOp_CitationId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_OkCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysSkillEN_js_1.clsSysSkillEN.con_OkCount, objSysSkill_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysSkillEN_js_1.clsSysSkillEN.con_AppraiseCount, objSysSkill_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_Score) == true) {
            const strComparisonOp_Score = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_Score];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysSkillEN_js_1.clsSysSkillEN.con_Score, objSysSkill_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_StuScore];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysSkillEN_js_1.clsSysSkillEN.con_StuScore, objSysSkill_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_TeaScore];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysSkillEN_js_1.clsSysSkillEN.con_TeaScore, objSysSkill_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillEN_js_1.clsSysSkillEN.con_id_CurrEduCls, objSysSkill_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_PdfContent];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillEN_js_1.clsSysSkillEN.con_PdfContent, objSysSkill_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysSkillEN_js_1.clsSysSkillEN.con_PdfPageNum, objSysSkill_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_CitationCount) == true) {
            const strComparisonOp_CitationCount = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_CitationCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysSkillEN_js_1.clsSysSkillEN.con_CitationCount, objSysSkill_Cond.citationCount, strComparisonOp_CitationCount);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_VersionCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysSkillEN_js_1.clsSysSkillEN.con_VersionCount, objSysSkill_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_Memo) == true) {
            const strComparisonOp_Memo = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillEN_js_1.clsSysSkillEN.con_Memo, objSysSkill_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_CreateDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillEN_js_1.clsSysSkillEN.con_CreateDate, objSysSkill_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN_js_1.clsSysSkillEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN_js_1.clsSysSkillEN.con_ShareId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillEN_js_1.clsSysSkillEN.con_ShareId, objSysSkill_Cond.shareId, strComparisonOp_ShareId);
        }
        return strWhereCond;
    }
    exports.SysSkill_GetCombineCondition = SysSkill_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--SysSkill(技能表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strSkillId: 技能Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SysSkill_GetUniCondStr_SkillId(objSysSkillEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and SkillId = '{0}'", objSysSkillEN.skillId);
        return strWhereCond;
    }
    exports.SysSkill_GetUniCondStr_SkillId = SysSkill_GetUniCondStr_SkillId;
    /**
    *获取唯一性条件串(Uniqueness)--SysSkill(技能表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strSkillId: 技能Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SysSkill_GetUniCondStr4Update_SkillId(objSysSkillEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and SkillId <> '{0}'", objSysSkillEN.skillId);
        strWhereCond += (0, clsString_js_2.Format)(" and SkillId = '{0}'", objSysSkillEN.skillId);
        return strWhereCond;
    }
    exports.SysSkill_GetUniCondStr4Update_SkillId = SysSkill_GetUniCondStr4Update_SkillId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSysSkillENS:源对象
     * @param objSysSkillENT:目标对象
    */
    function SysSkill_CopyObjTo(objSysSkillENS, objSysSkillENT) {
        objSysSkillENT.skillId = objSysSkillENS.skillId; //技能Id
        objSysSkillENT.skillName = objSysSkillENS.skillName; //技能名称
        objSysSkillENT.operationTypeId = objSysSkillENS.operationTypeId; //操作类型ID
        objSysSkillENT.process = objSysSkillENS.process; //实施过程
        objSysSkillENT.levelId = objSysSkillENS.levelId; //级别Id
        objSysSkillENT.updUser = objSysSkillENS.updUser; //修改人
        objSysSkillENT.updDate = objSysSkillENS.updDate; //修改日期
        objSysSkillENT.isSubmit = objSysSkillENS.isSubmit; //是否提交
        objSysSkillENT.citationId = objSysSkillENS.citationId; //引用Id
        objSysSkillENT.okCount = objSysSkillENS.okCount; //点赞统计
        objSysSkillENT.appraiseCount = objSysSkillENS.appraiseCount; //评论数
        objSysSkillENT.score = objSysSkillENS.score; //评分
        objSysSkillENT.stuScore = objSysSkillENS.stuScore; //学生平均分
        objSysSkillENT.teaScore = objSysSkillENS.teaScore; //教师评分
        objSysSkillENT.id_CurrEduCls = objSysSkillENS.id_CurrEduCls; //教学班流水号
        objSysSkillENT.pdfContent = objSysSkillENS.pdfContent; //Pdf内容
        objSysSkillENT.pdfPageNum = objSysSkillENS.pdfPageNum; //Pdf页码
        objSysSkillENT.citationCount = objSysSkillENS.citationCount; //引用统计
        objSysSkillENT.versionCount = objSysSkillENS.versionCount; //版本统计
        objSysSkillENT.memo = objSysSkillENS.memo; //备注
        objSysSkillENT.createDate = objSysSkillENS.createDate; //建立日期
        objSysSkillENT.shareId = objSysSkillENS.shareId; //分享Id
        objSysSkillENT.sf_UpdFldSetStr = objSysSkillENS.updFldString; //sf_UpdFldSetStr
    }
    exports.SysSkill_CopyObjTo = SysSkill_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSysSkillENS:源对象
     * @param objSysSkillENT:目标对象
    */
    function SysSkill_GetObjFromJsonObj(objSysSkillENS) {
        const objSysSkillENT = new clsSysSkillEN_js_1.clsSysSkillEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysSkillENT, objSysSkillENS);
        return objSysSkillENT;
    }
    exports.SysSkill_GetObjFromJsonObj = SysSkill_GetObjFromJsonObj;
});
