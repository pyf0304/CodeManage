/**
* 类名:clsJournalSubjectWApi
* 表名:JournalSubject(01120930)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:49:53
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduPaper/clsJournalSubjectEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.JournalSubject_GetObjFromJsonObj = exports.JournalSubject_CopyObjTo = exports.JournalSubject_GetUniCondStr4Update_JournalSubjectCategoryId_JournalSubjectName = exports.JournalSubject_GetUniCondStr_JournalSubjectCategoryId_JournalSubjectName = exports.JournalSubject_GetCombineCondition = exports.JournalSubject_GetObjByJSONStr = exports.JournalSubject_GetObjLstByJSONObjLst = exports.JournalSubject_GetObjLstByJSONStr = exports.JournalSubject_GetJSONStrByObj = exports.JournalSubject_CheckProperty4Update = exports.JournalSubject_CheckPropertyNew = exports.JournalSubject_BindDdl_JournalSubjectIdInDiv_Cache = exports.JournalSubject_ReFreshThisCache = exports.JournalSubject_ReFreshCache = exports.JournalSubject_GetWebApiUrl = exports.JournalSubject_GetMaxStrIdByPrefix = exports.JournalSubject_GetMaxStrIdAsync = exports.JournalSubject_GetRecCountByCond_Cache = exports.JournalSubject_GetRecCountByCondAsync = exports.JournalSubject_IsExistAsync = exports.JournalSubject_IsExist_Cache = exports.JournalSubject_IsExist = exports.JournalSubject_IsExistRecordAsync = exports.JournalSubject_IsExistRecord_Cache = exports.JournalSubject_UpdateWithConditionAsync = exports.JournalSubject_UpdateRecordAsync = exports.JournalSubject_AddNewRecordWithReturnKey = exports.JournalSubject_AddNewRecordWithReturnKeyAsync = exports.JournalSubject_AddNewRecordWithMaxIdAsync = exports.JournalSubject_AddNewRecordAsync = exports.JournalSubject_DelJournalSubjectsByCondAsync = exports.JournalSubject_DelJournalSubjectsAsync = exports.JournalSubject_DelRecordAsync = exports.JournalSubject_GetObjLstByPagerAsync = exports.JournalSubject_GetObjLstByPager_Cache = exports.JournalSubject_GetObjLstByRange = exports.JournalSubject_GetObjLstByRangeAsync = exports.JournalSubject_GetTopObjLstAsync = exports.JournalSubject_GetObjLstByJournalSubjectIdLst_Cache = exports.JournalSubject_GetObjLstByJournalSubjectIdLstAsync = exports.JournalSubject_GetSubObjLst_Cache = exports.JournalSubject_GetObjLst_PureCache = exports.JournalSubject_GetObjLst_Cache = exports.JournalSubject_GetObjLst_sessionStorage_PureCache = exports.JournalSubject_GetObjLst_sessionStorage = exports.JournalSubject_GetObjLstAsync = exports.JournalSubject_GetObjLst_localStorage_PureCache = exports.JournalSubject_GetObjLst_localStorage = exports.JournalSubject_GetObjLst_ClientCache = exports.JournalSubject_GetFirstObjAsync = exports.JournalSubject_GetFirstID = exports.JournalSubject_GetFirstIDAsync = exports.JournalSubject_funcKey = exports.JournalSubject_FilterFunByKey = exports.JournalSubject_SortFunByKey = exports.JournalSubject_SortFun_Defa_2Fld = exports.JournalSubject_SortFun_Defa = exports.JournalSubject_func = exports.JournalSubject_GetNameByJournalSubjectId_Cache = exports.JournalSubject_UpdateObjInLst_Cache = exports.JournalSubject_GetObjByJournalSubjectId_localStorage = exports.JournalSubject_GetObjByJournalSubjectId_Cache = exports.JournalSubject_GetObjByJournalSubjectIdAsync = exports.journalSubject_ConstructorName = exports.journalSubject_Controller = void 0;
    /**
     * 期刊学科(JournalSubject)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsJournalSubjectEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsJournalSubjectEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.journalSubject_Controller = "JournalSubjectApi";
    exports.journalSubject_ConstructorName = "journalSubject";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strJournalSubjectId:关键字
    * @returns 对象
    **/
    async function JournalSubject_GetObjByJournalSubjectIdAsync(strJournalSubjectId) {
        const strThisFuncName = "GetObjByJournalSubjectIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strJournalSubjectId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strJournalSubjectId]不能为空！(In clsJournalSubjectWApi.GetObjByJournalSubjectIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strJournalSubjectId.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strJournalSubjectId]的长度:[{0}]不正确！(clsJournalSubjectWApi.GetObjByJournalSubjectIdAsync)", strJournalSubjectId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByJournalSubjectId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strJournalSubjectId": strJournalSubjectId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objJournalSubject = JournalSubject_GetObjFromJsonObj(returnObj);
                return objJournalSubject;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_GetObjByJournalSubjectIdAsync = JournalSubject_GetObjByJournalSubjectIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strJournalSubjectId:所给的关键字
     * @returns 对象
    */
    async function JournalSubject_GetObjByJournalSubjectId_Cache(strJournalSubjectId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByJournalSubjectId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strJournalSubjectId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strJournalSubjectId]不能为空！(In clsJournalSubjectWApi.GetObjByJournalSubjectId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strJournalSubjectId.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strJournalSubjectId]的长度:[{0}]不正确！(clsJournalSubjectWApi.GetObjByJournalSubjectId_Cache)", strJournalSubjectId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrJournalSubjectObjLst_Cache = await JournalSubject_GetObjLst_Cache();
        try {
            const arrJournalSubject_Sel = arrJournalSubjectObjLst_Cache.filter(x => x.journalSubjectId == strJournalSubjectId);
            let objJournalSubject;
            if (arrJournalSubject_Sel.length > 0) {
                objJournalSubject = arrJournalSubject_Sel[0];
                return objJournalSubject;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objJournalSubject_Const = await JournalSubject_GetObjByJournalSubjectIdAsync(strJournalSubjectId);
                    if (objJournalSubject_Const != null) {
                        JournalSubject_ReFreshThisCache();
                        return objJournalSubject_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strJournalSubjectId, exports.journalSubject_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.JournalSubject_GetObjByJournalSubjectId_Cache = JournalSubject_GetObjByJournalSubjectId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strJournalSubjectId:所给的关键字
     * @returns 对象
    */
    async function JournalSubject_GetObjByJournalSubjectId_localStorage(strJournalSubjectId) {
        const strThisFuncName = "GetObjByJournalSubjectId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strJournalSubjectId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strJournalSubjectId]不能为空！(In clsJournalSubjectWApi.GetObjByJournalSubjectId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strJournalSubjectId.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strJournalSubjectId]的长度:[{0}]不正确！(clsJournalSubjectWApi.GetObjByJournalSubjectId_localStorage)", strJournalSubjectId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsJournalSubjectEN_js_1.clsJournalSubjectEN._CurrTabName, strJournalSubjectId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objJournalSubject_Cache = JSON.parse(strTempObj);
            return objJournalSubject_Cache;
        }
        try {
            const objJournalSubject = await JournalSubject_GetObjByJournalSubjectIdAsync(strJournalSubjectId);
            if (objJournalSubject != null) {
                localStorage.setItem(strKey, JSON.stringify(objJournalSubject));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objJournalSubject;
            }
            return objJournalSubject;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strJournalSubjectId, exports.journalSubject_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.JournalSubject_GetObjByJournalSubjectId_localStorage = JournalSubject_GetObjByJournalSubjectId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objJournalSubject:所给的对象
     * @returns 对象
    */
    async function JournalSubject_UpdateObjInLst_Cache(objJournalSubject) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrJournalSubjectObjLst_Cache = await JournalSubject_GetObjLst_Cache();
            const obj = arrJournalSubjectObjLst_Cache.find(x => x.journalSubjectCategoryId == objJournalSubject.journalSubjectCategoryId && x.journalSubjectName == objJournalSubject.journalSubjectName);
            if (obj != null) {
                objJournalSubject.journalSubjectId = obj.journalSubjectId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objJournalSubject);
            }
            else {
                arrJournalSubjectObjLst_Cache.push(objJournalSubject);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.journalSubject_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.JournalSubject_UpdateObjInLst_Cache = JournalSubject_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strJournalSubjectId:所给的关键字
     * @returns 对象
    */
    async function JournalSubject_GetNameByJournalSubjectId_Cache(strJournalSubjectId) {
        const strThisFuncName = "GetNameByJournalSubjectId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strJournalSubjectId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strJournalSubjectId]不能为空！(In clsJournalSubjectWApi.GetNameByJournalSubjectId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strJournalSubjectId.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strJournalSubjectId]的长度:[{0}]不正确！(clsJournalSubjectWApi.GetNameByJournalSubjectId_Cache)", strJournalSubjectId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrJournalSubjectObjLst_Cache = await JournalSubject_GetObjLst_Cache();
        if (arrJournalSubjectObjLst_Cache == null)
            return "";
        try {
            const arrJournalSubject_Sel = arrJournalSubjectObjLst_Cache.filter(x => x.journalSubjectId == strJournalSubjectId);
            let objJournalSubject;
            if (arrJournalSubject_Sel.length > 0) {
                objJournalSubject = arrJournalSubject_Sel[0];
                return objJournalSubject.journalSubjectName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strJournalSubjectId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.JournalSubject_GetNameByJournalSubjectId_Cache = JournalSubject_GetNameByJournalSubjectId_Cache;
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
    async function JournalSubject_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsJournalSubjectEN_js_1.clsJournalSubjectEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsJournalSubjectEN_js_1.clsJournalSubjectEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strJournalSubjectId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objJournalSubject = await JournalSubject_GetObjByJournalSubjectId_Cache(strJournalSubjectId);
        if (objJournalSubject == null)
            return "";
        if (objJournalSubject.GetFldValue(strOutFldName) == null)
            return "";
        return objJournalSubject.GetFldValue(strOutFldName).toString();
    }
    exports.JournalSubject_func = JournalSubject_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function JournalSubject_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.journalSubjectId.localeCompare(b.journalSubjectId);
    }
    exports.JournalSubject_SortFun_Defa = JournalSubject_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function JournalSubject_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.journalSubjectCode == b.journalSubjectCode)
            return a.journalSubjectName.localeCompare(b.journalSubjectName);
        else
            return a.journalSubjectCode.localeCompare(b.journalSubjectCode);
    }
    exports.JournalSubject_SortFun_Defa_2Fld = JournalSubject_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function JournalSubject_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectId:
                    return (a, b) => {
                        return a.journalSubjectId.localeCompare(b.journalSubjectId);
                    };
                case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectCode:
                    return (a, b) => {
                        return a.journalSubjectCode.localeCompare(b.journalSubjectCode);
                    };
                case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectName:
                    return (a, b) => {
                        return a.journalSubjectName.localeCompare(b.journalSubjectName);
                    };
                case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectCategoryId:
                    return (a, b) => {
                        return a.journalSubjectCategoryId.localeCompare(b.journalSubjectCategoryId);
                    };
                case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[JournalSubject]中不存在！(in ${exports.journalSubject_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectId:
                    return (a, b) => {
                        return b.journalSubjectId.localeCompare(a.journalSubjectId);
                    };
                case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectCode:
                    return (a, b) => {
                        return b.journalSubjectCode.localeCompare(a.journalSubjectCode);
                    };
                case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectName:
                    return (a, b) => {
                        return b.journalSubjectName.localeCompare(a.journalSubjectName);
                    };
                case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectCategoryId:
                    return (a, b) => {
                        return b.journalSubjectCategoryId.localeCompare(a.journalSubjectCategoryId);
                    };
                case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[JournalSubject]中不存在！(in ${exports.journalSubject_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.JournalSubject_SortFunByKey = JournalSubject_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function JournalSubject_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectId:
                return (obj) => {
                    return obj.journalSubjectId === value;
                };
            case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectCode:
                return (obj) => {
                    return obj.journalSubjectCode === value;
                };
            case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectName:
                return (obj) => {
                    return obj.journalSubjectName === value;
                };
            case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectCategoryId:
                return (obj) => {
                    return obj.journalSubjectCategoryId === value;
                };
            case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[JournalSubject]中不存在！(in ${exports.journalSubject_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.JournalSubject_FilterFunByKey = JournalSubject_FilterFunByKey;
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
    async function JournalSubject_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrJournalSubject = await JournalSubject_GetObjLst_Cache();
        if (arrJournalSubject == null)
            return [];
        let arrJournalSubject_Sel = arrJournalSubject;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrJournalSubject_Sel.length == 0)
            return [];
        return arrJournalSubject_Sel.map(x => x.journalSubjectId);
    }
    exports.JournalSubject_funcKey = JournalSubject_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function JournalSubject_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_GetFirstIDAsync = JournalSubject_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function JournalSubject_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_GetFirstID = JournalSubject_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function JournalSubject_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
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
                const objJournalSubject = JournalSubject_GetObjFromJsonObj(returnObj);
                return objJournalSubject;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_GetFirstObjAsync = JournalSubject_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function JournalSubject_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsJournalSubjectEN_js_1.clsJournalSubjectEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsJournalSubjectEN_js_1.clsJournalSubjectEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsJournalSubjectEN_js_1.clsJournalSubjectEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrJournalSubjectExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrJournalSubjectObjLst_T = JournalSubject_GetObjLstByJSONObjLst(arrJournalSubjectExObjLst_Cache);
            return arrJournalSubjectObjLst_T;
        }
        try {
            const arrJournalSubjectExObjLst = await JournalSubject_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrJournalSubjectExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrJournalSubjectExObjLst.length);
            console.log(strInfo);
            return arrJournalSubjectExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.journalSubject_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.JournalSubject_GetObjLst_ClientCache = JournalSubject_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function JournalSubject_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsJournalSubjectEN_js_1.clsJournalSubjectEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsJournalSubjectEN_js_1.clsJournalSubjectEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsJournalSubjectEN_js_1.clsJournalSubjectEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrJournalSubjectExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrJournalSubjectObjLst_T = JournalSubject_GetObjLstByJSONObjLst(arrJournalSubjectExObjLst_Cache);
            return arrJournalSubjectObjLst_T;
        }
        try {
            const arrJournalSubjectExObjLst = await JournalSubject_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrJournalSubjectExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrJournalSubjectExObjLst.length);
            console.log(strInfo);
            return arrJournalSubjectExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.journalSubject_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.JournalSubject_GetObjLst_localStorage = JournalSubject_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function JournalSubject_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsJournalSubjectEN_js_1.clsJournalSubjectEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrJournalSubjectObjLst_Cache = JSON.parse(strTempObjLst);
            return arrJournalSubjectObjLst_Cache;
        }
        else
            return null;
    }
    exports.JournalSubject_GetObjLst_localStorage_PureCache = JournalSubject_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function JournalSubject_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.journalSubject_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = JournalSubject_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_GetObjLstAsync = JournalSubject_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function JournalSubject_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsJournalSubjectEN_js_1.clsJournalSubjectEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsJournalSubjectEN_js_1.clsJournalSubjectEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsJournalSubjectEN_js_1.clsJournalSubjectEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrJournalSubjectExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrJournalSubjectObjLst_T = JournalSubject_GetObjLstByJSONObjLst(arrJournalSubjectExObjLst_Cache);
            return arrJournalSubjectObjLst_T;
        }
        try {
            const arrJournalSubjectExObjLst = await JournalSubject_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrJournalSubjectExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrJournalSubjectExObjLst.length);
            console.log(strInfo);
            return arrJournalSubjectExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.journalSubject_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.JournalSubject_GetObjLst_sessionStorage = JournalSubject_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function JournalSubject_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsJournalSubjectEN_js_1.clsJournalSubjectEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrJournalSubjectObjLst_Cache = JSON.parse(strTempObjLst);
            return arrJournalSubjectObjLst_Cache;
        }
        else
            return null;
    }
    exports.JournalSubject_GetObjLst_sessionStorage_PureCache = JournalSubject_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function JournalSubject_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrJournalSubjectObjLst_Cache;
        switch (clsJournalSubjectEN_js_1.clsJournalSubjectEN.CacheModeId) {
            case "04": //sessionStorage
                arrJournalSubjectObjLst_Cache = await JournalSubject_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrJournalSubjectObjLst_Cache = await JournalSubject_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrJournalSubjectObjLst_Cache = await JournalSubject_GetObjLst_ClientCache();
                break;
            default:
                arrJournalSubjectObjLst_Cache = await JournalSubject_GetObjLst_ClientCache();
                break;
        }
        const arrJournalSubjectObjLst = JournalSubject_GetObjLstByJSONObjLst(arrJournalSubjectObjLst_Cache);
        return arrJournalSubjectObjLst_Cache;
    }
    exports.JournalSubject_GetObjLst_Cache = JournalSubject_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function JournalSubject_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrJournalSubjectObjLst_Cache;
        switch (clsJournalSubjectEN_js_1.clsJournalSubjectEN.CacheModeId) {
            case "04": //sessionStorage
                arrJournalSubjectObjLst_Cache = await JournalSubject_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrJournalSubjectObjLst_Cache = await JournalSubject_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrJournalSubjectObjLst_Cache = null;
                break;
            default:
                arrJournalSubjectObjLst_Cache = null;
                break;
        }
        return arrJournalSubjectObjLst_Cache;
    }
    exports.JournalSubject_GetObjLst_PureCache = JournalSubject_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrJournalSubjectId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function JournalSubject_GetSubObjLst_Cache(objJournalSubject_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrJournalSubjectObjLst_Cache = await JournalSubject_GetObjLst_Cache();
        let arrJournalSubject_Sel = arrJournalSubjectObjLst_Cache;
        if (objJournalSubject_Cond.sf_FldComparisonOp == null || objJournalSubject_Cond.sf_FldComparisonOp == "")
            return arrJournalSubject_Sel;
        const dicFldComparisonOp = JSON.parse(objJournalSubject_Cond.sf_FldComparisonOp);
        //console.log("clsJournalSubjectWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objJournalSubject_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objJournalSubject_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrJournalSubject_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objJournalSubject_Cond), exports.journalSubject_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.JournalSubject_GetSubObjLst_Cache = JournalSubject_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrJournalSubjectId:关键字列表
    * @returns 对象列表
    **/
    async function JournalSubject_GetObjLstByJournalSubjectIdLstAsync(arrJournalSubjectId) {
        const strThisFuncName = "GetObjLstByJournalSubjectIdLstAsync";
        const strAction = "GetObjLstByJournalSubjectIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrJournalSubjectId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.journalSubject_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = JournalSubject_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_GetObjLstByJournalSubjectIdLstAsync = JournalSubject_GetObjLstByJournalSubjectIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrJournalSubjectIdLst:关键字列表
     * @returns 对象列表
    */
    async function JournalSubject_GetObjLstByJournalSubjectIdLst_Cache(arrJournalSubjectIdLst) {
        const strThisFuncName = "GetObjLstByJournalSubjectIdLst_Cache";
        try {
            const arrJournalSubjectObjLst_Cache = await JournalSubject_GetObjLst_Cache();
            const arrJournalSubject_Sel = arrJournalSubjectObjLst_Cache.filter(x => arrJournalSubjectIdLst.indexOf(x.journalSubjectId) > -1);
            return arrJournalSubject_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrJournalSubjectIdLst.join(","), exports.journalSubject_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.JournalSubject_GetObjLstByJournalSubjectIdLst_Cache = JournalSubject_GetObjLstByJournalSubjectIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function JournalSubject_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.journalSubject_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = JournalSubject_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_GetTopObjLstAsync = JournalSubject_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function JournalSubject_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.journalSubject_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = JournalSubject_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_GetObjLstByRangeAsync = JournalSubject_GetObjLstByRangeAsync;
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
    async function JournalSubject_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_GetObjLstByRange = JournalSubject_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function JournalSubject_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrJournalSubjectObjLst_Cache = await JournalSubject_GetObjLst_Cache();
        if (arrJournalSubjectObjLst_Cache.length == 0)
            return arrJournalSubjectObjLst_Cache;
        let arrJournalSubject_Sel = arrJournalSubjectObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objJournalSubject_Cond = new clsJournalSubjectEN_js_1.clsJournalSubjectEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objJournalSubject_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsJournalSubjectWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objJournalSubject_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrJournalSubject_Sel.length == 0)
                return arrJournalSubject_Sel;
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
                arrJournalSubject_Sel = arrJournalSubject_Sel.sort(JournalSubject_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrJournalSubject_Sel = arrJournalSubject_Sel.sort(objPagerPara.sortFun);
            }
            arrJournalSubject_Sel = arrJournalSubject_Sel.slice(intStart, intEnd);
            return arrJournalSubject_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.journalSubject_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.JournalSubject_GetObjLstByPager_Cache = JournalSubject_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function JournalSubject_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.journalSubject_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = JournalSubject_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_GetObjLstByPagerAsync = JournalSubject_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strJournalSubjectId:关键字
    * @returns 获取删除的结果
    **/
    async function JournalSubject_DelRecordAsync(strJournalSubjectId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strJournalSubjectId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_DelRecordAsync = JournalSubject_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrJournalSubjectId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function JournalSubject_DelJournalSubjectsAsync(arrJournalSubjectId) {
        const strThisFuncName = "DelJournalSubjectsAsync";
        const strAction = "DelJournalSubjects";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrJournalSubjectId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_DelJournalSubjectsAsync = JournalSubject_DelJournalSubjectsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function JournalSubject_DelJournalSubjectsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelJournalSubjectsByCondAsync";
        const strAction = "DelJournalSubjectsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_DelJournalSubjectsByCondAsync = JournalSubject_DelJournalSubjectsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objJournalSubjectEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function JournalSubject_AddNewRecordAsync(objJournalSubjectEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objJournalSubjectEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objJournalSubjectEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_AddNewRecordAsync = JournalSubject_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objJournalSubjectEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function JournalSubject_AddNewRecordWithMaxIdAsync(objJournalSubjectEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objJournalSubjectEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_AddNewRecordWithMaxIdAsync = JournalSubject_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objJournalSubjectEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function JournalSubject_AddNewRecordWithReturnKeyAsync(objJournalSubjectEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objJournalSubjectEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_AddNewRecordWithReturnKeyAsync = JournalSubject_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objJournalSubjectEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function JournalSubject_AddNewRecordWithReturnKey(objJournalSubjectEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objJournalSubjectEN.journalSubjectId === null || objJournalSubjectEN.journalSubjectId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objJournalSubjectEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_AddNewRecordWithReturnKey = JournalSubject_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objJournalSubjectEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function JournalSubject_UpdateRecordAsync(objJournalSubjectEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objJournalSubjectEN.sf_UpdFldSetStr === undefined || objJournalSubjectEN.sf_UpdFldSetStr === null || objJournalSubjectEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objJournalSubjectEN.journalSubjectId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objJournalSubjectEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_UpdateRecordAsync = JournalSubject_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objJournalSubjectEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function JournalSubject_UpdateWithConditionAsync(objJournalSubjectEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objJournalSubjectEN.sf_UpdFldSetStr === undefined || objJournalSubjectEN.sf_UpdFldSetStr === null || objJournalSubjectEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objJournalSubjectEN.journalSubjectId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
        objJournalSubjectEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objJournalSubjectEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_UpdateWithConditionAsync = JournalSubject_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrJournalSubjectId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function JournalSubject_IsExistRecord_Cache(objJournalSubject_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrJournalSubjectObjLst_Cache = await JournalSubject_GetObjLst_Cache();
        if (arrJournalSubjectObjLst_Cache == null)
            return false;
        let arrJournalSubject_Sel = arrJournalSubjectObjLst_Cache;
        if (objJournalSubject_Cond.sf_FldComparisonOp == null || objJournalSubject_Cond.sf_FldComparisonOp == "")
            return arrJournalSubject_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objJournalSubject_Cond.sf_FldComparisonOp);
        //console.log("clsJournalSubjectWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objJournalSubject_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objJournalSubject_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrJournalSubject_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objJournalSubject_Cond), exports.journalSubject_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.JournalSubject_IsExistRecord_Cache = JournalSubject_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function JournalSubject_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_IsExistRecordAsync = JournalSubject_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strJournalSubjectId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function JournalSubject_IsExist(strJournalSubjectId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "JournalSubjectId": strJournalSubjectId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_IsExist = JournalSubject_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strJournalSubjectId:所给的关键字
     * @returns 对象
    */
    async function JournalSubject_IsExist_Cache(strJournalSubjectId) {
        const strThisFuncName = "IsExist_Cache";
        const arrJournalSubjectObjLst_Cache = await JournalSubject_GetObjLst_Cache();
        if (arrJournalSubjectObjLst_Cache == null)
            return false;
        try {
            const arrJournalSubject_Sel = arrJournalSubjectObjLst_Cache.filter(x => x.journalSubjectId == strJournalSubjectId);
            if (arrJournalSubject_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strJournalSubjectId, exports.journalSubject_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.JournalSubject_IsExist_Cache = JournalSubject_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strJournalSubjectId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function JournalSubject_IsExistAsync(strJournalSubjectId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strJournalSubjectId": strJournalSubjectId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_IsExistAsync = JournalSubject_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function JournalSubject_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_GetRecCountByCondAsync = JournalSubject_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objJournalSubject_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function JournalSubject_GetRecCountByCond_Cache(objJournalSubject_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrJournalSubjectObjLst_Cache = await JournalSubject_GetObjLst_Cache();
        if (arrJournalSubjectObjLst_Cache == null)
            return 0;
        let arrJournalSubject_Sel = arrJournalSubjectObjLst_Cache;
        if (objJournalSubject_Cond.sf_FldComparisonOp == null || objJournalSubject_Cond.sf_FldComparisonOp == "")
            return arrJournalSubject_Sel.length;
        const dicFldComparisonOp = JSON.parse(objJournalSubject_Cond.sf_FldComparisonOp);
        //console.log("clsJournalSubjectWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objJournalSubject_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objJournalSubject_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrJournalSubject_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objJournalSubject_Cond), exports.journalSubject_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.JournalSubject_GetRecCountByCond_Cache = JournalSubject_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function JournalSubject_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_GetMaxStrIdAsync = JournalSubject_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function JournalSubject_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.journalSubject_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubject_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubject_GetMaxStrIdByPrefix = JournalSubject_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function JournalSubject_GetWebApiUrl(strController, strAction) {
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
    exports.JournalSubject_GetWebApiUrl = JournalSubject_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function JournalSubject_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsJournalSubjectEN_js_1.clsJournalSubjectEN._CurrTabName;
        switch (clsJournalSubjectEN_js_1.clsJournalSubjectEN.CacheModeId) {
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
    exports.JournalSubject_ReFreshCache = JournalSubject_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function JournalSubject_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsJournalSubjectEN_js_1.clsJournalSubjectEN._CurrTabName;
            switch (clsJournalSubjectEN_js_1.clsJournalSubjectEN.CacheModeId) {
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
    exports.JournalSubject_ReFreshThisCache = JournalSubject_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function JournalSubject_BindDdl_JournalSubjectIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_JournalSubjectIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_JournalSubjectIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_JournalSubjectIdInDiv_Cache");
        const arrObjLst_Sel = await JournalSubject_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectId, clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectName, "期刊学科");
    }
    exports.JournalSubject_BindDdl_JournalSubjectIdInDiv_Cache = JournalSubject_BindDdl_JournalSubjectIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function JournalSubject_CheckPropertyNew(pobjJournalSubjectEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectCode) === true) {
            throw new Error("(errid:Watl000058)字段[期刊学科代码]不能为空(In 期刊学科)!(clsJournalSubjectBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectName) === true) {
            throw new Error("(errid:Watl000058)字段[期刊学科名称]不能为空(In 期刊学科)!(clsJournalSubjectBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectCategoryId) === true
            || pobjJournalSubjectEN.journalSubjectCategoryId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[期刊学科门类Id]不能为空(In 期刊学科)!(clsJournalSubjectBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectId) == false && (0, clsString_js_2.GetStrLen)(pobjJournalSubjectEN.journalSubjectId) > 4) {
            throw new Error("(errid:Watl000059)字段[期刊学科Id(journalSubjectId)]的长度不能超过4(In 期刊学科(JournalSubject))!值:$(pobjJournalSubjectEN.journalSubjectId)(clsJournalSubjectBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectCode) == false && (0, clsString_js_2.GetStrLen)(pobjJournalSubjectEN.journalSubjectCode) > 100) {
            throw new Error("(errid:Watl000059)字段[期刊学科代码(journalSubjectCode)]的长度不能超过100(In 期刊学科(JournalSubject))!值:$(pobjJournalSubjectEN.journalSubjectCode)(clsJournalSubjectBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectName) == false && (0, clsString_js_2.GetStrLen)(pobjJournalSubjectEN.journalSubjectName) > 100) {
            throw new Error("(errid:Watl000059)字段[期刊学科名称(journalSubjectName)]的长度不能超过100(In 期刊学科(JournalSubject))!值:$(pobjJournalSubjectEN.journalSubjectName)(clsJournalSubjectBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectCategoryId) == false && (0, clsString_js_2.GetStrLen)(pobjJournalSubjectEN.journalSubjectCategoryId) > 4) {
            throw new Error("(errid:Watl000059)字段[期刊学科门类Id(journalSubjectCategoryId)]的长度不能超过4(In 期刊学科(JournalSubject))!值:$(pobjJournalSubjectEN.journalSubjectCategoryId)(clsJournalSubjectBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjJournalSubjectEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 期刊学科(JournalSubject))!值:$(pobjJournalSubjectEN.updDate)(clsJournalSubjectBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjJournalSubjectEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 期刊学科(JournalSubject))!值:$(pobjJournalSubjectEN.updUser)(clsJournalSubjectBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjJournalSubjectEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 期刊学科(JournalSubject))!值:$(pobjJournalSubjectEN.memo)(clsJournalSubjectBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectId) == false && undefined !== pobjJournalSubjectEN.journalSubjectId && clsString_js_1.tzDataType.isString(pobjJournalSubjectEN.journalSubjectId) === false) {
            throw new Error("(errid:Watl000060)字段[期刊学科Id(journalSubjectId)]的值:[$(pobjJournalSubjectEN.journalSubjectId)], 非法，应该为字符型(In 期刊学科(JournalSubject))!(clsJournalSubjectBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectCode) == false && undefined !== pobjJournalSubjectEN.journalSubjectCode && clsString_js_1.tzDataType.isString(pobjJournalSubjectEN.journalSubjectCode) === false) {
            throw new Error("(errid:Watl000060)字段[期刊学科代码(journalSubjectCode)]的值:[$(pobjJournalSubjectEN.journalSubjectCode)], 非法，应该为字符型(In 期刊学科(JournalSubject))!(clsJournalSubjectBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectName) == false && undefined !== pobjJournalSubjectEN.journalSubjectName && clsString_js_1.tzDataType.isString(pobjJournalSubjectEN.journalSubjectName) === false) {
            throw new Error("(errid:Watl000060)字段[期刊学科名称(journalSubjectName)]的值:[$(pobjJournalSubjectEN.journalSubjectName)], 非法，应该为字符型(In 期刊学科(JournalSubject))!(clsJournalSubjectBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectCategoryId) == false && undefined !== pobjJournalSubjectEN.journalSubjectCategoryId && clsString_js_1.tzDataType.isString(pobjJournalSubjectEN.journalSubjectCategoryId) === false) {
            throw new Error("(errid:Watl000060)字段[期刊学科门类Id(journalSubjectCategoryId)]的值:[$(pobjJournalSubjectEN.journalSubjectCategoryId)], 非法，应该为字符型(In 期刊学科(JournalSubject))!(clsJournalSubjectBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.updDate) == false && undefined !== pobjJournalSubjectEN.updDate && clsString_js_1.tzDataType.isString(pobjJournalSubjectEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjJournalSubjectEN.updDate)], 非法，应该为字符型(In 期刊学科(JournalSubject))!(clsJournalSubjectBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.updUser) == false && undefined !== pobjJournalSubjectEN.updUser && clsString_js_1.tzDataType.isString(pobjJournalSubjectEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjJournalSubjectEN.updUser)], 非法，应该为字符型(In 期刊学科(JournalSubject))!(clsJournalSubjectBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.memo) == false && undefined !== pobjJournalSubjectEN.memo && clsString_js_1.tzDataType.isString(pobjJournalSubjectEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjJournalSubjectEN.memo)], 非法，应该为字符型(In 期刊学科(JournalSubject))!(clsJournalSubjectBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjJournalSubjectEN.SetIsCheckProperty(true);
    }
    exports.JournalSubject_CheckPropertyNew = JournalSubject_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function JournalSubject_CheckProperty4Update(pobjJournalSubjectEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectId) == false && (0, clsString_js_2.GetStrLen)(pobjJournalSubjectEN.journalSubjectId) > 4) {
            throw new Error("(errid:Watl000062)字段[期刊学科Id(journalSubjectId)]的长度不能超过4(In 期刊学科(JournalSubject))!值:$(pobjJournalSubjectEN.journalSubjectId)(clsJournalSubjectBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectCode) == false && (0, clsString_js_2.GetStrLen)(pobjJournalSubjectEN.journalSubjectCode) > 100) {
            throw new Error("(errid:Watl000062)字段[期刊学科代码(journalSubjectCode)]的长度不能超过100(In 期刊学科(JournalSubject))!值:$(pobjJournalSubjectEN.journalSubjectCode)(clsJournalSubjectBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectName) == false && (0, clsString_js_2.GetStrLen)(pobjJournalSubjectEN.journalSubjectName) > 100) {
            throw new Error("(errid:Watl000062)字段[期刊学科名称(journalSubjectName)]的长度不能超过100(In 期刊学科(JournalSubject))!值:$(pobjJournalSubjectEN.journalSubjectName)(clsJournalSubjectBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectCategoryId) == false && (0, clsString_js_2.GetStrLen)(pobjJournalSubjectEN.journalSubjectCategoryId) > 4) {
            throw new Error("(errid:Watl000062)字段[期刊学科门类Id(journalSubjectCategoryId)]的长度不能超过4(In 期刊学科(JournalSubject))!值:$(pobjJournalSubjectEN.journalSubjectCategoryId)(clsJournalSubjectBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjJournalSubjectEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 期刊学科(JournalSubject))!值:$(pobjJournalSubjectEN.updDate)(clsJournalSubjectBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjJournalSubjectEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 期刊学科(JournalSubject))!值:$(pobjJournalSubjectEN.updUser)(clsJournalSubjectBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjJournalSubjectEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 期刊学科(JournalSubject))!值:$(pobjJournalSubjectEN.memo)(clsJournalSubjectBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectId) == false && undefined !== pobjJournalSubjectEN.journalSubjectId && clsString_js_1.tzDataType.isString(pobjJournalSubjectEN.journalSubjectId) === false) {
            throw new Error("(errid:Watl000063)字段[期刊学科Id(journalSubjectId)]的值:[$(pobjJournalSubjectEN.journalSubjectId)], 非法，应该为字符型(In 期刊学科(JournalSubject))!(clsJournalSubjectBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectCode) == false && undefined !== pobjJournalSubjectEN.journalSubjectCode && clsString_js_1.tzDataType.isString(pobjJournalSubjectEN.journalSubjectCode) === false) {
            throw new Error("(errid:Watl000063)字段[期刊学科代码(journalSubjectCode)]的值:[$(pobjJournalSubjectEN.journalSubjectCode)], 非法，应该为字符型(In 期刊学科(JournalSubject))!(clsJournalSubjectBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectName) == false && undefined !== pobjJournalSubjectEN.journalSubjectName && clsString_js_1.tzDataType.isString(pobjJournalSubjectEN.journalSubjectName) === false) {
            throw new Error("(errid:Watl000063)字段[期刊学科名称(journalSubjectName)]的值:[$(pobjJournalSubjectEN.journalSubjectName)], 非法，应该为字符型(In 期刊学科(JournalSubject))!(clsJournalSubjectBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectCategoryId) == false && undefined !== pobjJournalSubjectEN.journalSubjectCategoryId && clsString_js_1.tzDataType.isString(pobjJournalSubjectEN.journalSubjectCategoryId) === false) {
            throw new Error("(errid:Watl000063)字段[期刊学科门类Id(journalSubjectCategoryId)]的值:[$(pobjJournalSubjectEN.journalSubjectCategoryId)], 非法，应该为字符型(In 期刊学科(JournalSubject))!(clsJournalSubjectBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.updDate) == false && undefined !== pobjJournalSubjectEN.updDate && clsString_js_1.tzDataType.isString(pobjJournalSubjectEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjJournalSubjectEN.updDate)], 非法，应该为字符型(In 期刊学科(JournalSubject))!(clsJournalSubjectBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.updUser) == false && undefined !== pobjJournalSubjectEN.updUser && clsString_js_1.tzDataType.isString(pobjJournalSubjectEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjJournalSubjectEN.updUser)], 非法，应该为字符型(In 期刊学科(JournalSubject))!(clsJournalSubjectBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.memo) == false && undefined !== pobjJournalSubjectEN.memo && clsString_js_1.tzDataType.isString(pobjJournalSubjectEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjJournalSubjectEN.memo)], 非法，应该为字符型(In 期刊学科(JournalSubject))!(clsJournalSubjectBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjJournalSubjectEN.journalSubjectId) === true
            || pobjJournalSubjectEN.journalSubjectId.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[期刊学科Id]不能为空(In 期刊学科)!(clsJournalSubjectBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjJournalSubjectEN.SetIsCheckProperty(true);
    }
    exports.JournalSubject_CheckProperty4Update = JournalSubject_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function JournalSubject_GetJSONStrByObj(pobjJournalSubjectEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjJournalSubjectEN.sf_UpdFldSetStr = pobjJournalSubjectEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjJournalSubjectEN);
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
    exports.JournalSubject_GetJSONStrByObj = JournalSubject_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function JournalSubject_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrJournalSubjectObjLst = new Array();
        if (strJSON === "") {
            return arrJournalSubjectObjLst;
        }
        try {
            arrJournalSubjectObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrJournalSubjectObjLst;
        }
        return arrJournalSubjectObjLst;
    }
    exports.JournalSubject_GetObjLstByJSONStr = JournalSubject_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrJournalSubjectObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function JournalSubject_GetObjLstByJSONObjLst(arrJournalSubjectObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrJournalSubjectObjLst = new Array();
        for (const objInFor of arrJournalSubjectObjLstS) {
            const obj1 = JournalSubject_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrJournalSubjectObjLst.push(obj1);
        }
        return arrJournalSubjectObjLst;
    }
    exports.JournalSubject_GetObjLstByJSONObjLst = JournalSubject_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function JournalSubject_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjJournalSubjectEN = new clsJournalSubjectEN_js_1.clsJournalSubjectEN();
        if (strJSON === "") {
            return pobjJournalSubjectEN;
        }
        try {
            pobjJournalSubjectEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjJournalSubjectEN;
        }
        return pobjJournalSubjectEN;
    }
    exports.JournalSubject_GetObjByJSONStr = JournalSubject_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function JournalSubject_GetCombineCondition(objJournalSubject_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objJournalSubject_Cond.dicFldComparisonOp, clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectId) == true) {
            const strComparisonOp_JournalSubjectId = objJournalSubject_Cond.dicFldComparisonOp[clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectId, objJournalSubject_Cond.journalSubjectId, strComparisonOp_JournalSubjectId);
        }
        if (Object.prototype.hasOwnProperty.call(objJournalSubject_Cond.dicFldComparisonOp, clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectCode) == true) {
            const strComparisonOp_JournalSubjectCode = objJournalSubject_Cond.dicFldComparisonOp[clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectCode];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectCode, objJournalSubject_Cond.journalSubjectCode, strComparisonOp_JournalSubjectCode);
        }
        if (Object.prototype.hasOwnProperty.call(objJournalSubject_Cond.dicFldComparisonOp, clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectName) == true) {
            const strComparisonOp_JournalSubjectName = objJournalSubject_Cond.dicFldComparisonOp[clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectName, objJournalSubject_Cond.journalSubjectName, strComparisonOp_JournalSubjectName);
        }
        if (Object.prototype.hasOwnProperty.call(objJournalSubject_Cond.dicFldComparisonOp, clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectCategoryId) == true) {
            const strComparisonOp_JournalSubjectCategoryId = objJournalSubject_Cond.dicFldComparisonOp[clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectCategoryId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectCategoryId, objJournalSubject_Cond.journalSubjectCategoryId, strComparisonOp_JournalSubjectCategoryId);
        }
        if (Object.prototype.hasOwnProperty.call(objJournalSubject_Cond.dicFldComparisonOp, clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objJournalSubject_Cond.dicFldComparisonOp[clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_UpdDate, objJournalSubject_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objJournalSubject_Cond.dicFldComparisonOp, clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objJournalSubject_Cond.dicFldComparisonOp[clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_UpdUser, objJournalSubject_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objJournalSubject_Cond.dicFldComparisonOp, clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_Memo) == true) {
            const strComparisonOp_Memo = objJournalSubject_Cond.dicFldComparisonOp[clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_Memo, objJournalSubject_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.JournalSubject_GetCombineCondition = JournalSubject_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--JournalSubject(期刊学科),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strJournalSubjectCategoryId: 期刊学科门类Id(要求唯一的字段)
    * @param strJournalSubjectName: 期刊学科名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function JournalSubject_GetUniCondStr_JournalSubjectCategoryId_JournalSubjectName(objJournalSubjectEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and JournalSubjectCategoryId = '{0}'", objJournalSubjectEN.journalSubjectCategoryId);
        strWhereCond += (0, clsString_js_2.Format)(" and JournalSubjectName = '{0}'", objJournalSubjectEN.journalSubjectName);
        return strWhereCond;
    }
    exports.JournalSubject_GetUniCondStr_JournalSubjectCategoryId_JournalSubjectName = JournalSubject_GetUniCondStr_JournalSubjectCategoryId_JournalSubjectName;
    /**
    *获取唯一性条件串(Uniqueness)--JournalSubject(期刊学科),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strJournalSubjectCategoryId: 期刊学科门类Id(要求唯一的字段)
    * @param strJournalSubjectName: 期刊学科名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function JournalSubject_GetUniCondStr4Update_JournalSubjectCategoryId_JournalSubjectName(objJournalSubjectEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and JournalSubjectId <> '{0}'", objJournalSubjectEN.journalSubjectId);
        strWhereCond += (0, clsString_js_2.Format)(" and JournalSubjectCategoryId = '{0}'", objJournalSubjectEN.journalSubjectCategoryId);
        strWhereCond += (0, clsString_js_2.Format)(" and JournalSubjectName = '{0}'", objJournalSubjectEN.journalSubjectName);
        return strWhereCond;
    }
    exports.JournalSubject_GetUniCondStr4Update_JournalSubjectCategoryId_JournalSubjectName = JournalSubject_GetUniCondStr4Update_JournalSubjectCategoryId_JournalSubjectName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objJournalSubjectENS:源对象
     * @param objJournalSubjectENT:目标对象
    */
    function JournalSubject_CopyObjTo(objJournalSubjectENS, objJournalSubjectENT) {
        objJournalSubjectENT.journalSubjectId = objJournalSubjectENS.journalSubjectId; //期刊学科Id
        objJournalSubjectENT.journalSubjectCode = objJournalSubjectENS.journalSubjectCode; //期刊学科代码
        objJournalSubjectENT.journalSubjectName = objJournalSubjectENS.journalSubjectName; //期刊学科名称
        objJournalSubjectENT.journalSubjectCategoryId = objJournalSubjectENS.journalSubjectCategoryId; //期刊学科门类Id
        objJournalSubjectENT.updDate = objJournalSubjectENS.updDate; //修改日期
        objJournalSubjectENT.updUser = objJournalSubjectENS.updUser; //修改人
        objJournalSubjectENT.memo = objJournalSubjectENS.memo; //备注
        objJournalSubjectENT.sf_UpdFldSetStr = objJournalSubjectENS.updFldString; //sf_UpdFldSetStr
    }
    exports.JournalSubject_CopyObjTo = JournalSubject_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objJournalSubjectENS:源对象
     * @param objJournalSubjectENT:目标对象
    */
    function JournalSubject_GetObjFromJsonObj(objJournalSubjectENS) {
        const objJournalSubjectENT = new clsJournalSubjectEN_js_1.clsJournalSubjectEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objJournalSubjectENT, objJournalSubjectENS);
        return objJournalSubjectENT;
    }
    exports.JournalSubject_GetObjFromJsonObj = JournalSubject_GetObjFromJsonObj;
});
