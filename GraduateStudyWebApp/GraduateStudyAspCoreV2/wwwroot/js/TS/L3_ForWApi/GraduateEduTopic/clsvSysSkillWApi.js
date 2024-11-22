/**
* 类名:clsvSysSkillWApi
* 表名:vSysSkill(01120653)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:44:40
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvSysSkillEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vSysSkill_GetObjFromJsonObj = exports.vSysSkill_CopyObjTo = exports.vSysSkill_GetCombineCondition = exports.vSysSkill_GetObjByJSONStr = exports.vSysSkill_GetObjLstByJSONObjLst = exports.vSysSkill_GetObjLstByJSONStr = exports.vSysSkill_GetJSONStrByObj = exports.vSysSkill_BindDdl_SkillIdInDiv_Cache = exports.vSysSkill_ReFreshThisCache = exports.vSysSkill_GetWebApiUrl = exports.vSysSkill_GetRecCountByCond_Cache = exports.vSysSkill_GetRecCountByCondAsync = exports.vSysSkill_IsExistAsync = exports.vSysSkill_IsExist_Cache = exports.vSysSkill_IsExist = exports.vSysSkill_IsExistRecordAsync = exports.vSysSkill_IsExistRecord_Cache = exports.vSysSkill_GetObjLstByPagerAsync = exports.vSysSkill_GetObjLstByPager_Cache = exports.vSysSkill_GetObjLstByRange = exports.vSysSkill_GetObjLstByRangeAsync = exports.vSysSkill_GetTopObjLstAsync = exports.vSysSkill_GetObjLstBySkillIdLst_Cache = exports.vSysSkill_GetObjLstBySkillIdLstAsync = exports.vSysSkill_GetSubObjLst_Cache = exports.vSysSkill_GetObjLst_PureCache = exports.vSysSkill_GetObjLst_Cache = exports.vSysSkill_GetObjLst_sessionStorage_PureCache = exports.vSysSkill_GetObjLst_sessionStorage = exports.vSysSkill_GetObjLstAsync = exports.vSysSkill_GetObjLst_localStorage_PureCache = exports.vSysSkill_GetObjLst_localStorage = exports.vSysSkill_GetObjLst_ClientCache = exports.vSysSkill_GetFirstObjAsync = exports.vSysSkill_GetFirstID = exports.vSysSkill_GetFirstIDAsync = exports.vSysSkill_funcKey = exports.vSysSkill_FilterFunByKey = exports.vSysSkill_SortFunByKey = exports.vSysSkill_SortFun_Defa_2Fld = exports.vSysSkill_SortFun_Defa = exports.vSysSkill_func = exports.vSysSkill_GetNameBySkillId_Cache = exports.vSysSkill_GetObjBySkillId_localStorage = exports.vSysSkill_GetObjBySkillId_Cache = exports.vSysSkill_GetObjBySkillIdAsync = exports.vSysSkill_ConstructorName = exports.vSysSkill_Controller = void 0;
    /**
     * 技能表视图(vSysSkill)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvSysSkillEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvSysSkillEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vSysSkill_Controller = "vSysSkillApi";
    exports.vSysSkill_ConstructorName = "vSysSkill";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strSkillId:关键字
    * @returns 对象
    **/
    async function vSysSkill_GetObjBySkillIdAsync(strSkillId) {
        const strThisFuncName = "GetObjBySkillIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSkillId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSkillId]不能为空！(In clsvSysSkillWApi.GetObjBySkillIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSkillId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSkillId]的长度:[{0}]不正确！(clsvSysSkillWApi.GetObjBySkillIdAsync)", strSkillId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBySkillId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSkill_Controller, strAction);
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
                const objvSysSkill = vSysSkill_GetObjFromJsonObj(returnObj);
                return objvSysSkill;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSkill_GetObjBySkillIdAsync = vSysSkill_GetObjBySkillIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strSkillId:所给的关键字
     * @returns 对象
    */
    async function vSysSkill_GetObjBySkillId_Cache(strSkillId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBySkillId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSkillId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSkillId]不能为空！(In clsvSysSkillWApi.GetObjBySkillId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSkillId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSkillId]的长度:[{0}]不正确！(clsvSysSkillWApi.GetObjBySkillId_Cache)", strSkillId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvSysSkillObjLst_Cache = await vSysSkill_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvSysSkill_Sel = arrvSysSkillObjLst_Cache.filter(x => x.skillId == strSkillId);
            let objvSysSkill;
            if (arrvSysSkill_Sel.length > 0) {
                objvSysSkill = arrvSysSkill_Sel[0];
                return objvSysSkill;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvSysSkill_Const = await vSysSkill_GetObjBySkillIdAsync(strSkillId);
                    if (objvSysSkill_Const != null) {
                        vSysSkill_ReFreshThisCache(strid_CurrEduCls);
                        return objvSysSkill_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSkillId, exports.vSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vSysSkill_GetObjBySkillId_Cache = vSysSkill_GetObjBySkillId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strSkillId:所给的关键字
     * @returns 对象
    */
    async function vSysSkill_GetObjBySkillId_localStorage(strSkillId) {
        const strThisFuncName = "GetObjBySkillId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSkillId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSkillId]不能为空！(In clsvSysSkillWApi.GetObjBySkillId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSkillId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSkillId]的长度:[{0}]不正确！(clsvSysSkillWApi.GetObjBySkillId_localStorage)", strSkillId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysSkillEN_js_1.clsvSysSkillEN._CurrTabName, strSkillId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvSysSkill_Cache = JSON.parse(strTempObj);
            return objvSysSkill_Cache;
        }
        try {
            const objvSysSkill = await vSysSkill_GetObjBySkillIdAsync(strSkillId);
            if (objvSysSkill != null) {
                localStorage.setItem(strKey, JSON.stringify(objvSysSkill));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvSysSkill;
            }
            return objvSysSkill;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSkillId, exports.vSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vSysSkill_GetObjBySkillId_localStorage = vSysSkill_GetObjBySkillId_localStorage;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strSkillId:所给的关键字
     * @returns 对象
    */
    async function vSysSkill_GetNameBySkillId_Cache(strSkillId, strid_CurrEduCls) {
        const strThisFuncName = "GetNameBySkillId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSkillId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSkillId]不能为空！(In clsvSysSkillWApi.GetNameBySkillId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSkillId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSkillId]的长度:[{0}]不正确！(clsvSysSkillWApi.GetNameBySkillId_Cache)", strSkillId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvSysSkillObjLst_Cache = await vSysSkill_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysSkillObjLst_Cache == null)
            return "";
        try {
            const arrvSysSkill_Sel = arrvSysSkillObjLst_Cache.filter(x => x.skillId == strSkillId);
            let objvSysSkill;
            if (arrvSysSkill_Sel.length > 0) {
                objvSysSkill = arrvSysSkill_Sel[0];
                return objvSysSkill.operationTypeId;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strSkillId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.vSysSkill_GetNameBySkillId_Cache = vSysSkill_GetNameBySkillId_Cache;
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
    async function vSysSkill_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvSysSkillWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvSysSkillWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvSysSkillEN_js_1.clsvSysSkillEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvSysSkillEN_js_1.clsvSysSkillEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strSkillId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvSysSkill = await vSysSkill_GetObjBySkillId_Cache(strSkillId, strid_CurrEduCls_C);
        if (objvSysSkill == null)
            return "";
        if (objvSysSkill.GetFldValue(strOutFldName) == null)
            return "";
        return objvSysSkill.GetFldValue(strOutFldName).toString();
    }
    exports.vSysSkill_func = vSysSkill_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysSkill_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.skillId.localeCompare(b.skillId);
    }
    exports.vSysSkill_SortFun_Defa = vSysSkill_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysSkill_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.skillName == b.skillName)
            return a.operationTypeId.localeCompare(b.operationTypeId);
        else
            return a.skillName.localeCompare(b.skillName);
    }
    exports.vSysSkill_SortFun_Defa_2Fld = vSysSkill_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysSkill_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillId:
                    return (a, b) => {
                        return a.skillId.localeCompare(b.skillId);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillName:
                    return (a, b) => {
                        if (a.skillName == null)
                            return -1;
                        if (b.skillName == null)
                            return 1;
                        return a.skillName.localeCompare(b.skillName);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeId:
                    return (a, b) => {
                        if (a.operationTypeId == null)
                            return -1;
                        if (b.operationTypeId == null)
                            return 1;
                        return a.operationTypeId.localeCompare(b.operationTypeId);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_Process:
                    return (a, b) => {
                        if (a.process == null)
                            return -1;
                        if (b.process == null)
                            return 1;
                        return a.process.localeCompare(b.process);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_LevelId:
                    return (a, b) => {
                        if (a.levelId == null)
                            return -1;
                        if (b.levelId == null)
                            return 1;
                        return a.levelId.localeCompare(b.levelId);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_LevelName:
                    return (a, b) => {
                        if (a.levelName == null)
                            return -1;
                        if (b.levelName == null)
                            return 1;
                        return a.levelName.localeCompare(b.levelName);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_CitationId:
                    return (a, b) => {
                        if (a.citationId == null)
                            return -1;
                        if (b.citationId == null)
                            return 1;
                        return a.citationId.localeCompare(b.citationId);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_PdfContent:
                    return (a, b) => {
                        if (a.pdfContent == null)
                            return -1;
                        if (b.pdfContent == null)
                            return 1;
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_CitationCount:
                    return (a, b) => {
                        return a.citationCount - b.citationCount;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeName:
                    return (a, b) => {
                        if (a.operationTypeName == null)
                            return -1;
                        if (b.operationTypeName == null)
                            return 1;
                        return a.operationTypeName.localeCompare(b.operationTypeName);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vSysSkill]中不存在！(in ${exports.vSysSkill_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillId:
                    return (a, b) => {
                        return b.skillId.localeCompare(a.skillId);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillName:
                    return (a, b) => {
                        if (b.skillName == null)
                            return -1;
                        if (a.skillName == null)
                            return 1;
                        return b.skillName.localeCompare(a.skillName);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeId:
                    return (a, b) => {
                        if (b.operationTypeId == null)
                            return -1;
                        if (a.operationTypeId == null)
                            return 1;
                        return b.operationTypeId.localeCompare(a.operationTypeId);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_Process:
                    return (a, b) => {
                        if (b.process == null)
                            return -1;
                        if (a.process == null)
                            return 1;
                        return b.process.localeCompare(a.process);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_LevelId:
                    return (a, b) => {
                        if (b.levelId == null)
                            return -1;
                        if (a.levelId == null)
                            return 1;
                        return b.levelId.localeCompare(a.levelId);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_LevelName:
                    return (a, b) => {
                        if (b.levelName == null)
                            return -1;
                        if (a.levelName == null)
                            return 1;
                        return b.levelName.localeCompare(a.levelName);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_CitationId:
                    return (a, b) => {
                        if (b.citationId == null)
                            return -1;
                        if (a.citationId == null)
                            return 1;
                        return b.citationId.localeCompare(a.citationId);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_PdfContent:
                    return (a, b) => {
                        if (b.pdfContent == null)
                            return -1;
                        if (a.pdfContent == null)
                            return 1;
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_CitationCount:
                    return (a, b) => {
                        return b.citationCount - a.citationCount;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeName:
                    return (a, b) => {
                        if (b.operationTypeName == null)
                            return -1;
                        if (a.operationTypeName == null)
                            return 1;
                        return b.operationTypeName.localeCompare(a.operationTypeName);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvSysSkillEN_js_1.clsvSysSkillEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vSysSkill]中不存在！(in ${exports.vSysSkill_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vSysSkill_SortFunByKey = vSysSkill_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vSysSkill_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillId:
                return (obj) => {
                    return obj.skillId === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillName:
                return (obj) => {
                    return obj.skillName === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeId:
                return (obj) => {
                    return obj.operationTypeId === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_Process:
                return (obj) => {
                    return obj.process === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_LevelId:
                return (obj) => {
                    return obj.levelId === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_LevelName:
                return (obj) => {
                    return obj.levelName === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_CitationId:
                return (obj) => {
                    return obj.citationId === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_CitationCount:
                return (obj) => {
                    return obj.citationCount === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeName:
                return (obj) => {
                    return obj.operationTypeName === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvSysSkillEN_js_1.clsvSysSkillEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vSysSkill]中不存在！(in ${exports.vSysSkill_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vSysSkill_FilterFunByKey = vSysSkill_FilterFunByKey;
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
    async function vSysSkill_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvSysSkillWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvSysSkillWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvSysSkill = await vSysSkill_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrvSysSkill == null)
            return [];
        let arrvSysSkill_Sel = arrvSysSkill;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvSysSkill_Sel.length == 0)
            return [];
        return arrvSysSkill_Sel.map(x => x.skillId);
    }
    exports.vSysSkill_funcKey = vSysSkill_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vSysSkill_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSkill_GetFirstIDAsync = vSysSkill_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vSysSkill_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSkill_GetFirstID = vSysSkill_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vSysSkill_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSkill_Controller, strAction);
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
                const objvSysSkill = vSysSkill_GetObjFromJsonObj(returnObj);
                return objvSysSkill;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSkill_GetFirstObjAsync = vSysSkill_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysSkill_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysSkillEN_js_1.clsvSysSkillEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvSysSkillEN_js_1.clsvSysSkillEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysSkillEN_js_1.clsvSysSkillEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysSkillEN_js_1.clsvSysSkillEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvSysSkillEN_js_1.clsvSysSkillEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvSysSkillExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvSysSkillObjLst_T = vSysSkill_GetObjLstByJSONObjLst(arrvSysSkillExObjLst_Cache);
            return arrvSysSkillObjLst_T;
        }
        try {
            const arrvSysSkillExObjLst = await vSysSkill_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvSysSkillExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysSkillExObjLst.length);
            console.log(strInfo);
            return arrvSysSkillExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vSysSkill_GetObjLst_ClientCache = vSysSkill_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysSkill_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysSkillEN_js_1.clsvSysSkillEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvSysSkillEN_js_1.clsvSysSkillEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysSkillEN_js_1.clsvSysSkillEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysSkillEN_js_1.clsvSysSkillEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvSysSkillEN_js_1.clsvSysSkillEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvSysSkillExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvSysSkillObjLst_T = vSysSkill_GetObjLstByJSONObjLst(arrvSysSkillExObjLst_Cache);
            return arrvSysSkillObjLst_T;
        }
        try {
            const arrvSysSkillExObjLst = await vSysSkill_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvSysSkillExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysSkillExObjLst.length);
            console.log(strInfo);
            return arrvSysSkillExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vSysSkill_GetObjLst_localStorage = vSysSkill_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysSkill_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysSkillEN_js_1.clsvSysSkillEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvSysSkillObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvSysSkillObjLst_Cache;
        }
        else
            return null;
    }
    exports.vSysSkill_GetObjLst_localStorage_PureCache = vSysSkill_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vSysSkill_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSkill_GetObjLstAsync = vSysSkill_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysSkill_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysSkillEN_js_1.clsvSysSkillEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvSysSkillEN_js_1.clsvSysSkillEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysSkillEN_js_1.clsvSysSkillEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysSkillEN_js_1.clsvSysSkillEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvSysSkillEN_js_1.clsvSysSkillEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvSysSkillExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvSysSkillObjLst_T = vSysSkill_GetObjLstByJSONObjLst(arrvSysSkillExObjLst_Cache);
            return arrvSysSkillObjLst_T;
        }
        try {
            const arrvSysSkillExObjLst = await vSysSkill_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvSysSkillExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysSkillExObjLst.length);
            console.log(strInfo);
            return arrvSysSkillExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vSysSkill_GetObjLst_sessionStorage = vSysSkill_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysSkill_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysSkillEN_js_1.clsvSysSkillEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvSysSkillObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvSysSkillObjLst_Cache;
        }
        else
            return null;
    }
    exports.vSysSkill_GetObjLst_sessionStorage_PureCache = vSysSkill_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysSkill_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvSysSkillWApi.vSysSkill_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvSysSkillWApi.vSysSkill_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvSysSkillObjLst_Cache;
        switch (clsvSysSkillEN_js_1.clsvSysSkillEN.CacheModeId) {
            case "04": //sessionStorage
                arrvSysSkillObjLst_Cache = await vSysSkill_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvSysSkillObjLst_Cache = await vSysSkill_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvSysSkillObjLst_Cache = await vSysSkill_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvSysSkillObjLst_Cache = await vSysSkill_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvSysSkillObjLst = vSysSkill_GetObjLstByJSONObjLst(arrvSysSkillObjLst_Cache);
        return arrvSysSkillObjLst_Cache;
    }
    exports.vSysSkill_GetObjLst_Cache = vSysSkill_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysSkill_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvSysSkillObjLst_Cache;
        switch (clsvSysSkillEN_js_1.clsvSysSkillEN.CacheModeId) {
            case "04": //sessionStorage
                arrvSysSkillObjLst_Cache = await vSysSkill_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvSysSkillObjLst_Cache = await vSysSkill_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvSysSkillObjLst_Cache = null;
                break;
            default:
                arrvSysSkillObjLst_Cache = null;
                break;
        }
        return arrvSysSkillObjLst_Cache;
    }
    exports.vSysSkill_GetObjLst_PureCache = vSysSkill_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrSkillId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vSysSkill_GetSubObjLst_Cache(objvSysSkill_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvSysSkillObjLst_Cache = await vSysSkill_GetObjLst_Cache(strid_CurrEduCls);
        let arrvSysSkill_Sel = arrvSysSkillObjLst_Cache;
        if (objvSysSkill_Cond.sf_FldComparisonOp == null || objvSysSkill_Cond.sf_FldComparisonOp == "")
            return arrvSysSkill_Sel;
        const dicFldComparisonOp = JSON.parse(objvSysSkill_Cond.sf_FldComparisonOp);
        //console.log("clsvSysSkillWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvSysSkill_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysSkill_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvSysSkill_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvSysSkill_Cond), exports.vSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vSysSkill_GetSubObjLst_Cache = vSysSkill_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrSkillId:关键字列表
    * @returns 对象列表
    **/
    async function vSysSkill_GetObjLstBySkillIdLstAsync(arrSkillId) {
        const strThisFuncName = "GetObjLstBySkillIdLstAsync";
        const strAction = "GetObjLstBySkillIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSkillId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSkill_GetObjLstBySkillIdLstAsync = vSysSkill_GetObjLstBySkillIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrSkillIdLst:关键字列表
     * @returns 对象列表
    */
    async function vSysSkill_GetObjLstBySkillIdLst_Cache(arrSkillIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstBySkillIdLst_Cache";
        try {
            const arrvSysSkillObjLst_Cache = await vSysSkill_GetObjLst_Cache(strid_CurrEduCls);
            const arrvSysSkill_Sel = arrvSysSkillObjLst_Cache.filter(x => arrSkillIdLst.indexOf(x.skillId) > -1);
            return arrvSysSkill_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrSkillIdLst.join(","), exports.vSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vSysSkill_GetObjLstBySkillIdLst_Cache = vSysSkill_GetObjLstBySkillIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vSysSkill_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSkill_GetTopObjLstAsync = vSysSkill_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vSysSkill_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSkill_GetObjLstByRangeAsync = vSysSkill_GetObjLstByRangeAsync;
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
    async function vSysSkill_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSkill_GetObjLstByRange = vSysSkill_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vSysSkill_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvSysSkillObjLst_Cache = await vSysSkill_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysSkillObjLst_Cache.length == 0)
            return arrvSysSkillObjLst_Cache;
        let arrvSysSkill_Sel = arrvSysSkillObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvSysSkill_Cond = new clsvSysSkillEN_js_1.clsvSysSkillEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvSysSkill_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvSysSkillWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysSkill_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvSysSkill_Sel.length == 0)
                return arrvSysSkill_Sel;
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
                arrvSysSkill_Sel = arrvSysSkill_Sel.sort(vSysSkill_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvSysSkill_Sel = arrvSysSkill_Sel.sort(objPagerPara.sortFun);
            }
            arrvSysSkill_Sel = arrvSysSkill_Sel.slice(intStart, intEnd);
            return arrvSysSkill_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vSysSkill_GetObjLstByPager_Cache = vSysSkill_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vSysSkill_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSkill_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysSkill_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSkill_GetObjLstByPagerAsync = vSysSkill_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrSkillId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vSysSkill_IsExistRecord_Cache(objvSysSkill_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvSysSkillObjLst_Cache = await vSysSkill_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysSkillObjLst_Cache == null)
            return false;
        let arrvSysSkill_Sel = arrvSysSkillObjLst_Cache;
        if (objvSysSkill_Cond.sf_FldComparisonOp == null || objvSysSkill_Cond.sf_FldComparisonOp == "")
            return arrvSysSkill_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvSysSkill_Cond.sf_FldComparisonOp);
        //console.log("clsvSysSkillWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvSysSkill_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysSkill_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvSysSkill_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvSysSkill_Cond), exports.vSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vSysSkill_IsExistRecord_Cache = vSysSkill_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vSysSkill_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSkill_IsExistRecordAsync = vSysSkill_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strSkillId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vSysSkill_IsExist(strSkillId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSkill_IsExist = vSysSkill_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strSkillId:所给的关键字
     * @returns 对象
    */
    async function vSysSkill_IsExist_Cache(strSkillId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvSysSkillObjLst_Cache = await vSysSkill_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysSkillObjLst_Cache == null)
            return false;
        try {
            const arrvSysSkill_Sel = arrvSysSkillObjLst_Cache.filter(x => x.skillId == strSkillId);
            if (arrvSysSkill_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strSkillId, exports.vSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vSysSkill_IsExist_Cache = vSysSkill_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strSkillId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vSysSkill_IsExistAsync(strSkillId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSkill_IsExistAsync = vSysSkill_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vSysSkill_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSkill_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSkill_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSkill_GetRecCountByCondAsync = vSysSkill_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvSysSkill_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vSysSkill_GetRecCountByCond_Cache(objvSysSkill_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvSysSkillObjLst_Cache = await vSysSkill_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysSkillObjLst_Cache == null)
            return 0;
        let arrvSysSkill_Sel = arrvSysSkillObjLst_Cache;
        if (objvSysSkill_Cond.sf_FldComparisonOp == null || objvSysSkill_Cond.sf_FldComparisonOp == "")
            return arrvSysSkill_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvSysSkill_Cond.sf_FldComparisonOp);
        //console.log("clsvSysSkillWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvSysSkill_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysSkill_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysSkill_Sel = arrvSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvSysSkill_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvSysSkill_Cond), exports.vSysSkill_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vSysSkill_GetRecCountByCond_Cache = vSysSkill_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vSysSkill_GetWebApiUrl(strController, strAction) {
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
    exports.vSysSkill_GetWebApiUrl = vSysSkill_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vSysSkill_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysSkillEN_js_1.clsvSysSkillEN._CurrTabName, strid_CurrEduCls);
            switch (clsvSysSkillEN_js_1.clsvSysSkillEN.CacheModeId) {
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
    exports.vSysSkill_ReFreshThisCache = vSysSkill_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function vSysSkill_BindDdl_SkillIdInDiv_Cache(strDivName, strDdlName, strid_CurrEduCls) {
        const strThisFuncName = "BindDdl_SkillIdInDiv_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsvSysSkillWApi.BindDdl_SkillIdInDiv)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsvSysSkillWApi.BindDdl_SkillIdInDiv)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_SkillIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_SkillIdInDiv_Cache");
        const arrObjLst_Sel = await vSysSkill_GetObjLst_Cache(strid_CurrEduCls);
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv_V)(strDivName, strDdlName, arrObjLst_Sel, clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillId, clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillName, "技能表视图");
    }
    exports.vSysSkill_BindDdl_SkillIdInDiv_Cache = vSysSkill_BindDdl_SkillIdInDiv_Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vSysSkill_GetJSONStrByObj(pobjvSysSkillEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvSysSkillEN);
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
    exports.vSysSkill_GetJSONStrByObj = vSysSkill_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vSysSkill_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvSysSkillObjLst = new Array();
        if (strJSON === "") {
            return arrvSysSkillObjLst;
        }
        try {
            arrvSysSkillObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvSysSkillObjLst;
        }
        return arrvSysSkillObjLst;
    }
    exports.vSysSkill_GetObjLstByJSONStr = vSysSkill_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvSysSkillObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vSysSkill_GetObjLstByJSONObjLst(arrvSysSkillObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvSysSkillObjLst = new Array();
        for (const objInFor of arrvSysSkillObjLstS) {
            const obj1 = vSysSkill_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvSysSkillObjLst.push(obj1);
        }
        return arrvSysSkillObjLst;
    }
    exports.vSysSkill_GetObjLstByJSONObjLst = vSysSkill_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vSysSkill_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvSysSkillEN = new clsvSysSkillEN_js_1.clsvSysSkillEN();
        if (strJSON === "") {
            return pobjvSysSkillEN;
        }
        try {
            pobjvSysSkillEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvSysSkillEN;
        }
        return pobjvSysSkillEN;
    }
    exports.vSysSkill_GetObjByJSONStr = vSysSkill_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vSysSkill_GetCombineCondition(objvSysSkill_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillId) == true) {
            const strComparisonOp_SkillId = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillId, objvSysSkill_Cond.skillId, strComparisonOp_SkillId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillName) == true) {
            const strComparisonOp_SkillName = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillName, objvSysSkill_Cond.skillName, strComparisonOp_SkillName);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeId) == true) {
            const strComparisonOp_OperationTypeId = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeId, objvSysSkill_Cond.operationTypeId, strComparisonOp_OperationTypeId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_LevelId) == true) {
            const strComparisonOp_LevelId = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_LevelId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSkillEN_js_1.clsvSysSkillEN.con_LevelId, objvSysSkill_Cond.levelId, strComparisonOp_LevelId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_LevelName) == true) {
            const strComparisonOp_LevelName = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_LevelName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSkillEN_js_1.clsvSysSkillEN.con_LevelName, objvSysSkill_Cond.levelName, strComparisonOp_LevelName);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser, objvSysSkill_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdDate, objvSysSkill_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_IsSubmit) == true) {
            if (objvSysSkill_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvSysSkillEN_js_1.clsvSysSkillEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvSysSkillEN_js_1.clsvSysSkillEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_CitationId) == true) {
            const strComparisonOp_CitationId = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_CitationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSkillEN_js_1.clsvSysSkillEN.con_CitationId, objvSysSkill_Cond.citationId, strComparisonOp_CitationId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysSkillEN_js_1.clsvSysSkillEN.con_OkCount, objvSysSkill_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysSkillEN_js_1.clsvSysSkillEN.con_AppraiseCount, objvSysSkill_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_Score) == true) {
            const strComparisonOp_Score = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_Score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysSkillEN_js_1.clsvSysSkillEN.con_Score, objvSysSkill_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysSkillEN_js_1.clsvSysSkillEN.con_StuScore, objvSysSkill_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysSkillEN_js_1.clsvSysSkillEN.con_TeaScore, objvSysSkill_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSkillEN_js_1.clsvSysSkillEN.con_id_CurrEduCls, objvSysSkill_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_PdfContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSkillEN_js_1.clsvSysSkillEN.con_PdfContent, objvSysSkill_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysSkillEN_js_1.clsvSysSkillEN.con_PdfPageNum, objvSysSkill_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_CitationCount) == true) {
            const strComparisonOp_CitationCount = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_CitationCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysSkillEN_js_1.clsvSysSkillEN.con_CitationCount, objvSysSkill_Cond.citationCount, strComparisonOp_CitationCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysSkillEN_js_1.clsvSysSkillEN.con_VersionCount, objvSysSkill_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSkillEN_js_1.clsvSysSkillEN.con_Memo, objvSysSkill_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeName) == true) {
            const strComparisonOp_OperationTypeName = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeName, objvSysSkill_Cond.operationTypeName, strComparisonOp_OperationTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSkillEN_js_1.clsvSysSkillEN.con_CreateDate, objvSysSkill_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSkill_Cond.dicFldComparisonOp, clsvSysSkillEN_js_1.clsvSysSkillEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvSysSkill_Cond.dicFldComparisonOp[clsvSysSkillEN_js_1.clsvSysSkillEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSkillEN_js_1.clsvSysSkillEN.con_ShareId, objvSysSkill_Cond.shareId, strComparisonOp_ShareId);
        }
        return strWhereCond;
    }
    exports.vSysSkill_GetCombineCondition = vSysSkill_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvSysSkillENS:源对象
     * @param objvSysSkillENT:目标对象
    */
    function vSysSkill_CopyObjTo(objvSysSkillENS, objvSysSkillENT) {
        objvSysSkillENT.skillId = objvSysSkillENS.skillId; //技能Id
        objvSysSkillENT.skillName = objvSysSkillENS.skillName; //技能名称
        objvSysSkillENT.operationTypeId = objvSysSkillENS.operationTypeId; //操作类型ID
        objvSysSkillENT.process = objvSysSkillENS.process; //实施过程
        objvSysSkillENT.levelId = objvSysSkillENS.levelId; //级别Id
        objvSysSkillENT.levelName = objvSysSkillENS.levelName; //级别名称
        objvSysSkillENT.updUser = objvSysSkillENS.updUser; //修改人
        objvSysSkillENT.updDate = objvSysSkillENS.updDate; //修改日期
        objvSysSkillENT.isSubmit = objvSysSkillENS.isSubmit; //是否提交
        objvSysSkillENT.citationId = objvSysSkillENS.citationId; //引用Id
        objvSysSkillENT.okCount = objvSysSkillENS.okCount; //点赞统计
        objvSysSkillENT.appraiseCount = objvSysSkillENS.appraiseCount; //评论数
        objvSysSkillENT.score = objvSysSkillENS.score; //评分
        objvSysSkillENT.stuScore = objvSysSkillENS.stuScore; //学生平均分
        objvSysSkillENT.teaScore = objvSysSkillENS.teaScore; //教师评分
        objvSysSkillENT.id_CurrEduCls = objvSysSkillENS.id_CurrEduCls; //教学班流水号
        objvSysSkillENT.pdfContent = objvSysSkillENS.pdfContent; //Pdf内容
        objvSysSkillENT.pdfPageNum = objvSysSkillENS.pdfPageNum; //Pdf页码
        objvSysSkillENT.citationCount = objvSysSkillENS.citationCount; //引用统计
        objvSysSkillENT.versionCount = objvSysSkillENS.versionCount; //版本统计
        objvSysSkillENT.memo = objvSysSkillENS.memo; //备注
        objvSysSkillENT.operationTypeName = objvSysSkillENS.operationTypeName; //操作类型名
        objvSysSkillENT.createDate = objvSysSkillENS.createDate; //建立日期
        objvSysSkillENT.shareId = objvSysSkillENS.shareId; //分享Id
    }
    exports.vSysSkill_CopyObjTo = vSysSkill_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvSysSkillENS:源对象
     * @param objvSysSkillENT:目标对象
    */
    function vSysSkill_GetObjFromJsonObj(objvSysSkillENS) {
        const objvSysSkillENT = new clsvSysSkillEN_js_1.clsvSysSkillEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvSysSkillENT, objvSysSkillENS);
        return objvSysSkillENT;
    }
    exports.vSysSkill_GetObjFromJsonObj = vSysSkill_GetObjFromJsonObj;
});
