/**
* 类名:clsge_DifficultyLevelWApi
* 表名:ge_DifficultyLevel(01120905)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/14 18:42:02
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:系统设置(SystemSet)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/SystemSet_Share/clsge_DifficultyLevelEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ge_DifficultyLevel_GetObjFromJsonObj = exports.ge_DifficultyLevel_CopyObjTo = exports.ge_DifficultyLevel_GetUniCondStr4Update_DifficultyLevelName = exports.ge_DifficultyLevel_GetUniCondStr_DifficultyLevelName = exports.ge_DifficultyLevel_GetCombineCondition = exports.ge_DifficultyLevel_GetObjByJSONStr = exports.ge_DifficultyLevel_GetObjLstByJSONObjLst = exports.ge_DifficultyLevel_GetObjLstByJSONStr = exports.ge_DifficultyLevel_GetJSONStrByObj = exports.ge_DifficultyLevel_CheckProperty4Update = exports.ge_DifficultyLevel_CheckPropertyNew = exports.ge_DifficultyLevel_BindDdl_DifficultyLevelIdInDiv_Cache = exports.ge_DifficultyLevel_ReFreshThisCache = exports.ge_DifficultyLevel_ReFreshCache = exports.ge_DifficultyLevel_GetWebApiUrl = exports.ge_DifficultyLevel_GetMaxStrIdByPrefix = exports.ge_DifficultyLevel_GetMaxStrIdAsync = exports.ge_DifficultyLevel_GetRecCountByCond_Cache = exports.ge_DifficultyLevel_GetRecCountByCondAsync = exports.ge_DifficultyLevel_IsExistAsync = exports.ge_DifficultyLevel_IsExist_Cache = exports.ge_DifficultyLevel_IsExist = exports.ge_DifficultyLevel_IsExistRecordAsync = exports.ge_DifficultyLevel_IsExistRecord_Cache = exports.ge_DifficultyLevel_UpdateWithConditionAsync = exports.ge_DifficultyLevel_UpdateRecordAsync = exports.ge_DifficultyLevel_AddNewRecordWithReturnKey = exports.ge_DifficultyLevel_AddNewRecordWithReturnKeyAsync = exports.ge_DifficultyLevel_AddNewRecordWithMaxIdAsync = exports.ge_DifficultyLevel_AddNewRecordAsync = exports.ge_DifficultyLevel_Delge_DifficultyLevelsByCondAsync = exports.ge_DifficultyLevel_Delge_DifficultyLevelsAsync = exports.ge_DifficultyLevel_DelRecordAsync = exports.ge_DifficultyLevel_GetObjLstByPagerAsync = exports.ge_DifficultyLevel_GetObjLstByPager_Cache = exports.ge_DifficultyLevel_GetObjLstByRange = exports.ge_DifficultyLevel_GetObjLstByRangeAsync = exports.ge_DifficultyLevel_GetTopObjLstAsync = exports.ge_DifficultyLevel_GetObjLstByDifficultyLevelIdLst_Cache = exports.ge_DifficultyLevel_GetObjLstByDifficultyLevelIdLstAsync = exports.ge_DifficultyLevel_GetSubObjLst_Cache = exports.ge_DifficultyLevel_GetObjLst_PureCache = exports.ge_DifficultyLevel_GetObjLst_Cache = exports.ge_DifficultyLevel_GetObjLst_sessionStorage_PureCache = exports.ge_DifficultyLevel_GetObjLst_sessionStorage = exports.ge_DifficultyLevel_GetObjLstAsync = exports.ge_DifficultyLevel_GetObjLst_localStorage_PureCache = exports.ge_DifficultyLevel_GetObjLst_localStorage = exports.ge_DifficultyLevel_GetObjLst_ClientCache = exports.ge_DifficultyLevel_GetFirstObjAsync = exports.ge_DifficultyLevel_GetFirstID = exports.ge_DifficultyLevel_GetFirstIDAsync = exports.ge_DifficultyLevel_funcKey = exports.ge_DifficultyLevel_FilterFunByKey = exports.ge_DifficultyLevel_SortFunByKey = exports.ge_DifficultyLevel_SortFun_Defa_2Fld = exports.ge_DifficultyLevel_SortFun_Defa = exports.ge_DifficultyLevel_func = exports.ge_DifficultyLevel_GetNameByDifficultyLevelId_Cache = exports.ge_DifficultyLevel_UpdateObjInLst_Cache = exports.ge_DifficultyLevel_GetObjByDifficultyLevelId_localStorage = exports.ge_DifficultyLevel_GetObjByDifficultyLevelId_Cache = exports.ge_DifficultyLevel_GetObjByDifficultyLevelIdAsync = exports.ge_DifficultyLevel_ConstructorName = exports.ge_DifficultyLevel_Controller = void 0;
    /**
     * 难度等级表(ge_DifficultyLevel)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月14日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsge_DifficultyLevelEN_js_1 = require("../../L0_Entity/SystemSet_Share/clsge_DifficultyLevelEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.ge_DifficultyLevel_Controller = "ge_DifficultyLevelApi";
    exports.ge_DifficultyLevel_ConstructorName = "ge_DifficultyLevel";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strDifficultyLevelId:关键字
    * @returns 对象
    **/
    async function ge_DifficultyLevel_GetObjByDifficultyLevelIdAsync(strDifficultyLevelId) {
        const strThisFuncName = "GetObjByDifficultyLevelIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strDifficultyLevelId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strDifficultyLevelId]不能为空！(In clsge_DifficultyLevelWApi.GetObjByDifficultyLevelIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strDifficultyLevelId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strDifficultyLevelId]的长度:[{0}]不正确！(clsge_DifficultyLevelWApi.GetObjByDifficultyLevelIdAsync)", strDifficultyLevelId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByDifficultyLevelId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strDifficultyLevelId": strDifficultyLevelId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objge_DifficultyLevel = ge_DifficultyLevel_GetObjFromJsonObj(returnObj);
                return objge_DifficultyLevel;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_GetObjByDifficultyLevelIdAsync = ge_DifficultyLevel_GetObjByDifficultyLevelIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strDifficultyLevelId:所给的关键字
     * @returns 对象
    */
    async function ge_DifficultyLevel_GetObjByDifficultyLevelId_Cache(strDifficultyLevelId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByDifficultyLevelId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strDifficultyLevelId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strDifficultyLevelId]不能为空！(In clsge_DifficultyLevelWApi.GetObjByDifficultyLevelId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strDifficultyLevelId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strDifficultyLevelId]的长度:[{0}]不正确！(clsge_DifficultyLevelWApi.GetObjByDifficultyLevelId_Cache)", strDifficultyLevelId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrge_DifficultyLevelObjLst_Cache = await ge_DifficultyLevel_GetObjLst_Cache();
        try {
            const arrge_DifficultyLevel_Sel = arrge_DifficultyLevelObjLst_Cache.filter(x => x.difficultyLevelId == strDifficultyLevelId);
            let objge_DifficultyLevel;
            if (arrge_DifficultyLevel_Sel.length > 0) {
                objge_DifficultyLevel = arrge_DifficultyLevel_Sel[0];
                return objge_DifficultyLevel;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objge_DifficultyLevel_Const = await ge_DifficultyLevel_GetObjByDifficultyLevelIdAsync(strDifficultyLevelId);
                    if (objge_DifficultyLevel_Const != null) {
                        ge_DifficultyLevel_ReFreshThisCache();
                        return objge_DifficultyLevel_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strDifficultyLevelId, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.ge_DifficultyLevel_GetObjByDifficultyLevelId_Cache = ge_DifficultyLevel_GetObjByDifficultyLevelId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strDifficultyLevelId:所给的关键字
     * @returns 对象
    */
    async function ge_DifficultyLevel_GetObjByDifficultyLevelId_localStorage(strDifficultyLevelId) {
        const strThisFuncName = "GetObjByDifficultyLevelId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strDifficultyLevelId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strDifficultyLevelId]不能为空！(In clsge_DifficultyLevelWApi.GetObjByDifficultyLevelId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strDifficultyLevelId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strDifficultyLevelId]的长度:[{0}]不正确！(clsge_DifficultyLevelWApi.GetObjByDifficultyLevelId_localStorage)", strDifficultyLevelId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN._CurrTabName, strDifficultyLevelId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objge_DifficultyLevel_Cache = JSON.parse(strTempObj);
            return objge_DifficultyLevel_Cache;
        }
        try {
            const objge_DifficultyLevel = await ge_DifficultyLevel_GetObjByDifficultyLevelIdAsync(strDifficultyLevelId);
            if (objge_DifficultyLevel != null) {
                localStorage.setItem(strKey, JSON.stringify(objge_DifficultyLevel));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objge_DifficultyLevel;
            }
            return objge_DifficultyLevel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strDifficultyLevelId, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.ge_DifficultyLevel_GetObjByDifficultyLevelId_localStorage = ge_DifficultyLevel_GetObjByDifficultyLevelId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objge_DifficultyLevel:所给的对象
     * @returns 对象
    */
    async function ge_DifficultyLevel_UpdateObjInLst_Cache(objge_DifficultyLevel) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrge_DifficultyLevelObjLst_Cache = await ge_DifficultyLevel_GetObjLst_Cache();
            const obj = arrge_DifficultyLevelObjLst_Cache.find(x => x.difficultyLevelName == objge_DifficultyLevel.difficultyLevelName);
            if (obj != null) {
                objge_DifficultyLevel.difficultyLevelId = obj.difficultyLevelId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objge_DifficultyLevel);
            }
            else {
                arrge_DifficultyLevelObjLst_Cache.push(objge_DifficultyLevel);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.ge_DifficultyLevel_UpdateObjInLst_Cache = ge_DifficultyLevel_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strDifficultyLevelId:所给的关键字
     * @returns 对象
    */
    async function ge_DifficultyLevel_GetNameByDifficultyLevelId_Cache(strDifficultyLevelId) {
        const strThisFuncName = "GetNameByDifficultyLevelId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strDifficultyLevelId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strDifficultyLevelId]不能为空！(In clsge_DifficultyLevelWApi.GetNameByDifficultyLevelId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strDifficultyLevelId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strDifficultyLevelId]的长度:[{0}]不正确！(clsge_DifficultyLevelWApi.GetNameByDifficultyLevelId_Cache)", strDifficultyLevelId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrge_DifficultyLevelObjLst_Cache = await ge_DifficultyLevel_GetObjLst_Cache();
        if (arrge_DifficultyLevelObjLst_Cache == null)
            return "";
        try {
            const arrge_DifficultyLevel_Sel = arrge_DifficultyLevelObjLst_Cache.filter(x => x.difficultyLevelId == strDifficultyLevelId);
            let objge_DifficultyLevel;
            if (arrge_DifficultyLevel_Sel.length > 0) {
                objge_DifficultyLevel = arrge_DifficultyLevel_Sel[0];
                return objge_DifficultyLevel.difficultyLevelName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strDifficultyLevelId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.ge_DifficultyLevel_GetNameByDifficultyLevelId_Cache = ge_DifficultyLevel_GetNameByDifficultyLevelId_Cache;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function ge_DifficultyLevel_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strDifficultyLevelId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objge_DifficultyLevel = await ge_DifficultyLevel_GetObjByDifficultyLevelId_Cache(strDifficultyLevelId);
        if (objge_DifficultyLevel == null)
            return "";
        if (objge_DifficultyLevel.GetFldValue(strOutFldName) == null)
            return "";
        return objge_DifficultyLevel.GetFldValue(strOutFldName).toString();
    }
    exports.ge_DifficultyLevel_func = ge_DifficultyLevel_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ge_DifficultyLevel_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.difficultyLevelId.localeCompare(b.difficultyLevelId);
    }
    exports.ge_DifficultyLevel_SortFun_Defa = ge_DifficultyLevel_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ge_DifficultyLevel_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.difficultyLevelName == b.difficultyLevelName)
            return a.difficultyLevelENName.localeCompare(b.difficultyLevelENName);
        else
            return a.difficultyLevelName.localeCompare(b.difficultyLevelName);
    }
    exports.ge_DifficultyLevel_SortFun_Defa_2Fld = ge_DifficultyLevel_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ge_DifficultyLevel_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelId:
                    return (a, b) => {
                        return a.difficultyLevelId.localeCompare(b.difficultyLevelId);
                    };
                case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelName:
                    return (a, b) => {
                        if (a.difficultyLevelName == null)
                            return -1;
                        if (b.difficultyLevelName == null)
                            return 1;
                        return a.difficultyLevelName.localeCompare(b.difficultyLevelName);
                    };
                case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelENName:
                    return (a, b) => {
                        if (a.difficultyLevelENName == null)
                            return -1;
                        if (b.difficultyLevelENName == null)
                            return 1;
                        return a.difficultyLevelENName.localeCompare(b.difficultyLevelENName);
                    };
                case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ge_DifficultyLevel]中不存在！(in ${exports.ge_DifficultyLevel_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelId:
                    return (a, b) => {
                        return b.difficultyLevelId.localeCompare(a.difficultyLevelId);
                    };
                case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelName:
                    return (a, b) => {
                        if (b.difficultyLevelName == null)
                            return -1;
                        if (a.difficultyLevelName == null)
                            return 1;
                        return b.difficultyLevelName.localeCompare(a.difficultyLevelName);
                    };
                case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelENName:
                    return (a, b) => {
                        if (b.difficultyLevelENName == null)
                            return -1;
                        if (a.difficultyLevelENName == null)
                            return 1;
                        return b.difficultyLevelENName.localeCompare(a.difficultyLevelENName);
                    };
                case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ge_DifficultyLevel]中不存在！(in ${exports.ge_DifficultyLevel_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ge_DifficultyLevel_SortFunByKey = ge_DifficultyLevel_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ge_DifficultyLevel_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelId:
                return (obj) => {
                    return obj.difficultyLevelId === value;
                };
            case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelName:
                return (obj) => {
                    return obj.difficultyLevelName === value;
                };
            case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelENName:
                return (obj) => {
                    return obj.difficultyLevelENName === value;
                };
            case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ge_DifficultyLevel]中不存在！(in ${exports.ge_DifficultyLevel_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ge_DifficultyLevel_FilterFunByKey = ge_DifficultyLevel_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function ge_DifficultyLevel_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrge_DifficultyLevel = await ge_DifficultyLevel_GetObjLst_Cache();
        if (arrge_DifficultyLevel == null)
            return [];
        let arrge_DifficultyLevel_Sel = arrge_DifficultyLevel;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrge_DifficultyLevel_Sel.length == 0)
            return [];
        return arrge_DifficultyLevel_Sel.map(x => x.difficultyLevelId);
    }
    exports.ge_DifficultyLevel_funcKey = ge_DifficultyLevel_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ge_DifficultyLevel_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_GetFirstIDAsync = ge_DifficultyLevel_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ge_DifficultyLevel_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_GetFirstID = ge_DifficultyLevel_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ge_DifficultyLevel_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
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
                const objge_DifficultyLevel = ge_DifficultyLevel_GetObjFromJsonObj(returnObj);
                return objge_DifficultyLevel;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_GetFirstObjAsync = ge_DifficultyLevel_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ge_DifficultyLevel_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrge_DifficultyLevelExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrge_DifficultyLevelObjLst_T = ge_DifficultyLevel_GetObjLstByJSONObjLst(arrge_DifficultyLevelExObjLst_Cache);
            return arrge_DifficultyLevelObjLst_T;
        }
        try {
            const arrge_DifficultyLevelExObjLst = await ge_DifficultyLevel_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrge_DifficultyLevelExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrge_DifficultyLevelExObjLst.length);
            console.log(strInfo);
            return arrge_DifficultyLevelExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ge_DifficultyLevel_GetObjLst_ClientCache = ge_DifficultyLevel_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ge_DifficultyLevel_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrge_DifficultyLevelExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrge_DifficultyLevelObjLst_T = ge_DifficultyLevel_GetObjLstByJSONObjLst(arrge_DifficultyLevelExObjLst_Cache);
            return arrge_DifficultyLevelObjLst_T;
        }
        try {
            const arrge_DifficultyLevelExObjLst = await ge_DifficultyLevel_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrge_DifficultyLevelExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrge_DifficultyLevelExObjLst.length);
            console.log(strInfo);
            return arrge_DifficultyLevelExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ge_DifficultyLevel_GetObjLst_localStorage = ge_DifficultyLevel_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ge_DifficultyLevel_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrge_DifficultyLevelObjLst_Cache = JSON.parse(strTempObjLst);
            return arrge_DifficultyLevelObjLst_Cache;
        }
        else
            return null;
    }
    exports.ge_DifficultyLevel_GetObjLst_localStorage_PureCache = ge_DifficultyLevel_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ge_DifficultyLevel_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ge_DifficultyLevel_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_GetObjLstAsync = ge_DifficultyLevel_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ge_DifficultyLevel_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrge_DifficultyLevelExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrge_DifficultyLevelObjLst_T = ge_DifficultyLevel_GetObjLstByJSONObjLst(arrge_DifficultyLevelExObjLst_Cache);
            return arrge_DifficultyLevelObjLst_T;
        }
        try {
            const arrge_DifficultyLevelExObjLst = await ge_DifficultyLevel_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrge_DifficultyLevelExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrge_DifficultyLevelExObjLst.length);
            console.log(strInfo);
            return arrge_DifficultyLevelExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ge_DifficultyLevel_GetObjLst_sessionStorage = ge_DifficultyLevel_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ge_DifficultyLevel_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrge_DifficultyLevelObjLst_Cache = JSON.parse(strTempObjLst);
            return arrge_DifficultyLevelObjLst_Cache;
        }
        else
            return null;
    }
    exports.ge_DifficultyLevel_GetObjLst_sessionStorage_PureCache = ge_DifficultyLevel_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ge_DifficultyLevel_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrge_DifficultyLevelObjLst_Cache;
        switch (clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.CacheModeId) {
            case "04": //sessionStorage
                arrge_DifficultyLevelObjLst_Cache = await ge_DifficultyLevel_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrge_DifficultyLevelObjLst_Cache = await ge_DifficultyLevel_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrge_DifficultyLevelObjLst_Cache = await ge_DifficultyLevel_GetObjLst_ClientCache();
                break;
            default:
                arrge_DifficultyLevelObjLst_Cache = await ge_DifficultyLevel_GetObjLst_ClientCache();
                break;
        }
        const arrge_DifficultyLevelObjLst = ge_DifficultyLevel_GetObjLstByJSONObjLst(arrge_DifficultyLevelObjLst_Cache);
        return arrge_DifficultyLevelObjLst_Cache;
    }
    exports.ge_DifficultyLevel_GetObjLst_Cache = ge_DifficultyLevel_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ge_DifficultyLevel_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrge_DifficultyLevelObjLst_Cache;
        switch (clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.CacheModeId) {
            case "04": //sessionStorage
                arrge_DifficultyLevelObjLst_Cache = await ge_DifficultyLevel_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrge_DifficultyLevelObjLst_Cache = await ge_DifficultyLevel_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrge_DifficultyLevelObjLst_Cache = null;
                break;
            default:
                arrge_DifficultyLevelObjLst_Cache = null;
                break;
        }
        return arrge_DifficultyLevelObjLst_Cache;
    }
    exports.ge_DifficultyLevel_GetObjLst_PureCache = ge_DifficultyLevel_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrDifficultyLevelId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ge_DifficultyLevel_GetSubObjLst_Cache(objge_DifficultyLevel_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrge_DifficultyLevelObjLst_Cache = await ge_DifficultyLevel_GetObjLst_Cache();
        let arrge_DifficultyLevel_Sel = arrge_DifficultyLevelObjLst_Cache;
        if (objge_DifficultyLevel_Cond.sf_FldComparisonOp == null || objge_DifficultyLevel_Cond.sf_FldComparisonOp == "")
            return arrge_DifficultyLevel_Sel;
        const dicFldComparisonOp = JSON.parse(objge_DifficultyLevel_Cond.sf_FldComparisonOp);
        //console.log("clsge_DifficultyLevelWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objge_DifficultyLevel_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objge_DifficultyLevel_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrge_DifficultyLevel_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objge_DifficultyLevel_Cond), exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ge_DifficultyLevel_GetSubObjLst_Cache = ge_DifficultyLevel_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrDifficultyLevelId:关键字列表
    * @returns 对象列表
    **/
    async function ge_DifficultyLevel_GetObjLstByDifficultyLevelIdLstAsync(arrDifficultyLevelId) {
        const strThisFuncName = "GetObjLstByDifficultyLevelIdLstAsync";
        const strAction = "GetObjLstByDifficultyLevelIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrDifficultyLevelId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ge_DifficultyLevel_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_GetObjLstByDifficultyLevelIdLstAsync = ge_DifficultyLevel_GetObjLstByDifficultyLevelIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrDifficultyLevelIdLst:关键字列表
     * @returns 对象列表
    */
    async function ge_DifficultyLevel_GetObjLstByDifficultyLevelIdLst_Cache(arrDifficultyLevelIdLst) {
        const strThisFuncName = "GetObjLstByDifficultyLevelIdLst_Cache";
        try {
            const arrge_DifficultyLevelObjLst_Cache = await ge_DifficultyLevel_GetObjLst_Cache();
            const arrge_DifficultyLevel_Sel = arrge_DifficultyLevelObjLst_Cache.filter(x => arrDifficultyLevelIdLst.indexOf(x.difficultyLevelId) > -1);
            return arrge_DifficultyLevel_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrDifficultyLevelIdLst.join(","), exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.ge_DifficultyLevel_GetObjLstByDifficultyLevelIdLst_Cache = ge_DifficultyLevel_GetObjLstByDifficultyLevelIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ge_DifficultyLevel_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ge_DifficultyLevel_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_GetTopObjLstAsync = ge_DifficultyLevel_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ge_DifficultyLevel_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ge_DifficultyLevel_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_GetObjLstByRangeAsync = ge_DifficultyLevel_GetObjLstByRangeAsync;
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
    async function ge_DifficultyLevel_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_GetObjLstByRange = ge_DifficultyLevel_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function ge_DifficultyLevel_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrge_DifficultyLevelObjLst_Cache = await ge_DifficultyLevel_GetObjLst_Cache();
        if (arrge_DifficultyLevelObjLst_Cache.length == 0)
            return arrge_DifficultyLevelObjLst_Cache;
        let arrge_DifficultyLevel_Sel = arrge_DifficultyLevelObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objge_DifficultyLevel_Cond = new clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objge_DifficultyLevel_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsge_DifficultyLevelWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objge_DifficultyLevel_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrge_DifficultyLevel_Sel.length == 0)
                return arrge_DifficultyLevel_Sel;
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
                arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.sort(ge_DifficultyLevel_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.sort(objPagerPara.sortFun);
            }
            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.slice(intStart, intEnd);
            return arrge_DifficultyLevel_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ge_DifficultyLevel_GetObjLstByPager_Cache = ge_DifficultyLevel_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ge_DifficultyLevel_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ge_DifficultyLevel_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_GetObjLstByPagerAsync = ge_DifficultyLevel_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strDifficultyLevelId:关键字
    * @returns 获取删除的结果
    **/
    async function ge_DifficultyLevel_DelRecordAsync(strDifficultyLevelId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strDifficultyLevelId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_DelRecordAsync = ge_DifficultyLevel_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrDifficultyLevelId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ge_DifficultyLevel_Delge_DifficultyLevelsAsync(arrDifficultyLevelId) {
        const strThisFuncName = "Delge_DifficultyLevelsAsync";
        const strAction = "Delge_DifficultyLevels";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrDifficultyLevelId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_Delge_DifficultyLevelsAsync = ge_DifficultyLevel_Delge_DifficultyLevelsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ge_DifficultyLevel_Delge_DifficultyLevelsByCondAsync(strWhereCond) {
        const strThisFuncName = "Delge_DifficultyLevelsByCondAsync";
        const strAction = "Delge_DifficultyLevelsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_Delge_DifficultyLevelsByCondAsync = ge_DifficultyLevel_Delge_DifficultyLevelsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objge_DifficultyLevelEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ge_DifficultyLevel_AddNewRecordAsync(objge_DifficultyLevelEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objge_DifficultyLevelEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objge_DifficultyLevelEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_AddNewRecordAsync = ge_DifficultyLevel_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objge_DifficultyLevelEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ge_DifficultyLevel_AddNewRecordWithMaxIdAsync(objge_DifficultyLevelEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objge_DifficultyLevelEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_AddNewRecordWithMaxIdAsync = ge_DifficultyLevel_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objge_DifficultyLevelEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ge_DifficultyLevel_AddNewRecordWithReturnKeyAsync(objge_DifficultyLevelEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objge_DifficultyLevelEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_AddNewRecordWithReturnKeyAsync = ge_DifficultyLevel_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objge_DifficultyLevelEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ge_DifficultyLevel_AddNewRecordWithReturnKey(objge_DifficultyLevelEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objge_DifficultyLevelEN.difficultyLevelId === null || objge_DifficultyLevelEN.difficultyLevelId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objge_DifficultyLevelEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_AddNewRecordWithReturnKey = ge_DifficultyLevel_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objge_DifficultyLevelEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ge_DifficultyLevel_UpdateRecordAsync(objge_DifficultyLevelEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objge_DifficultyLevelEN.sf_UpdFldSetStr === undefined || objge_DifficultyLevelEN.sf_UpdFldSetStr === null || objge_DifficultyLevelEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objge_DifficultyLevelEN.difficultyLevelId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objge_DifficultyLevelEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_UpdateRecordAsync = ge_DifficultyLevel_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objge_DifficultyLevelEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ge_DifficultyLevel_UpdateWithConditionAsync(objge_DifficultyLevelEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objge_DifficultyLevelEN.sf_UpdFldSetStr === undefined || objge_DifficultyLevelEN.sf_UpdFldSetStr === null || objge_DifficultyLevelEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objge_DifficultyLevelEN.difficultyLevelId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
        objge_DifficultyLevelEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objge_DifficultyLevelEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_UpdateWithConditionAsync = ge_DifficultyLevel_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrDifficultyLevelId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ge_DifficultyLevel_IsExistRecord_Cache(objge_DifficultyLevel_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrge_DifficultyLevelObjLst_Cache = await ge_DifficultyLevel_GetObjLst_Cache();
        if (arrge_DifficultyLevelObjLst_Cache == null)
            return false;
        let arrge_DifficultyLevel_Sel = arrge_DifficultyLevelObjLst_Cache;
        if (objge_DifficultyLevel_Cond.sf_FldComparisonOp == null || objge_DifficultyLevel_Cond.sf_FldComparisonOp == "")
            return arrge_DifficultyLevel_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objge_DifficultyLevel_Cond.sf_FldComparisonOp);
        //console.log("clsge_DifficultyLevelWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objge_DifficultyLevel_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objge_DifficultyLevel_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrge_DifficultyLevel_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objge_DifficultyLevel_Cond), exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.ge_DifficultyLevel_IsExistRecord_Cache = ge_DifficultyLevel_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ge_DifficultyLevel_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_IsExistRecordAsync = ge_DifficultyLevel_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strDifficultyLevelId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ge_DifficultyLevel_IsExist(strDifficultyLevelId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "DifficultyLevelId": strDifficultyLevelId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_IsExist = ge_DifficultyLevel_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strDifficultyLevelId:所给的关键字
     * @returns 对象
    */
    async function ge_DifficultyLevel_IsExist_Cache(strDifficultyLevelId) {
        const strThisFuncName = "IsExist_Cache";
        const arrge_DifficultyLevelObjLst_Cache = await ge_DifficultyLevel_GetObjLst_Cache();
        if (arrge_DifficultyLevelObjLst_Cache == null)
            return false;
        try {
            const arrge_DifficultyLevel_Sel = arrge_DifficultyLevelObjLst_Cache.filter(x => x.difficultyLevelId == strDifficultyLevelId);
            if (arrge_DifficultyLevel_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strDifficultyLevelId, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.ge_DifficultyLevel_IsExist_Cache = ge_DifficultyLevel_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strDifficultyLevelId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ge_DifficultyLevel_IsExistAsync(strDifficultyLevelId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strDifficultyLevelId": strDifficultyLevelId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_IsExistAsync = ge_DifficultyLevel_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ge_DifficultyLevel_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_GetRecCountByCondAsync = ge_DifficultyLevel_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objge_DifficultyLevel_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function ge_DifficultyLevel_GetRecCountByCond_Cache(objge_DifficultyLevel_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrge_DifficultyLevelObjLst_Cache = await ge_DifficultyLevel_GetObjLst_Cache();
        if (arrge_DifficultyLevelObjLst_Cache == null)
            return 0;
        let arrge_DifficultyLevel_Sel = arrge_DifficultyLevelObjLst_Cache;
        if (objge_DifficultyLevel_Cond.sf_FldComparisonOp == null || objge_DifficultyLevel_Cond.sf_FldComparisonOp == "")
            return arrge_DifficultyLevel_Sel.length;
        const dicFldComparisonOp = JSON.parse(objge_DifficultyLevel_Cond.sf_FldComparisonOp);
        //console.log("clsge_DifficultyLevelWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objge_DifficultyLevel_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objge_DifficultyLevel_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrge_DifficultyLevel_Sel = arrge_DifficultyLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrge_DifficultyLevel_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objge_DifficultyLevel_Cond), exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.ge_DifficultyLevel_GetRecCountByCond_Cache = ge_DifficultyLevel_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function ge_DifficultyLevel_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_GetMaxStrIdAsync = ge_DifficultyLevel_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function ge_DifficultyLevel_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_DifficultyLevel_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_DifficultyLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_DifficultyLevel_GetMaxStrIdByPrefix = ge_DifficultyLevel_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ge_DifficultyLevel_GetWebApiUrl(strController, strAction) {
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
    exports.ge_DifficultyLevel_GetWebApiUrl = ge_DifficultyLevel_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function ge_DifficultyLevel_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN._CurrTabName;
        switch (clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.CacheModeId) {
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
    exports.ge_DifficultyLevel_ReFreshCache = ge_DifficultyLevel_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function ge_DifficultyLevel_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN._CurrTabName;
            switch (clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.CacheModeId) {
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
    exports.ge_DifficultyLevel_ReFreshThisCache = ge_DifficultyLevel_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function ge_DifficultyLevel_BindDdl_DifficultyLevelIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_DifficultyLevelIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_DifficultyLevelIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_DifficultyLevelIdInDiv_Cache");
        const arrObjLst_Sel = await ge_DifficultyLevel_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelId, clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelName, "难度等级表");
    }
    exports.ge_DifficultyLevel_BindDdl_DifficultyLevelIdInDiv_Cache = ge_DifficultyLevel_BindDdl_DifficultyLevelIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ge_DifficultyLevel_CheckPropertyNew(pobjge_DifficultyLevelEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.difficultyLevelId) == false && (0, clsString_js_2.GetStrLen)(pobjge_DifficultyLevelEN.difficultyLevelId) > 2) {
            throw new Error("(errid:Watl000059)字段[难度等级Id(difficultyLevelId)]的长度不能超过2(In 难度等级表(ge_DifficultyLevel))!值:$(pobjge_DifficultyLevelEN.difficultyLevelId)(clsge_DifficultyLevelBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.difficultyLevelName) == false && (0, clsString_js_2.GetStrLen)(pobjge_DifficultyLevelEN.difficultyLevelName) > 1000) {
            throw new Error("(errid:Watl000059)字段[难度等级名称(difficultyLevelName)]的长度不能超过1000(In 难度等级表(ge_DifficultyLevel))!值:$(pobjge_DifficultyLevelEN.difficultyLevelName)(clsge_DifficultyLevelBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.difficultyLevelENName) == false && (0, clsString_js_2.GetStrLen)(pobjge_DifficultyLevelEN.difficultyLevelENName) > 1000) {
            throw new Error("(errid:Watl000059)字段[难度等级英文名(difficultyLevelENName)]的长度不能超过1000(In 难度等级表(ge_DifficultyLevel))!值:$(pobjge_DifficultyLevelEN.difficultyLevelENName)(clsge_DifficultyLevelBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjge_DifficultyLevelEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 难度等级表(ge_DifficultyLevel))!值:$(pobjge_DifficultyLevelEN.updDate)(clsge_DifficultyLevelBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjge_DifficultyLevelEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 难度等级表(ge_DifficultyLevel))!值:$(pobjge_DifficultyLevelEN.updUser)(clsge_DifficultyLevelBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjge_DifficultyLevelEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 难度等级表(ge_DifficultyLevel))!值:$(pobjge_DifficultyLevelEN.memo)(clsge_DifficultyLevelBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.difficultyLevelId) == false && undefined !== pobjge_DifficultyLevelEN.difficultyLevelId && clsString_js_1.tzDataType.isString(pobjge_DifficultyLevelEN.difficultyLevelId) === false) {
            throw new Error("(errid:Watl000060)字段[难度等级Id(difficultyLevelId)]的值:[$(pobjge_DifficultyLevelEN.difficultyLevelId)], 非法，应该为字符型(In 难度等级表(ge_DifficultyLevel))!(clsge_DifficultyLevelBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.difficultyLevelName) == false && undefined !== pobjge_DifficultyLevelEN.difficultyLevelName && clsString_js_1.tzDataType.isString(pobjge_DifficultyLevelEN.difficultyLevelName) === false) {
            throw new Error("(errid:Watl000060)字段[难度等级名称(difficultyLevelName)]的值:[$(pobjge_DifficultyLevelEN.difficultyLevelName)], 非法，应该为字符型(In 难度等级表(ge_DifficultyLevel))!(clsge_DifficultyLevelBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.difficultyLevelENName) == false && undefined !== pobjge_DifficultyLevelEN.difficultyLevelENName && clsString_js_1.tzDataType.isString(pobjge_DifficultyLevelEN.difficultyLevelENName) === false) {
            throw new Error("(errid:Watl000060)字段[难度等级英文名(difficultyLevelENName)]的值:[$(pobjge_DifficultyLevelEN.difficultyLevelENName)], 非法，应该为字符型(In 难度等级表(ge_DifficultyLevel))!(clsge_DifficultyLevelBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.updDate) == false && undefined !== pobjge_DifficultyLevelEN.updDate && clsString_js_1.tzDataType.isString(pobjge_DifficultyLevelEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjge_DifficultyLevelEN.updDate)], 非法，应该为字符型(In 难度等级表(ge_DifficultyLevel))!(clsge_DifficultyLevelBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.updUser) == false && undefined !== pobjge_DifficultyLevelEN.updUser && clsString_js_1.tzDataType.isString(pobjge_DifficultyLevelEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjge_DifficultyLevelEN.updUser)], 非法，应该为字符型(In 难度等级表(ge_DifficultyLevel))!(clsge_DifficultyLevelBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.memo) == false && undefined !== pobjge_DifficultyLevelEN.memo && clsString_js_1.tzDataType.isString(pobjge_DifficultyLevelEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjge_DifficultyLevelEN.memo)], 非法，应该为字符型(In 难度等级表(ge_DifficultyLevel))!(clsge_DifficultyLevelBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjge_DifficultyLevelEN.SetIsCheckProperty(true);
    }
    exports.ge_DifficultyLevel_CheckPropertyNew = ge_DifficultyLevel_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ge_DifficultyLevel_CheckProperty4Update(pobjge_DifficultyLevelEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.difficultyLevelId) == false && (0, clsString_js_2.GetStrLen)(pobjge_DifficultyLevelEN.difficultyLevelId) > 2) {
            throw new Error("(errid:Watl000062)字段[难度等级Id(difficultyLevelId)]的长度不能超过2(In 难度等级表(ge_DifficultyLevel))!值:$(pobjge_DifficultyLevelEN.difficultyLevelId)(clsge_DifficultyLevelBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.difficultyLevelName) == false && (0, clsString_js_2.GetStrLen)(pobjge_DifficultyLevelEN.difficultyLevelName) > 1000) {
            throw new Error("(errid:Watl000062)字段[难度等级名称(difficultyLevelName)]的长度不能超过1000(In 难度等级表(ge_DifficultyLevel))!值:$(pobjge_DifficultyLevelEN.difficultyLevelName)(clsge_DifficultyLevelBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.difficultyLevelENName) == false && (0, clsString_js_2.GetStrLen)(pobjge_DifficultyLevelEN.difficultyLevelENName) > 1000) {
            throw new Error("(errid:Watl000062)字段[难度等级英文名(difficultyLevelENName)]的长度不能超过1000(In 难度等级表(ge_DifficultyLevel))!值:$(pobjge_DifficultyLevelEN.difficultyLevelENName)(clsge_DifficultyLevelBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjge_DifficultyLevelEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 难度等级表(ge_DifficultyLevel))!值:$(pobjge_DifficultyLevelEN.updDate)(clsge_DifficultyLevelBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjge_DifficultyLevelEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 难度等级表(ge_DifficultyLevel))!值:$(pobjge_DifficultyLevelEN.updUser)(clsge_DifficultyLevelBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjge_DifficultyLevelEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 难度等级表(ge_DifficultyLevel))!值:$(pobjge_DifficultyLevelEN.memo)(clsge_DifficultyLevelBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.difficultyLevelId) == false && undefined !== pobjge_DifficultyLevelEN.difficultyLevelId && clsString_js_1.tzDataType.isString(pobjge_DifficultyLevelEN.difficultyLevelId) === false) {
            throw new Error("(errid:Watl000063)字段[难度等级Id(difficultyLevelId)]的值:[$(pobjge_DifficultyLevelEN.difficultyLevelId)], 非法，应该为字符型(In 难度等级表(ge_DifficultyLevel))!(clsge_DifficultyLevelBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.difficultyLevelName) == false && undefined !== pobjge_DifficultyLevelEN.difficultyLevelName && clsString_js_1.tzDataType.isString(pobjge_DifficultyLevelEN.difficultyLevelName) === false) {
            throw new Error("(errid:Watl000063)字段[难度等级名称(difficultyLevelName)]的值:[$(pobjge_DifficultyLevelEN.difficultyLevelName)], 非法，应该为字符型(In 难度等级表(ge_DifficultyLevel))!(clsge_DifficultyLevelBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.difficultyLevelENName) == false && undefined !== pobjge_DifficultyLevelEN.difficultyLevelENName && clsString_js_1.tzDataType.isString(pobjge_DifficultyLevelEN.difficultyLevelENName) === false) {
            throw new Error("(errid:Watl000063)字段[难度等级英文名(difficultyLevelENName)]的值:[$(pobjge_DifficultyLevelEN.difficultyLevelENName)], 非法，应该为字符型(In 难度等级表(ge_DifficultyLevel))!(clsge_DifficultyLevelBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.updDate) == false && undefined !== pobjge_DifficultyLevelEN.updDate && clsString_js_1.tzDataType.isString(pobjge_DifficultyLevelEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjge_DifficultyLevelEN.updDate)], 非法，应该为字符型(In 难度等级表(ge_DifficultyLevel))!(clsge_DifficultyLevelBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.updUser) == false && undefined !== pobjge_DifficultyLevelEN.updUser && clsString_js_1.tzDataType.isString(pobjge_DifficultyLevelEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjge_DifficultyLevelEN.updUser)], 非法，应该为字符型(In 难度等级表(ge_DifficultyLevel))!(clsge_DifficultyLevelBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.memo) == false && undefined !== pobjge_DifficultyLevelEN.memo && clsString_js_1.tzDataType.isString(pobjge_DifficultyLevelEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjge_DifficultyLevelEN.memo)], 非法，应该为字符型(In 难度等级表(ge_DifficultyLevel))!(clsge_DifficultyLevelBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_DifficultyLevelEN.difficultyLevelId) === true
            || pobjge_DifficultyLevelEN.difficultyLevelId.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[难度等级Id]不能为空(In 难度等级表)!(clsge_DifficultyLevelBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjge_DifficultyLevelEN.SetIsCheckProperty(true);
    }
    exports.ge_DifficultyLevel_CheckProperty4Update = ge_DifficultyLevel_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ge_DifficultyLevel_GetJSONStrByObj(pobjge_DifficultyLevelEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjge_DifficultyLevelEN.sf_UpdFldSetStr = pobjge_DifficultyLevelEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjge_DifficultyLevelEN);
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
    exports.ge_DifficultyLevel_GetJSONStrByObj = ge_DifficultyLevel_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ge_DifficultyLevel_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrge_DifficultyLevelObjLst = new Array();
        if (strJSON === "") {
            return arrge_DifficultyLevelObjLst;
        }
        try {
            arrge_DifficultyLevelObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrge_DifficultyLevelObjLst;
        }
        return arrge_DifficultyLevelObjLst;
    }
    exports.ge_DifficultyLevel_GetObjLstByJSONStr = ge_DifficultyLevel_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrge_DifficultyLevelObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ge_DifficultyLevel_GetObjLstByJSONObjLst(arrge_DifficultyLevelObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrge_DifficultyLevelObjLst = new Array();
        for (const objInFor of arrge_DifficultyLevelObjLstS) {
            const obj1 = ge_DifficultyLevel_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrge_DifficultyLevelObjLst.push(obj1);
        }
        return arrge_DifficultyLevelObjLst;
    }
    exports.ge_DifficultyLevel_GetObjLstByJSONObjLst = ge_DifficultyLevel_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ge_DifficultyLevel_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjge_DifficultyLevelEN = new clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN();
        if (strJSON === "") {
            return pobjge_DifficultyLevelEN;
        }
        try {
            pobjge_DifficultyLevelEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjge_DifficultyLevelEN;
        }
        return pobjge_DifficultyLevelEN;
    }
    exports.ge_DifficultyLevel_GetObjByJSONStr = ge_DifficultyLevel_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ge_DifficultyLevel_GetCombineCondition(objge_DifficultyLevel_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objge_DifficultyLevel_Cond.dicFldComparisonOp, clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelId) == true) {
            const strComparisonOp_DifficultyLevelId = objge_DifficultyLevel_Cond.dicFldComparisonOp[clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelId, objge_DifficultyLevel_Cond.difficultyLevelId, strComparisonOp_DifficultyLevelId);
        }
        if (Object.prototype.hasOwnProperty.call(objge_DifficultyLevel_Cond.dicFldComparisonOp, clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelName) == true) {
            const strComparisonOp_DifficultyLevelName = objge_DifficultyLevel_Cond.dicFldComparisonOp[clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelName, objge_DifficultyLevel_Cond.difficultyLevelName, strComparisonOp_DifficultyLevelName);
        }
        if (Object.prototype.hasOwnProperty.call(objge_DifficultyLevel_Cond.dicFldComparisonOp, clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelENName) == true) {
            const strComparisonOp_DifficultyLevelENName = objge_DifficultyLevel_Cond.dicFldComparisonOp[clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelENName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelENName, objge_DifficultyLevel_Cond.difficultyLevelENName, strComparisonOp_DifficultyLevelENName);
        }
        if (Object.prototype.hasOwnProperty.call(objge_DifficultyLevel_Cond.dicFldComparisonOp, clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objge_DifficultyLevel_Cond.dicFldComparisonOp[clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_UpdDate, objge_DifficultyLevel_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objge_DifficultyLevel_Cond.dicFldComparisonOp, clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objge_DifficultyLevel_Cond.dicFldComparisonOp[clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_UpdUser, objge_DifficultyLevel_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objge_DifficultyLevel_Cond.dicFldComparisonOp, clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_Memo) == true) {
            const strComparisonOp_Memo = objge_DifficultyLevel_Cond.dicFldComparisonOp[clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_Memo, objge_DifficultyLevel_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.ge_DifficultyLevel_GetCombineCondition = ge_DifficultyLevel_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--ge_DifficultyLevel(难度等级表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strDifficultyLevelName: 难度等级名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ge_DifficultyLevel_GetUniCondStr_DifficultyLevelName(objge_DifficultyLevelEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and DifficultyLevelName = '{0}'", objge_DifficultyLevelEN.difficultyLevelName);
        return strWhereCond;
    }
    exports.ge_DifficultyLevel_GetUniCondStr_DifficultyLevelName = ge_DifficultyLevel_GetUniCondStr_DifficultyLevelName;
    /**
    *获取唯一性条件串(Uniqueness)--ge_DifficultyLevel(难度等级表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strDifficultyLevelName: 难度等级名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ge_DifficultyLevel_GetUniCondStr4Update_DifficultyLevelName(objge_DifficultyLevelEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and DifficultyLevelId <> '{0}'", objge_DifficultyLevelEN.difficultyLevelId);
        strWhereCond += (0, clsString_js_2.Format)(" and DifficultyLevelName = '{0}'", objge_DifficultyLevelEN.difficultyLevelName);
        return strWhereCond;
    }
    exports.ge_DifficultyLevel_GetUniCondStr4Update_DifficultyLevelName = ge_DifficultyLevel_GetUniCondStr4Update_DifficultyLevelName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objge_DifficultyLevelENS:源对象
     * @param objge_DifficultyLevelENT:目标对象
    */
    function ge_DifficultyLevel_CopyObjTo(objge_DifficultyLevelENS, objge_DifficultyLevelENT) {
        objge_DifficultyLevelENT.difficultyLevelId = objge_DifficultyLevelENS.difficultyLevelId; //难度等级Id
        objge_DifficultyLevelENT.difficultyLevelName = objge_DifficultyLevelENS.difficultyLevelName; //难度等级名称
        objge_DifficultyLevelENT.difficultyLevelENName = objge_DifficultyLevelENS.difficultyLevelENName; //难度等级英文名
        objge_DifficultyLevelENT.updDate = objge_DifficultyLevelENS.updDate; //修改日期
        objge_DifficultyLevelENT.updUser = objge_DifficultyLevelENS.updUser; //修改人
        objge_DifficultyLevelENT.memo = objge_DifficultyLevelENS.memo; //备注
        objge_DifficultyLevelENT.sf_UpdFldSetStr = objge_DifficultyLevelENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ge_DifficultyLevel_CopyObjTo = ge_DifficultyLevel_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objge_DifficultyLevelENS:源对象
     * @param objge_DifficultyLevelENT:目标对象
    */
    function ge_DifficultyLevel_GetObjFromJsonObj(objge_DifficultyLevelENS) {
        const objge_DifficultyLevelENT = new clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objge_DifficultyLevelENT, objge_DifficultyLevelENS);
        return objge_DifficultyLevelENT;
    }
    exports.ge_DifficultyLevel_GetObjFromJsonObj = ge_DifficultyLevel_GetObjFromJsonObj;
});
