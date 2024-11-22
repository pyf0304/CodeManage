/**
* 类名:clsge_LevelModeTypeWApi
* 表名:ge_LevelModeType(01120907)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/14 18:43:48
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:知识点相关(Knowledges)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/Knowledges_Share/clsge_LevelModeTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ge_LevelModeType_GetObjFromJsonObj = exports.ge_LevelModeType_CopyObjTo = exports.ge_LevelModeType_GetUniCondStr4Update_LevelModeTypeName = exports.ge_LevelModeType_GetUniCondStr_LevelModeTypeName = exports.ge_LevelModeType_GetCombineCondition = exports.ge_LevelModeType_GetObjByJSONStr = exports.ge_LevelModeType_GetObjLstByJSONObjLst = exports.ge_LevelModeType_GetObjLstByJSONStr = exports.ge_LevelModeType_GetJSONStrByObj = exports.ge_LevelModeType_CheckProperty4Update = exports.ge_LevelModeType_CheckPropertyNew = exports.ge_LevelModeType_BindDdl_LevelModeTypeIdInDiv_Cache = exports.ge_LevelModeType_ReFreshThisCache = exports.ge_LevelModeType_ReFreshCache = exports.ge_LevelModeType_GetWebApiUrl = exports.ge_LevelModeType_GetMaxStrIdByPrefix = exports.ge_LevelModeType_GetMaxStrIdAsync = exports.ge_LevelModeType_GetRecCountByCond_Cache = exports.ge_LevelModeType_GetRecCountByCondAsync = exports.ge_LevelModeType_IsExistAsync = exports.ge_LevelModeType_IsExist_Cache = exports.ge_LevelModeType_IsExist = exports.ge_LevelModeType_IsExistRecordAsync = exports.ge_LevelModeType_IsExistRecord_Cache = exports.ge_LevelModeType_UpdateWithConditionAsync = exports.ge_LevelModeType_UpdateRecordAsync = exports.ge_LevelModeType_AddNewRecordWithReturnKey = exports.ge_LevelModeType_AddNewRecordWithReturnKeyAsync = exports.ge_LevelModeType_AddNewRecordWithMaxIdAsync = exports.ge_LevelModeType_AddNewRecordAsync = exports.ge_LevelModeType_Delge_LevelModeTypesByCondAsync = exports.ge_LevelModeType_Delge_LevelModeTypesAsync = exports.ge_LevelModeType_DelRecordAsync = exports.ge_LevelModeType_GetObjLstByPagerAsync = exports.ge_LevelModeType_GetObjLstByPager_Cache = exports.ge_LevelModeType_GetObjLstByRange = exports.ge_LevelModeType_GetObjLstByRangeAsync = exports.ge_LevelModeType_GetTopObjLstAsync = exports.ge_LevelModeType_GetObjLstByLevelModeTypeIdLst_Cache = exports.ge_LevelModeType_GetObjLstByLevelModeTypeIdLstAsync = exports.ge_LevelModeType_GetSubObjLst_Cache = exports.ge_LevelModeType_GetObjLst_PureCache = exports.ge_LevelModeType_GetObjLst_Cache = exports.ge_LevelModeType_GetObjLst_sessionStorage_PureCache = exports.ge_LevelModeType_GetObjLst_sessionStorage = exports.ge_LevelModeType_GetObjLstAsync = exports.ge_LevelModeType_GetObjLst_localStorage_PureCache = exports.ge_LevelModeType_GetObjLst_localStorage = exports.ge_LevelModeType_GetObjLst_ClientCache = exports.ge_LevelModeType_GetFirstObjAsync = exports.ge_LevelModeType_GetFirstID = exports.ge_LevelModeType_GetFirstIDAsync = exports.ge_LevelModeType_funcKey = exports.ge_LevelModeType_FilterFunByKey = exports.ge_LevelModeType_SortFunByKey = exports.ge_LevelModeType_SortFun_Defa_2Fld = exports.ge_LevelModeType_SortFun_Defa = exports.ge_LevelModeType_func = exports.ge_LevelModeType_GetNameByLevelModeTypeId_Cache = exports.ge_LevelModeType_UpdateObjInLst_Cache = exports.ge_LevelModeType_GetObjByLevelModeTypeId_localStorage = exports.ge_LevelModeType_GetObjByLevelModeTypeId_Cache = exports.ge_LevelModeType_GetObjByLevelModeTypeIdAsync = exports.ge_LevelModeType_ConstructorName = exports.ge_LevelModeType_Controller = void 0;
    /**
     * 关卡模式类型(ge_LevelModeType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月14日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsge_LevelModeTypeEN_js_1 = require("../../L0_Entity/Knowledges_Share/clsge_LevelModeTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.ge_LevelModeType_Controller = "ge_LevelModeTypeApi";
    exports.ge_LevelModeType_ConstructorName = "ge_LevelModeType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strLevelModeTypeId:关键字
    * @returns 对象
    **/
    async function ge_LevelModeType_GetObjByLevelModeTypeIdAsync(strLevelModeTypeId) {
        const strThisFuncName = "GetObjByLevelModeTypeIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strLevelModeTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strLevelModeTypeId]不能为空！(In clsge_LevelModeTypeWApi.GetObjByLevelModeTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strLevelModeTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strLevelModeTypeId]的长度:[{0}]不正确！(clsge_LevelModeTypeWApi.GetObjByLevelModeTypeIdAsync)", strLevelModeTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByLevelModeTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strLevelModeTypeId": strLevelModeTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objge_LevelModeType = ge_LevelModeType_GetObjFromJsonObj(returnObj);
                return objge_LevelModeType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_GetObjByLevelModeTypeIdAsync = ge_LevelModeType_GetObjByLevelModeTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strLevelModeTypeId:所给的关键字
     * @returns 对象
    */
    async function ge_LevelModeType_GetObjByLevelModeTypeId_Cache(strLevelModeTypeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByLevelModeTypeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strLevelModeTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strLevelModeTypeId]不能为空！(In clsge_LevelModeTypeWApi.GetObjByLevelModeTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strLevelModeTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strLevelModeTypeId]的长度:[{0}]不正确！(clsge_LevelModeTypeWApi.GetObjByLevelModeTypeId_Cache)", strLevelModeTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrge_LevelModeTypeObjLst_Cache = await ge_LevelModeType_GetObjLst_Cache();
        try {
            const arrge_LevelModeType_Sel = arrge_LevelModeTypeObjLst_Cache.filter(x => x.levelModeTypeId == strLevelModeTypeId);
            let objge_LevelModeType;
            if (arrge_LevelModeType_Sel.length > 0) {
                objge_LevelModeType = arrge_LevelModeType_Sel[0];
                return objge_LevelModeType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objge_LevelModeType_Const = await ge_LevelModeType_GetObjByLevelModeTypeIdAsync(strLevelModeTypeId);
                    if (objge_LevelModeType_Const != null) {
                        ge_LevelModeType_ReFreshThisCache();
                        return objge_LevelModeType_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strLevelModeTypeId, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.ge_LevelModeType_GetObjByLevelModeTypeId_Cache = ge_LevelModeType_GetObjByLevelModeTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strLevelModeTypeId:所给的关键字
     * @returns 对象
    */
    async function ge_LevelModeType_GetObjByLevelModeTypeId_localStorage(strLevelModeTypeId) {
        const strThisFuncName = "GetObjByLevelModeTypeId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strLevelModeTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strLevelModeTypeId]不能为空！(In clsge_LevelModeTypeWApi.GetObjByLevelModeTypeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strLevelModeTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strLevelModeTypeId]的长度:[{0}]不正确！(clsge_LevelModeTypeWApi.GetObjByLevelModeTypeId_localStorage)", strLevelModeTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN._CurrTabName, strLevelModeTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objge_LevelModeType_Cache = JSON.parse(strTempObj);
            return objge_LevelModeType_Cache;
        }
        try {
            const objge_LevelModeType = await ge_LevelModeType_GetObjByLevelModeTypeIdAsync(strLevelModeTypeId);
            if (objge_LevelModeType != null) {
                localStorage.setItem(strKey, JSON.stringify(objge_LevelModeType));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objge_LevelModeType;
            }
            return objge_LevelModeType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strLevelModeTypeId, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.ge_LevelModeType_GetObjByLevelModeTypeId_localStorage = ge_LevelModeType_GetObjByLevelModeTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objge_LevelModeType:所给的对象
     * @returns 对象
    */
    async function ge_LevelModeType_UpdateObjInLst_Cache(objge_LevelModeType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrge_LevelModeTypeObjLst_Cache = await ge_LevelModeType_GetObjLst_Cache();
            const obj = arrge_LevelModeTypeObjLst_Cache.find(x => x.levelModeTypeName == objge_LevelModeType.levelModeTypeName);
            if (obj != null) {
                objge_LevelModeType.levelModeTypeId = obj.levelModeTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objge_LevelModeType);
            }
            else {
                arrge_LevelModeTypeObjLst_Cache.push(objge_LevelModeType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.ge_LevelModeType_UpdateObjInLst_Cache = ge_LevelModeType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strLevelModeTypeId:所给的关键字
     * @returns 对象
    */
    async function ge_LevelModeType_GetNameByLevelModeTypeId_Cache(strLevelModeTypeId) {
        const strThisFuncName = "GetNameByLevelModeTypeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strLevelModeTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strLevelModeTypeId]不能为空！(In clsge_LevelModeTypeWApi.GetNameByLevelModeTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strLevelModeTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strLevelModeTypeId]的长度:[{0}]不正确！(clsge_LevelModeTypeWApi.GetNameByLevelModeTypeId_Cache)", strLevelModeTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrge_LevelModeTypeObjLst_Cache = await ge_LevelModeType_GetObjLst_Cache();
        if (arrge_LevelModeTypeObjLst_Cache == null)
            return "";
        try {
            const arrge_LevelModeType_Sel = arrge_LevelModeTypeObjLst_Cache.filter(x => x.levelModeTypeId == strLevelModeTypeId);
            let objge_LevelModeType;
            if (arrge_LevelModeType_Sel.length > 0) {
                objge_LevelModeType = arrge_LevelModeType_Sel[0];
                return objge_LevelModeType.levelModeTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strLevelModeTypeId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.ge_LevelModeType_GetNameByLevelModeTypeId_Cache = ge_LevelModeType_GetNameByLevelModeTypeId_Cache;
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
    async function ge_LevelModeType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strLevelModeTypeId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objge_LevelModeType = await ge_LevelModeType_GetObjByLevelModeTypeId_Cache(strLevelModeTypeId);
        if (objge_LevelModeType == null)
            return "";
        if (objge_LevelModeType.GetFldValue(strOutFldName) == null)
            return "";
        return objge_LevelModeType.GetFldValue(strOutFldName).toString();
    }
    exports.ge_LevelModeType_func = ge_LevelModeType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ge_LevelModeType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.levelModeTypeId.localeCompare(b.levelModeTypeId);
    }
    exports.ge_LevelModeType_SortFun_Defa = ge_LevelModeType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ge_LevelModeType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.levelModeTypeName == b.levelModeTypeName)
            return a.levelModeTypeENName.localeCompare(b.levelModeTypeENName);
        else
            return a.levelModeTypeName.localeCompare(b.levelModeTypeName);
    }
    exports.ge_LevelModeType_SortFun_Defa_2Fld = ge_LevelModeType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ge_LevelModeType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeId:
                    return (a, b) => {
                        return a.levelModeTypeId.localeCompare(b.levelModeTypeId);
                    };
                case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeName:
                    return (a, b) => {
                        if (a.levelModeTypeName == null)
                            return -1;
                        if (b.levelModeTypeName == null)
                            return 1;
                        return a.levelModeTypeName.localeCompare(b.levelModeTypeName);
                    };
                case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeENName:
                    return (a, b) => {
                        if (a.levelModeTypeENName == null)
                            return -1;
                        if (b.levelModeTypeENName == null)
                            return 1;
                        return a.levelModeTypeENName.localeCompare(b.levelModeTypeENName);
                    };
                case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ge_LevelModeType]中不存在！(in ${exports.ge_LevelModeType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeId:
                    return (a, b) => {
                        return b.levelModeTypeId.localeCompare(a.levelModeTypeId);
                    };
                case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeName:
                    return (a, b) => {
                        if (b.levelModeTypeName == null)
                            return -1;
                        if (a.levelModeTypeName == null)
                            return 1;
                        return b.levelModeTypeName.localeCompare(a.levelModeTypeName);
                    };
                case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeENName:
                    return (a, b) => {
                        if (b.levelModeTypeENName == null)
                            return -1;
                        if (a.levelModeTypeENName == null)
                            return 1;
                        return b.levelModeTypeENName.localeCompare(a.levelModeTypeENName);
                    };
                case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ge_LevelModeType]中不存在！(in ${exports.ge_LevelModeType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ge_LevelModeType_SortFunByKey = ge_LevelModeType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ge_LevelModeType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeId:
                return (obj) => {
                    return obj.levelModeTypeId === value;
                };
            case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeName:
                return (obj) => {
                    return obj.levelModeTypeName === value;
                };
            case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeENName:
                return (obj) => {
                    return obj.levelModeTypeENName === value;
                };
            case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ge_LevelModeType]中不存在！(in ${exports.ge_LevelModeType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ge_LevelModeType_FilterFunByKey = ge_LevelModeType_FilterFunByKey;
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
    async function ge_LevelModeType_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrge_LevelModeType = await ge_LevelModeType_GetObjLst_Cache();
        if (arrge_LevelModeType == null)
            return [];
        let arrge_LevelModeType_Sel = arrge_LevelModeType;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrge_LevelModeType_Sel.length == 0)
            return [];
        return arrge_LevelModeType_Sel.map(x => x.levelModeTypeId);
    }
    exports.ge_LevelModeType_funcKey = ge_LevelModeType_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ge_LevelModeType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_GetFirstIDAsync = ge_LevelModeType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ge_LevelModeType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_GetFirstID = ge_LevelModeType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ge_LevelModeType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
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
                const objge_LevelModeType = ge_LevelModeType_GetObjFromJsonObj(returnObj);
                return objge_LevelModeType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_GetFirstObjAsync = ge_LevelModeType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ge_LevelModeType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrge_LevelModeTypeExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrge_LevelModeTypeObjLst_T = ge_LevelModeType_GetObjLstByJSONObjLst(arrge_LevelModeTypeExObjLst_Cache);
            return arrge_LevelModeTypeObjLst_T;
        }
        try {
            const arrge_LevelModeTypeExObjLst = await ge_LevelModeType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrge_LevelModeTypeExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrge_LevelModeTypeExObjLst.length);
            console.log(strInfo);
            return arrge_LevelModeTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ge_LevelModeType_GetObjLst_ClientCache = ge_LevelModeType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ge_LevelModeType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrge_LevelModeTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrge_LevelModeTypeObjLst_T = ge_LevelModeType_GetObjLstByJSONObjLst(arrge_LevelModeTypeExObjLst_Cache);
            return arrge_LevelModeTypeObjLst_T;
        }
        try {
            const arrge_LevelModeTypeExObjLst = await ge_LevelModeType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrge_LevelModeTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrge_LevelModeTypeExObjLst.length);
            console.log(strInfo);
            return arrge_LevelModeTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ge_LevelModeType_GetObjLst_localStorage = ge_LevelModeType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ge_LevelModeType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrge_LevelModeTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrge_LevelModeTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.ge_LevelModeType_GetObjLst_localStorage_PureCache = ge_LevelModeType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ge_LevelModeType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ge_LevelModeType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_GetObjLstAsync = ge_LevelModeType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ge_LevelModeType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrge_LevelModeTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrge_LevelModeTypeObjLst_T = ge_LevelModeType_GetObjLstByJSONObjLst(arrge_LevelModeTypeExObjLst_Cache);
            return arrge_LevelModeTypeObjLst_T;
        }
        try {
            const arrge_LevelModeTypeExObjLst = await ge_LevelModeType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrge_LevelModeTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrge_LevelModeTypeExObjLst.length);
            console.log(strInfo);
            return arrge_LevelModeTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ge_LevelModeType_GetObjLst_sessionStorage = ge_LevelModeType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ge_LevelModeType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrge_LevelModeTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrge_LevelModeTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.ge_LevelModeType_GetObjLst_sessionStorage_PureCache = ge_LevelModeType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ge_LevelModeType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrge_LevelModeTypeObjLst_Cache;
        switch (clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrge_LevelModeTypeObjLst_Cache = await ge_LevelModeType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrge_LevelModeTypeObjLst_Cache = await ge_LevelModeType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrge_LevelModeTypeObjLst_Cache = await ge_LevelModeType_GetObjLst_ClientCache();
                break;
            default:
                arrge_LevelModeTypeObjLst_Cache = await ge_LevelModeType_GetObjLst_ClientCache();
                break;
        }
        const arrge_LevelModeTypeObjLst = ge_LevelModeType_GetObjLstByJSONObjLst(arrge_LevelModeTypeObjLst_Cache);
        return arrge_LevelModeTypeObjLst_Cache;
    }
    exports.ge_LevelModeType_GetObjLst_Cache = ge_LevelModeType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ge_LevelModeType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrge_LevelModeTypeObjLst_Cache;
        switch (clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrge_LevelModeTypeObjLst_Cache = await ge_LevelModeType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrge_LevelModeTypeObjLst_Cache = await ge_LevelModeType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrge_LevelModeTypeObjLst_Cache = null;
                break;
            default:
                arrge_LevelModeTypeObjLst_Cache = null;
                break;
        }
        return arrge_LevelModeTypeObjLst_Cache;
    }
    exports.ge_LevelModeType_GetObjLst_PureCache = ge_LevelModeType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrLevelModeTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ge_LevelModeType_GetSubObjLst_Cache(objge_LevelModeType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrge_LevelModeTypeObjLst_Cache = await ge_LevelModeType_GetObjLst_Cache();
        let arrge_LevelModeType_Sel = arrge_LevelModeTypeObjLst_Cache;
        if (objge_LevelModeType_Cond.sf_FldComparisonOp == null || objge_LevelModeType_Cond.sf_FldComparisonOp == "")
            return arrge_LevelModeType_Sel;
        const dicFldComparisonOp = JSON.parse(objge_LevelModeType_Cond.sf_FldComparisonOp);
        //console.log("clsge_LevelModeTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objge_LevelModeType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objge_LevelModeType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrge_LevelModeType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objge_LevelModeType_Cond), exports.ge_LevelModeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ge_LevelModeType_GetSubObjLst_Cache = ge_LevelModeType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrLevelModeTypeId:关键字列表
    * @returns 对象列表
    **/
    async function ge_LevelModeType_GetObjLstByLevelModeTypeIdLstAsync(arrLevelModeTypeId) {
        const strThisFuncName = "GetObjLstByLevelModeTypeIdLstAsync";
        const strAction = "GetObjLstByLevelModeTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrLevelModeTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ge_LevelModeType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_GetObjLstByLevelModeTypeIdLstAsync = ge_LevelModeType_GetObjLstByLevelModeTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrLevelModeTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function ge_LevelModeType_GetObjLstByLevelModeTypeIdLst_Cache(arrLevelModeTypeIdLst) {
        const strThisFuncName = "GetObjLstByLevelModeTypeIdLst_Cache";
        try {
            const arrge_LevelModeTypeObjLst_Cache = await ge_LevelModeType_GetObjLst_Cache();
            const arrge_LevelModeType_Sel = arrge_LevelModeTypeObjLst_Cache.filter(x => arrLevelModeTypeIdLst.indexOf(x.levelModeTypeId) > -1);
            return arrge_LevelModeType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrLevelModeTypeIdLst.join(","), exports.ge_LevelModeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.ge_LevelModeType_GetObjLstByLevelModeTypeIdLst_Cache = ge_LevelModeType_GetObjLstByLevelModeTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ge_LevelModeType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ge_LevelModeType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_GetTopObjLstAsync = ge_LevelModeType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ge_LevelModeType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ge_LevelModeType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_GetObjLstByRangeAsync = ge_LevelModeType_GetObjLstByRangeAsync;
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
    async function ge_LevelModeType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_GetObjLstByRange = ge_LevelModeType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function ge_LevelModeType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrge_LevelModeTypeObjLst_Cache = await ge_LevelModeType_GetObjLst_Cache();
        if (arrge_LevelModeTypeObjLst_Cache.length == 0)
            return arrge_LevelModeTypeObjLst_Cache;
        let arrge_LevelModeType_Sel = arrge_LevelModeTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objge_LevelModeType_Cond = new clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objge_LevelModeType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsge_LevelModeTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objge_LevelModeType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrge_LevelModeType_Sel.length == 0)
                return arrge_LevelModeType_Sel;
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
                arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.sort(ge_LevelModeType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.sort(objPagerPara.sortFun);
            }
            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.slice(intStart, intEnd);
            return arrge_LevelModeType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ge_LevelModeType_GetObjLstByPager_Cache = ge_LevelModeType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ge_LevelModeType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ge_LevelModeType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_GetObjLstByPagerAsync = ge_LevelModeType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strLevelModeTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function ge_LevelModeType_DelRecordAsync(strLevelModeTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strLevelModeTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_DelRecordAsync = ge_LevelModeType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrLevelModeTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ge_LevelModeType_Delge_LevelModeTypesAsync(arrLevelModeTypeId) {
        const strThisFuncName = "Delge_LevelModeTypesAsync";
        const strAction = "Delge_LevelModeTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrLevelModeTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_Delge_LevelModeTypesAsync = ge_LevelModeType_Delge_LevelModeTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ge_LevelModeType_Delge_LevelModeTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "Delge_LevelModeTypesByCondAsync";
        const strAction = "Delge_LevelModeTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_Delge_LevelModeTypesByCondAsync = ge_LevelModeType_Delge_LevelModeTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objge_LevelModeTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ge_LevelModeType_AddNewRecordAsync(objge_LevelModeTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objge_LevelModeTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objge_LevelModeTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_AddNewRecordAsync = ge_LevelModeType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objge_LevelModeTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ge_LevelModeType_AddNewRecordWithMaxIdAsync(objge_LevelModeTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objge_LevelModeTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_AddNewRecordWithMaxIdAsync = ge_LevelModeType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objge_LevelModeTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ge_LevelModeType_AddNewRecordWithReturnKeyAsync(objge_LevelModeTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objge_LevelModeTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_AddNewRecordWithReturnKeyAsync = ge_LevelModeType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objge_LevelModeTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ge_LevelModeType_AddNewRecordWithReturnKey(objge_LevelModeTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objge_LevelModeTypeEN.levelModeTypeId === null || objge_LevelModeTypeEN.levelModeTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objge_LevelModeTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_AddNewRecordWithReturnKey = ge_LevelModeType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objge_LevelModeTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ge_LevelModeType_UpdateRecordAsync(objge_LevelModeTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objge_LevelModeTypeEN.sf_UpdFldSetStr === undefined || objge_LevelModeTypeEN.sf_UpdFldSetStr === null || objge_LevelModeTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objge_LevelModeTypeEN.levelModeTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objge_LevelModeTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_UpdateRecordAsync = ge_LevelModeType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objge_LevelModeTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ge_LevelModeType_UpdateWithConditionAsync(objge_LevelModeTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objge_LevelModeTypeEN.sf_UpdFldSetStr === undefined || objge_LevelModeTypeEN.sf_UpdFldSetStr === null || objge_LevelModeTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objge_LevelModeTypeEN.levelModeTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
        objge_LevelModeTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objge_LevelModeTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_UpdateWithConditionAsync = ge_LevelModeType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrLevelModeTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ge_LevelModeType_IsExistRecord_Cache(objge_LevelModeType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrge_LevelModeTypeObjLst_Cache = await ge_LevelModeType_GetObjLst_Cache();
        if (arrge_LevelModeTypeObjLst_Cache == null)
            return false;
        let arrge_LevelModeType_Sel = arrge_LevelModeTypeObjLst_Cache;
        if (objge_LevelModeType_Cond.sf_FldComparisonOp == null || objge_LevelModeType_Cond.sf_FldComparisonOp == "")
            return arrge_LevelModeType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objge_LevelModeType_Cond.sf_FldComparisonOp);
        //console.log("clsge_LevelModeTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objge_LevelModeType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objge_LevelModeType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrge_LevelModeType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objge_LevelModeType_Cond), exports.ge_LevelModeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.ge_LevelModeType_IsExistRecord_Cache = ge_LevelModeType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ge_LevelModeType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_IsExistRecordAsync = ge_LevelModeType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strLevelModeTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ge_LevelModeType_IsExist(strLevelModeTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "LevelModeTypeId": strLevelModeTypeId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_IsExist = ge_LevelModeType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strLevelModeTypeId:所给的关键字
     * @returns 对象
    */
    async function ge_LevelModeType_IsExist_Cache(strLevelModeTypeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrge_LevelModeTypeObjLst_Cache = await ge_LevelModeType_GetObjLst_Cache();
        if (arrge_LevelModeTypeObjLst_Cache == null)
            return false;
        try {
            const arrge_LevelModeType_Sel = arrge_LevelModeTypeObjLst_Cache.filter(x => x.levelModeTypeId == strLevelModeTypeId);
            if (arrge_LevelModeType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strLevelModeTypeId, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.ge_LevelModeType_IsExist_Cache = ge_LevelModeType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strLevelModeTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ge_LevelModeType_IsExistAsync(strLevelModeTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strLevelModeTypeId": strLevelModeTypeId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_IsExistAsync = ge_LevelModeType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ge_LevelModeType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_GetRecCountByCondAsync = ge_LevelModeType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objge_LevelModeType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function ge_LevelModeType_GetRecCountByCond_Cache(objge_LevelModeType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrge_LevelModeTypeObjLst_Cache = await ge_LevelModeType_GetObjLst_Cache();
        if (arrge_LevelModeTypeObjLst_Cache == null)
            return 0;
        let arrge_LevelModeType_Sel = arrge_LevelModeTypeObjLst_Cache;
        if (objge_LevelModeType_Cond.sf_FldComparisonOp == null || objge_LevelModeType_Cond.sf_FldComparisonOp == "")
            return arrge_LevelModeType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objge_LevelModeType_Cond.sf_FldComparisonOp);
        //console.log("clsge_LevelModeTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objge_LevelModeType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objge_LevelModeType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrge_LevelModeType_Sel = arrge_LevelModeType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrge_LevelModeType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objge_LevelModeType_Cond), exports.ge_LevelModeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.ge_LevelModeType_GetRecCountByCond_Cache = ge_LevelModeType_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function ge_LevelModeType_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_GetMaxStrIdAsync = ge_LevelModeType_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function ge_LevelModeType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ge_LevelModeType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ge_LevelModeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ge_LevelModeType_GetMaxStrIdByPrefix = ge_LevelModeType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ge_LevelModeType_GetWebApiUrl(strController, strAction) {
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
    exports.ge_LevelModeType_GetWebApiUrl = ge_LevelModeType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function ge_LevelModeType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN._CurrTabName;
        switch (clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.CacheModeId) {
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
    exports.ge_LevelModeType_ReFreshCache = ge_LevelModeType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function ge_LevelModeType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN._CurrTabName;
            switch (clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.CacheModeId) {
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
    exports.ge_LevelModeType_ReFreshThisCache = ge_LevelModeType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function ge_LevelModeType_BindDdl_LevelModeTypeIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_LevelModeTypeIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_LevelModeTypeIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_LevelModeTypeIdInDiv_Cache");
        const arrObjLst_Sel = await ge_LevelModeType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeId, clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeName, "关卡模式类型");
    }
    exports.ge_LevelModeType_BindDdl_LevelModeTypeIdInDiv_Cache = ge_LevelModeType_BindDdl_LevelModeTypeIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ge_LevelModeType_CheckPropertyNew(pobjge_LevelModeTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.levelModeTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjge_LevelModeTypeEN.levelModeTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[模式Id(levelModeTypeId)]的长度不能超过2(In 关卡模式类型(ge_LevelModeType))!值:$(pobjge_LevelModeTypeEN.levelModeTypeId)(clsge_LevelModeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.levelModeTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjge_LevelModeTypeEN.levelModeTypeName) > 100) {
            throw new Error("(errid:Watl000059)字段[模式名(levelModeTypeName)]的长度不能超过100(In 关卡模式类型(ge_LevelModeType))!值:$(pobjge_LevelModeTypeEN.levelModeTypeName)(clsge_LevelModeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.levelModeTypeENName) == false && (0, clsString_js_2.GetStrLen)(pobjge_LevelModeTypeEN.levelModeTypeENName) > 100) {
            throw new Error("(errid:Watl000059)字段[模式英文名(levelModeTypeENName)]的长度不能超过100(In 关卡模式类型(ge_LevelModeType))!值:$(pobjge_LevelModeTypeEN.levelModeTypeENName)(clsge_LevelModeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjge_LevelModeTypeEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 关卡模式类型(ge_LevelModeType))!值:$(pobjge_LevelModeTypeEN.updUser)(clsge_LevelModeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjge_LevelModeTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 关卡模式类型(ge_LevelModeType))!值:$(pobjge_LevelModeTypeEN.updDate)(clsge_LevelModeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjge_LevelModeTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 关卡模式类型(ge_LevelModeType))!值:$(pobjge_LevelModeTypeEN.memo)(clsge_LevelModeTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.levelModeTypeId) == false && undefined !== pobjge_LevelModeTypeEN.levelModeTypeId && clsString_js_1.tzDataType.isString(pobjge_LevelModeTypeEN.levelModeTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[模式Id(levelModeTypeId)]的值:[$(pobjge_LevelModeTypeEN.levelModeTypeId)], 非法，应该为字符型(In 关卡模式类型(ge_LevelModeType))!(clsge_LevelModeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.levelModeTypeName) == false && undefined !== pobjge_LevelModeTypeEN.levelModeTypeName && clsString_js_1.tzDataType.isString(pobjge_LevelModeTypeEN.levelModeTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[模式名(levelModeTypeName)]的值:[$(pobjge_LevelModeTypeEN.levelModeTypeName)], 非法，应该为字符型(In 关卡模式类型(ge_LevelModeType))!(clsge_LevelModeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.levelModeTypeENName) == false && undefined !== pobjge_LevelModeTypeEN.levelModeTypeENName && clsString_js_1.tzDataType.isString(pobjge_LevelModeTypeEN.levelModeTypeENName) === false) {
            throw new Error("(errid:Watl000060)字段[模式英文名(levelModeTypeENName)]的值:[$(pobjge_LevelModeTypeEN.levelModeTypeENName)], 非法，应该为字符型(In 关卡模式类型(ge_LevelModeType))!(clsge_LevelModeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.updUser) == false && undefined !== pobjge_LevelModeTypeEN.updUser && clsString_js_1.tzDataType.isString(pobjge_LevelModeTypeEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjge_LevelModeTypeEN.updUser)], 非法，应该为字符型(In 关卡模式类型(ge_LevelModeType))!(clsge_LevelModeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.updDate) == false && undefined !== pobjge_LevelModeTypeEN.updDate && clsString_js_1.tzDataType.isString(pobjge_LevelModeTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjge_LevelModeTypeEN.updDate)], 非法，应该为字符型(In 关卡模式类型(ge_LevelModeType))!(clsge_LevelModeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.memo) == false && undefined !== pobjge_LevelModeTypeEN.memo && clsString_js_1.tzDataType.isString(pobjge_LevelModeTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjge_LevelModeTypeEN.memo)], 非法，应该为字符型(In 关卡模式类型(ge_LevelModeType))!(clsge_LevelModeTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjge_LevelModeTypeEN.SetIsCheckProperty(true);
    }
    exports.ge_LevelModeType_CheckPropertyNew = ge_LevelModeType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ge_LevelModeType_CheckProperty4Update(pobjge_LevelModeTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.levelModeTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjge_LevelModeTypeEN.levelModeTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[模式Id(levelModeTypeId)]的长度不能超过2(In 关卡模式类型(ge_LevelModeType))!值:$(pobjge_LevelModeTypeEN.levelModeTypeId)(clsge_LevelModeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.levelModeTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjge_LevelModeTypeEN.levelModeTypeName) > 100) {
            throw new Error("(errid:Watl000062)字段[模式名(levelModeTypeName)]的长度不能超过100(In 关卡模式类型(ge_LevelModeType))!值:$(pobjge_LevelModeTypeEN.levelModeTypeName)(clsge_LevelModeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.levelModeTypeENName) == false && (0, clsString_js_2.GetStrLen)(pobjge_LevelModeTypeEN.levelModeTypeENName) > 100) {
            throw new Error("(errid:Watl000062)字段[模式英文名(levelModeTypeENName)]的长度不能超过100(In 关卡模式类型(ge_LevelModeType))!值:$(pobjge_LevelModeTypeEN.levelModeTypeENName)(clsge_LevelModeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjge_LevelModeTypeEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 关卡模式类型(ge_LevelModeType))!值:$(pobjge_LevelModeTypeEN.updUser)(clsge_LevelModeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjge_LevelModeTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 关卡模式类型(ge_LevelModeType))!值:$(pobjge_LevelModeTypeEN.updDate)(clsge_LevelModeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjge_LevelModeTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 关卡模式类型(ge_LevelModeType))!值:$(pobjge_LevelModeTypeEN.memo)(clsge_LevelModeTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.levelModeTypeId) == false && undefined !== pobjge_LevelModeTypeEN.levelModeTypeId && clsString_js_1.tzDataType.isString(pobjge_LevelModeTypeEN.levelModeTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[模式Id(levelModeTypeId)]的值:[$(pobjge_LevelModeTypeEN.levelModeTypeId)], 非法，应该为字符型(In 关卡模式类型(ge_LevelModeType))!(clsge_LevelModeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.levelModeTypeName) == false && undefined !== pobjge_LevelModeTypeEN.levelModeTypeName && clsString_js_1.tzDataType.isString(pobjge_LevelModeTypeEN.levelModeTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[模式名(levelModeTypeName)]的值:[$(pobjge_LevelModeTypeEN.levelModeTypeName)], 非法，应该为字符型(In 关卡模式类型(ge_LevelModeType))!(clsge_LevelModeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.levelModeTypeENName) == false && undefined !== pobjge_LevelModeTypeEN.levelModeTypeENName && clsString_js_1.tzDataType.isString(pobjge_LevelModeTypeEN.levelModeTypeENName) === false) {
            throw new Error("(errid:Watl000063)字段[模式英文名(levelModeTypeENName)]的值:[$(pobjge_LevelModeTypeEN.levelModeTypeENName)], 非法，应该为字符型(In 关卡模式类型(ge_LevelModeType))!(clsge_LevelModeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.updUser) == false && undefined !== pobjge_LevelModeTypeEN.updUser && clsString_js_1.tzDataType.isString(pobjge_LevelModeTypeEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjge_LevelModeTypeEN.updUser)], 非法，应该为字符型(In 关卡模式类型(ge_LevelModeType))!(clsge_LevelModeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.updDate) == false && undefined !== pobjge_LevelModeTypeEN.updDate && clsString_js_1.tzDataType.isString(pobjge_LevelModeTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjge_LevelModeTypeEN.updDate)], 非法，应该为字符型(In 关卡模式类型(ge_LevelModeType))!(clsge_LevelModeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.memo) == false && undefined !== pobjge_LevelModeTypeEN.memo && clsString_js_1.tzDataType.isString(pobjge_LevelModeTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjge_LevelModeTypeEN.memo)], 非法，应该为字符型(In 关卡模式类型(ge_LevelModeType))!(clsge_LevelModeTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjge_LevelModeTypeEN.levelModeTypeId) === true) {
            throw new Error("(errid:Watl000064)字段[模式Id]不能为空(In 关卡模式类型)!(clsge_LevelModeTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjge_LevelModeTypeEN.SetIsCheckProperty(true);
    }
    exports.ge_LevelModeType_CheckProperty4Update = ge_LevelModeType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ge_LevelModeType_GetJSONStrByObj(pobjge_LevelModeTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjge_LevelModeTypeEN.sf_UpdFldSetStr = pobjge_LevelModeTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjge_LevelModeTypeEN);
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
    exports.ge_LevelModeType_GetJSONStrByObj = ge_LevelModeType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ge_LevelModeType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrge_LevelModeTypeObjLst = new Array();
        if (strJSON === "") {
            return arrge_LevelModeTypeObjLst;
        }
        try {
            arrge_LevelModeTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrge_LevelModeTypeObjLst;
        }
        return arrge_LevelModeTypeObjLst;
    }
    exports.ge_LevelModeType_GetObjLstByJSONStr = ge_LevelModeType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrge_LevelModeTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ge_LevelModeType_GetObjLstByJSONObjLst(arrge_LevelModeTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrge_LevelModeTypeObjLst = new Array();
        for (const objInFor of arrge_LevelModeTypeObjLstS) {
            const obj1 = ge_LevelModeType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrge_LevelModeTypeObjLst.push(obj1);
        }
        return arrge_LevelModeTypeObjLst;
    }
    exports.ge_LevelModeType_GetObjLstByJSONObjLst = ge_LevelModeType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ge_LevelModeType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjge_LevelModeTypeEN = new clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN();
        if (strJSON === "") {
            return pobjge_LevelModeTypeEN;
        }
        try {
            pobjge_LevelModeTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjge_LevelModeTypeEN;
        }
        return pobjge_LevelModeTypeEN;
    }
    exports.ge_LevelModeType_GetObjByJSONStr = ge_LevelModeType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ge_LevelModeType_GetCombineCondition(objge_LevelModeType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objge_LevelModeType_Cond.dicFldComparisonOp, clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeId) == true) {
            const strComparisonOp_LevelModeTypeId = objge_LevelModeType_Cond.dicFldComparisonOp[clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeId, objge_LevelModeType_Cond.levelModeTypeId, strComparisonOp_LevelModeTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objge_LevelModeType_Cond.dicFldComparisonOp, clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeName) == true) {
            const strComparisonOp_LevelModeTypeName = objge_LevelModeType_Cond.dicFldComparisonOp[clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeName, objge_LevelModeType_Cond.levelModeTypeName, strComparisonOp_LevelModeTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objge_LevelModeType_Cond.dicFldComparisonOp, clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeENName) == true) {
            const strComparisonOp_LevelModeTypeENName = objge_LevelModeType_Cond.dicFldComparisonOp[clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeENName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeENName, objge_LevelModeType_Cond.levelModeTypeENName, strComparisonOp_LevelModeTypeENName);
        }
        if (Object.prototype.hasOwnProperty.call(objge_LevelModeType_Cond.dicFldComparisonOp, clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objge_LevelModeType_Cond.dicFldComparisonOp[clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_UpdUser, objge_LevelModeType_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objge_LevelModeType_Cond.dicFldComparisonOp, clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objge_LevelModeType_Cond.dicFldComparisonOp[clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_UpdDate, objge_LevelModeType_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objge_LevelModeType_Cond.dicFldComparisonOp, clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objge_LevelModeType_Cond.dicFldComparisonOp[clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_Memo, objge_LevelModeType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.ge_LevelModeType_GetCombineCondition = ge_LevelModeType_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--ge_LevelModeType(关卡模式类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strLevelModeTypeName: 模式名(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ge_LevelModeType_GetUniCondStr_LevelModeTypeName(objge_LevelModeTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and LevelModeTypeName = '{0}'", objge_LevelModeTypeEN.levelModeTypeName);
        return strWhereCond;
    }
    exports.ge_LevelModeType_GetUniCondStr_LevelModeTypeName = ge_LevelModeType_GetUniCondStr_LevelModeTypeName;
    /**
    *获取唯一性条件串(Uniqueness)--ge_LevelModeType(关卡模式类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strLevelModeTypeName: 模式名(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ge_LevelModeType_GetUniCondStr4Update_LevelModeTypeName(objge_LevelModeTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and LevelModeTypeId <> '{0}'", objge_LevelModeTypeEN.levelModeTypeId);
        strWhereCond += (0, clsString_js_2.Format)(" and LevelModeTypeName = '{0}'", objge_LevelModeTypeEN.levelModeTypeName);
        return strWhereCond;
    }
    exports.ge_LevelModeType_GetUniCondStr4Update_LevelModeTypeName = ge_LevelModeType_GetUniCondStr4Update_LevelModeTypeName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objge_LevelModeTypeENS:源对象
     * @param objge_LevelModeTypeENT:目标对象
    */
    function ge_LevelModeType_CopyObjTo(objge_LevelModeTypeENS, objge_LevelModeTypeENT) {
        objge_LevelModeTypeENT.levelModeTypeId = objge_LevelModeTypeENS.levelModeTypeId; //模式Id
        objge_LevelModeTypeENT.levelModeTypeName = objge_LevelModeTypeENS.levelModeTypeName; //模式名
        objge_LevelModeTypeENT.levelModeTypeENName = objge_LevelModeTypeENS.levelModeTypeENName; //模式英文名
        objge_LevelModeTypeENT.updUser = objge_LevelModeTypeENS.updUser; //修改人
        objge_LevelModeTypeENT.updDate = objge_LevelModeTypeENS.updDate; //修改日期
        objge_LevelModeTypeENT.memo = objge_LevelModeTypeENS.memo; //备注
        objge_LevelModeTypeENT.sf_UpdFldSetStr = objge_LevelModeTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ge_LevelModeType_CopyObjTo = ge_LevelModeType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objge_LevelModeTypeENS:源对象
     * @param objge_LevelModeTypeENT:目标对象
    */
    function ge_LevelModeType_GetObjFromJsonObj(objge_LevelModeTypeENS) {
        const objge_LevelModeTypeENT = new clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objge_LevelModeTypeENT, objge_LevelModeTypeENS);
        return objge_LevelModeTypeENT;
    }
    exports.ge_LevelModeType_GetObjFromJsonObj = ge_LevelModeType_GetObjFromJsonObj;
});
