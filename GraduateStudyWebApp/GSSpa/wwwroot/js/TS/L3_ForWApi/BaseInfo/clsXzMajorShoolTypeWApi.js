/**
* 类名:clsXzMajorShoolTypeWApi
* 表名:XzMajorShoolType(01120632)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:13
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:基本信息维护(BaseInfo)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/BaseInfo/clsXzMajorShoolTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzMajorShoolType_GetObjFromJsonObj = exports.XzMajorShoolType_CopyObjTo = exports.XzMajorShoolType_GetUniCondStr4Update_id_XzMajorShoolType = exports.XzMajorShoolType_GetUniCondStr_id_XzMajorShoolType = exports.XzMajorShoolType_GetCombineCondition = exports.XzMajorShoolType_GetObjByJSONStr = exports.XzMajorShoolType_GetObjLstByJSONObjLst = exports.XzMajorShoolType_GetObjLstByJSONStr = exports.XzMajorShoolType_GetJSONStrByObj = exports.XzMajorShoolType_CheckProperty4Update = exports.XzMajorShoolType_CheckPropertyNew = exports.XzMajorShoolType_BindDdl_id_XzMajorShoolTypeInDiv_Cache = exports.XzMajorShoolType_ReFreshThisCache = exports.XzMajorShoolType_ReFreshCache = exports.XzMajorShoolType_GetWebApiUrl = exports.XzMajorShoolType_GetMaxStrIdByPrefix = exports.XzMajorShoolType_GetMaxStrIdAsync = exports.XzMajorShoolType_GetRecCountByCond_Cache = exports.XzMajorShoolType_GetRecCountByCondAsync = exports.XzMajorShoolType_IsExistAsync = exports.XzMajorShoolType_IsExist_Cache = exports.XzMajorShoolType_IsExist = exports.XzMajorShoolType_IsExistRecordAsync = exports.XzMajorShoolType_IsExistRecord_Cache = exports.XzMajorShoolType_UpdateWithConditionAsync = exports.XzMajorShoolType_UpdateRecordAsync = exports.XzMajorShoolType_AddNewRecordWithReturnKey = exports.XzMajorShoolType_AddNewRecordWithReturnKeyAsync = exports.XzMajorShoolType_AddNewRecordWithMaxIdAsync = exports.XzMajorShoolType_AddNewRecordAsync = exports.XzMajorShoolType_DelXzMajorShoolTypesByCondAsync = exports.XzMajorShoolType_DelXzMajorShoolTypesAsync = exports.XzMajorShoolType_DelRecordAsync = exports.XzMajorShoolType_GetObjLstByPagerAsync = exports.XzMajorShoolType_GetObjLstByPager_Cache = exports.XzMajorShoolType_GetObjLstByRange = exports.XzMajorShoolType_GetObjLstByRangeAsync = exports.XzMajorShoolType_GetTopObjLstAsync = exports.XzMajorShoolType_GetObjLstByid_XzMajorShoolTypeLst_Cache = exports.XzMajorShoolType_GetObjLstByid_XzMajorShoolTypeLstAsync = exports.XzMajorShoolType_GetSubObjLst_Cache = exports.XzMajorShoolType_GetObjLst_PureCache = exports.XzMajorShoolType_GetObjLst_Cache = exports.XzMajorShoolType_GetObjLst_sessionStorage_PureCache = exports.XzMajorShoolType_GetObjLst_sessionStorage = exports.XzMajorShoolType_GetObjLstAsync = exports.XzMajorShoolType_GetObjLst_localStorage_PureCache = exports.XzMajorShoolType_GetObjLst_localStorage = exports.XzMajorShoolType_GetObjLst_ClientCache = exports.XzMajorShoolType_GetFirstObjAsync = exports.XzMajorShoolType_GetFirstID = exports.XzMajorShoolType_GetFirstIDAsync = exports.XzMajorShoolType_FilterFunByKey = exports.XzMajorShoolType_SortFunByKey = exports.XzMajorShoolType_SortFun_Defa_2Fld = exports.XzMajorShoolType_SortFun_Defa = exports.XzMajorShoolType_func = exports.XzMajorShoolType_GetNameByid_XzMajorShoolType_Cache = exports.XzMajorShoolType_UpdateObjInLst_Cache = exports.XzMajorShoolType_GetObjByid_XzMajorShoolType_localStorage = exports.XzMajorShoolType_GetObjByid_XzMajorShoolType_Cache = exports.XzMajorShoolType_GetObjByid_XzMajorShoolTypeAsync = exports.xzMajorShoolType_ConstructorName = exports.xzMajorShoolType_Controller = void 0;
    /**
     * 专业学校类型(XzMajorShoolType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsXzMajorShoolTypeEN_js_1 = require("../../L0_Entity/BaseInfo/clsXzMajorShoolTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.xzMajorShoolType_Controller = "XzMajorShoolTypeApi";
    exports.xzMajorShoolType_ConstructorName = "xzMajorShoolType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_XzMajorShoolType:关键字
    * @returns 对象
    **/
    async function XzMajorShoolType_GetObjByid_XzMajorShoolTypeAsync(strid_XzMajorShoolType) {
        const strThisFuncName = "GetObjByid_XzMajorShoolTypeAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzMajorShoolType) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzMajorShoolType]不能为空！(In GetObjByid_XzMajorShoolTypeAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzMajorShoolType.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzMajorShoolType]的长度:[{0}]不正确！", strid_XzMajorShoolType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_XzMajorShoolType";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_XzMajorShoolType": strid_XzMajorShoolType,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objXzMajorShoolType = XzMajorShoolType_GetObjFromJsonObj(returnObj);
                return objXzMajorShoolType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_GetObjByid_XzMajorShoolTypeAsync = XzMajorShoolType_GetObjByid_XzMajorShoolTypeAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_XzMajorShoolType:所给的关键字
     * @returns 对象
    */
    async function XzMajorShoolType_GetObjByid_XzMajorShoolType_Cache(strid_XzMajorShoolType, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_XzMajorShoolType_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzMajorShoolType) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzMajorShoolType]不能为空！(In GetObjByid_XzMajorShoolType_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzMajorShoolType.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzMajorShoolType]的长度:[{0}]不正确！", strid_XzMajorShoolType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzMajorShoolTypeObjLst_Cache = await XzMajorShoolType_GetObjLst_Cache();
        try {
            const arrXzMajorShoolType_Sel = arrXzMajorShoolTypeObjLst_Cache.filter(x => x.id_XzMajorShoolType == strid_XzMajorShoolType);
            let objXzMajorShoolType;
            if (arrXzMajorShoolType_Sel.length > 0) {
                objXzMajorShoolType = arrXzMajorShoolType_Sel[0];
                return objXzMajorShoolType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objXzMajorShoolType = await XzMajorShoolType_GetObjByid_XzMajorShoolTypeAsync(strid_XzMajorShoolType);
                    if (objXzMajorShoolType != null) {
                        XzMajorShoolType_ReFreshThisCache();
                        return objXzMajorShoolType;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_XzMajorShoolType, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.XzMajorShoolType_GetObjByid_XzMajorShoolType_Cache = XzMajorShoolType_GetObjByid_XzMajorShoolType_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_XzMajorShoolType:所给的关键字
     * @returns 对象
    */
    async function XzMajorShoolType_GetObjByid_XzMajorShoolType_localStorage(strid_XzMajorShoolType) {
        const strThisFuncName = "GetObjByid_XzMajorShoolType_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzMajorShoolType) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzMajorShoolType]不能为空！(In GetObjByid_XzMajorShoolType_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzMajorShoolType.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzMajorShoolType]的长度:[{0}]不正确！", strid_XzMajorShoolType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN._CurrTabName, strid_XzMajorShoolType);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objXzMajorShoolType_Cache = JSON.parse(strTempObj);
            return objXzMajorShoolType_Cache;
        }
        try {
            const objXzMajorShoolType = await XzMajorShoolType_GetObjByid_XzMajorShoolTypeAsync(strid_XzMajorShoolType);
            if (objXzMajorShoolType != null) {
                localStorage.setItem(strKey, JSON.stringify(objXzMajorShoolType));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objXzMajorShoolType;
            }
            return objXzMajorShoolType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_XzMajorShoolType, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.XzMajorShoolType_GetObjByid_XzMajorShoolType_localStorage = XzMajorShoolType_GetObjByid_XzMajorShoolType_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objXzMajorShoolType:所给的对象
     * @returns 对象
    */
    async function XzMajorShoolType_UpdateObjInLst_Cache(objXzMajorShoolType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrXzMajorShoolTypeObjLst_Cache = await XzMajorShoolType_GetObjLst_Cache();
            const obj = arrXzMajorShoolTypeObjLst_Cache.find(x => x.id_XzMajorShoolType == objXzMajorShoolType.id_XzMajorShoolType);
            if (obj != null) {
                objXzMajorShoolType.id_XzMajorShoolType = obj.id_XzMajorShoolType;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objXzMajorShoolType);
            }
            else {
                arrXzMajorShoolTypeObjLst_Cache.push(objXzMajorShoolType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.XzMajorShoolType_UpdateObjInLst_Cache = XzMajorShoolType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_XzMajorShoolType:所给的关键字
     * @returns 对象
    */
    async function XzMajorShoolType_GetNameByid_XzMajorShoolType_Cache(strid_XzMajorShoolType) {
        const strThisFuncName = "GetNameByid_XzMajorShoolType_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzMajorShoolType) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzMajorShoolType]不能为空！(In GetNameByid_XzMajorShoolType_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzMajorShoolType.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzMajorShoolType]的长度:[{0}]不正确！", strid_XzMajorShoolType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzMajorShoolTypeObjLst_Cache = await XzMajorShoolType_GetObjLst_Cache();
        if (arrXzMajorShoolTypeObjLst_Cache == null)
            return "";
        try {
            const arrXzMajorShoolType_Sel = arrXzMajorShoolTypeObjLst_Cache.filter(x => x.id_XzMajorShoolType == strid_XzMajorShoolType);
            let objXzMajorShoolType;
            if (arrXzMajorShoolType_Sel.length > 0) {
                objXzMajorShoolType = arrXzMajorShoolType_Sel[0];
                return objXzMajorShoolType.typeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_XzMajorShoolType);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.XzMajorShoolType_GetNameByid_XzMajorShoolType_Cache = XzMajorShoolType_GetNameByid_XzMajorShoolType_Cache;
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
    async function XzMajorShoolType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_id_XzMajorShoolType) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_XzMajorShoolType = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objXzMajorShoolType = await XzMajorShoolType_GetObjByid_XzMajorShoolType_Cache(strid_XzMajorShoolType);
        if (objXzMajorShoolType == null)
            return "";
        return objXzMajorShoolType.GetFldValue(strOutFldName).toString();
    }
    exports.XzMajorShoolType_func = XzMajorShoolType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzMajorShoolType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_XzMajorShoolType.localeCompare(b.id_XzMajorShoolType);
    }
    exports.XzMajorShoolType_SortFun_Defa = XzMajorShoolType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzMajorShoolType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.typeName == b.typeName)
            return a.updUserId.localeCompare(b.updUserId);
        else
            return a.typeName.localeCompare(b.typeName);
    }
    exports.XzMajorShoolType_SortFun_Defa_2Fld = XzMajorShoolType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzMajorShoolType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_id_XzMajorShoolType:
                    return (a, b) => {
                        return a.id_XzMajorShoolType.localeCompare(b.id_XzMajorShoolType);
                    };
                case clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_TypeName:
                    return (a, b) => {
                        return a.typeName.localeCompare(b.typeName);
                    };
                case clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_UpdUserId:
                    return (a, b) => {
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzMajorShoolType]中不存在！(in ${exports.xzMajorShoolType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_id_XzMajorShoolType:
                    return (a, b) => {
                        return b.id_XzMajorShoolType.localeCompare(a.id_XzMajorShoolType);
                    };
                case clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_TypeName:
                    return (a, b) => {
                        return b.typeName.localeCompare(a.typeName);
                    };
                case clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_UpdUserId:
                    return (a, b) => {
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzMajorShoolType]中不存在！(in ${exports.xzMajorShoolType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.XzMajorShoolType_SortFunByKey = XzMajorShoolType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function XzMajorShoolType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_id_XzMajorShoolType:
                return (obj) => {
                    return obj.id_XzMajorShoolType === value;
                };
            case clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_TypeName:
                return (obj) => {
                    return obj.typeName === value;
                };
            case clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[XzMajorShoolType]中不存在！(in ${exports.xzMajorShoolType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.XzMajorShoolType_FilterFunByKey = XzMajorShoolType_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzMajorShoolType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_GetFirstIDAsync = XzMajorShoolType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function XzMajorShoolType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_GetFirstID = XzMajorShoolType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function XzMajorShoolType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objXzMajorShoolType = XzMajorShoolType_GetObjFromJsonObj(returnObj);
                return objXzMajorShoolType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_GetFirstObjAsync = XzMajorShoolType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorShoolType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN._CurrTabName;
        clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrXzMajorShoolTypeExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrXzMajorShoolTypeObjLst_T = XzMajorShoolType_GetObjLstByJSONObjLst(arrXzMajorShoolTypeExObjLst_Cache);
            return arrXzMajorShoolTypeObjLst_T;
        }
        try {
            const arrXzMajorShoolTypeExObjLst = await XzMajorShoolType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrXzMajorShoolTypeExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzMajorShoolTypeExObjLst.length);
            console.log(strInfo);
            return arrXzMajorShoolTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzMajorShoolType_GetObjLst_ClientCache = XzMajorShoolType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorShoolType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN._CurrTabName;
        clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzMajorShoolTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzMajorShoolTypeObjLst_T = XzMajorShoolType_GetObjLstByJSONObjLst(arrXzMajorShoolTypeExObjLst_Cache);
            return arrXzMajorShoolTypeObjLst_T;
        }
        try {
            const arrXzMajorShoolTypeExObjLst = await XzMajorShoolType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrXzMajorShoolTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzMajorShoolTypeExObjLst.length);
            console.log(strInfo);
            return arrXzMajorShoolTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzMajorShoolType_GetObjLst_localStorage = XzMajorShoolType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorShoolType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzMajorShoolTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzMajorShoolTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzMajorShoolType_GetObjLst_localStorage_PureCache = XzMajorShoolType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function XzMajorShoolType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajorShoolType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_GetObjLstAsync = XzMajorShoolType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorShoolType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN._CurrTabName;
        clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzMajorShoolTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzMajorShoolTypeObjLst_T = XzMajorShoolType_GetObjLstByJSONObjLst(arrXzMajorShoolTypeExObjLst_Cache);
            return arrXzMajorShoolTypeObjLst_T;
        }
        try {
            const arrXzMajorShoolTypeExObjLst = await XzMajorShoolType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrXzMajorShoolTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzMajorShoolTypeExObjLst.length);
            console.log(strInfo);
            return arrXzMajorShoolTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzMajorShoolType_GetObjLst_sessionStorage = XzMajorShoolType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorShoolType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzMajorShoolTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzMajorShoolTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzMajorShoolType_GetObjLst_sessionStorage_PureCache = XzMajorShoolType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorShoolType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrXzMajorShoolTypeObjLst_Cache;
        switch (clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzMajorShoolTypeObjLst_Cache = await XzMajorShoolType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrXzMajorShoolTypeObjLst_Cache = await XzMajorShoolType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrXzMajorShoolTypeObjLst_Cache = await XzMajorShoolType_GetObjLst_ClientCache();
                break;
            default:
                arrXzMajorShoolTypeObjLst_Cache = await XzMajorShoolType_GetObjLst_ClientCache();
                break;
        }
        const arrXzMajorShoolTypeObjLst = XzMajorShoolType_GetObjLstByJSONObjLst(arrXzMajorShoolTypeObjLst_Cache);
        return arrXzMajorShoolTypeObjLst_Cache;
    }
    exports.XzMajorShoolType_GetObjLst_Cache = XzMajorShoolType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorShoolType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrXzMajorShoolTypeObjLst_Cache;
        switch (clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzMajorShoolTypeObjLst_Cache = await XzMajorShoolType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrXzMajorShoolTypeObjLst_Cache = await XzMajorShoolType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrXzMajorShoolTypeObjLst_Cache = null;
                break;
            default:
                arrXzMajorShoolTypeObjLst_Cache = null;
                break;
        }
        return arrXzMajorShoolTypeObjLst_Cache;
    }
    exports.XzMajorShoolType_GetObjLst_PureCache = XzMajorShoolType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_XzMajorShoolType_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzMajorShoolType_GetSubObjLst_Cache(objXzMajorShoolType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrXzMajorShoolTypeObjLst_Cache = await XzMajorShoolType_GetObjLst_Cache();
        let arrXzMajorShoolType_Sel = arrXzMajorShoolTypeObjLst_Cache;
        if (objXzMajorShoolType_Cond.sf_FldComparisonOp == null || objXzMajorShoolType_Cond.sf_FldComparisonOp == "")
            return arrXzMajorShoolType_Sel;
        const dicFldComparisonOp = JSON.parse(objXzMajorShoolType_Cond.sf_FldComparisonOp);
        //console.log("clsXzMajorShoolTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzMajorShoolType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajorShoolType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzMajorShoolType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objXzMajorShoolType_Cond), exports.xzMajorShoolType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzMajorShoolType_GetSubObjLst_Cache = XzMajorShoolType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_XzMajorShoolType:关键字列表
    * @returns 对象列表
    **/
    async function XzMajorShoolType_GetObjLstByid_XzMajorShoolTypeLstAsync(arrid_XzMajorShoolType) {
        const strThisFuncName = "GetObjLstByid_XzMajorShoolTypeLstAsync";
        const strAction = "GetObjLstByid_XzMajorShoolTypeLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_XzMajorShoolType);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajorShoolType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_GetObjLstByid_XzMajorShoolTypeLstAsync = XzMajorShoolType_GetObjLstByid_XzMajorShoolTypeLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_XzMajorShoolTypeLst:关键字列表
     * @returns 对象列表
    */
    async function XzMajorShoolType_GetObjLstByid_XzMajorShoolTypeLst_Cache(arrid_XzMajorShoolTypeLst) {
        const strThisFuncName = "GetObjLstByid_XzMajorShoolTypeLst_Cache";
        try {
            const arrXzMajorShoolTypeObjLst_Cache = await XzMajorShoolType_GetObjLst_Cache();
            const arrXzMajorShoolType_Sel = arrXzMajorShoolTypeObjLst_Cache.filter(x => arrid_XzMajorShoolTypeLst.indexOf(x.id_XzMajorShoolType) > -1);
            return arrXzMajorShoolType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_XzMajorShoolTypeLst.join(","), exports.xzMajorShoolType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzMajorShoolType_GetObjLstByid_XzMajorShoolTypeLst_Cache = XzMajorShoolType_GetObjLstByid_XzMajorShoolTypeLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function XzMajorShoolType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajorShoolType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_GetTopObjLstAsync = XzMajorShoolType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzMajorShoolType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajorShoolType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_GetObjLstByRangeAsync = XzMajorShoolType_GetObjLstByRangeAsync;
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
    async function XzMajorShoolType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_GetObjLstByRange = XzMajorShoolType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function XzMajorShoolType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrXzMajorShoolTypeObjLst_Cache = await XzMajorShoolType_GetObjLst_Cache();
        if (arrXzMajorShoolTypeObjLst_Cache.length == 0)
            return arrXzMajorShoolTypeObjLst_Cache;
        let arrXzMajorShoolType_Sel = arrXzMajorShoolTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objXzMajorShoolType_Cond = new clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzMajorShoolType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsXzMajorShoolTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajorShoolType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzMajorShoolType_Sel.length == 0)
                return arrXzMajorShoolType_Sel;
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
                arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.sort(XzMajorShoolType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.sort(objPagerPara.sortFun);
            }
            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.slice(intStart, intEnd);
            return arrXzMajorShoolType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzMajorShoolType_GetObjLstByPager_Cache = XzMajorShoolType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzMajorShoolType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajorShoolType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_GetObjLstByPagerAsync = XzMajorShoolType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strid_XzMajorShoolType:关键字
    * @returns 获取删除的结果
    **/
    async function XzMajorShoolType_DelRecordAsync(strid_XzMajorShoolType) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strid_XzMajorShoolType);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strid_XzMajorShoolType, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_DelRecordAsync = XzMajorShoolType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_XzMajorShoolType:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function XzMajorShoolType_DelXzMajorShoolTypesAsync(arrid_XzMajorShoolType) {
        const strThisFuncName = "DelXzMajorShoolTypesAsync";
        const strAction = "DelXzMajorShoolTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_XzMajorShoolType);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_DelXzMajorShoolTypesAsync = XzMajorShoolType_DelXzMajorShoolTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function XzMajorShoolType_DelXzMajorShoolTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelXzMajorShoolTypesByCondAsync";
        const strAction = "DelXzMajorShoolTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_DelXzMajorShoolTypesByCondAsync = XzMajorShoolType_DelXzMajorShoolTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objXzMajorShoolTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzMajorShoolType_AddNewRecordAsync(objXzMajorShoolTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objXzMajorShoolTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorShoolTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_AddNewRecordAsync = XzMajorShoolType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objXzMajorShoolTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzMajorShoolType_AddNewRecordWithMaxIdAsync(objXzMajorShoolTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorShoolTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_AddNewRecordWithMaxIdAsync = XzMajorShoolType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objXzMajorShoolTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function XzMajorShoolType_AddNewRecordWithReturnKeyAsync(objXzMajorShoolTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorShoolTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_AddNewRecordWithReturnKeyAsync = XzMajorShoolType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objXzMajorShoolTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function XzMajorShoolType_AddNewRecordWithReturnKey(objXzMajorShoolTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objXzMajorShoolTypeEN.id_XzMajorShoolType === null || objXzMajorShoolTypeEN.id_XzMajorShoolType === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorShoolTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_AddNewRecordWithReturnKey = XzMajorShoolType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objXzMajorShoolTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function XzMajorShoolType_UpdateRecordAsync(objXzMajorShoolTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objXzMajorShoolTypeEN.sf_UpdFldSetStr === undefined || objXzMajorShoolTypeEN.sf_UpdFldSetStr === null || objXzMajorShoolTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzMajorShoolTypeEN.id_XzMajorShoolType);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorShoolTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_UpdateRecordAsync = XzMajorShoolType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objXzMajorShoolTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzMajorShoolType_UpdateWithConditionAsync(objXzMajorShoolTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objXzMajorShoolTypeEN.sf_UpdFldSetStr === undefined || objXzMajorShoolTypeEN.sf_UpdFldSetStr === null || objXzMajorShoolTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzMajorShoolTypeEN.id_XzMajorShoolType);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        objXzMajorShoolTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorShoolTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_UpdateWithConditionAsync = XzMajorShoolType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_XzMajorShoolType_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzMajorShoolType_IsExistRecord_Cache(objXzMajorShoolType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrXzMajorShoolTypeObjLst_Cache = await XzMajorShoolType_GetObjLst_Cache();
        if (arrXzMajorShoolTypeObjLst_Cache == null)
            return false;
        let arrXzMajorShoolType_Sel = arrXzMajorShoolTypeObjLst_Cache;
        if (objXzMajorShoolType_Cond.sf_FldComparisonOp == null || objXzMajorShoolType_Cond.sf_FldComparisonOp == "")
            return arrXzMajorShoolType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objXzMajorShoolType_Cond.sf_FldComparisonOp);
        //console.log("clsXzMajorShoolTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzMajorShoolType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajorShoolType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzMajorShoolType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objXzMajorShoolType_Cond), exports.xzMajorShoolType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.XzMajorShoolType_IsExistRecord_Cache = XzMajorShoolType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function XzMajorShoolType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_IsExistRecordAsync = XzMajorShoolType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_XzMajorShoolType:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function XzMajorShoolType_IsExist(strid_XzMajorShoolType, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_XzMajorShoolType": strid_XzMajorShoolType,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_IsExist = XzMajorShoolType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_XzMajorShoolType:所给的关键字
     * @returns 对象
    */
    async function XzMajorShoolType_IsExist_Cache(strid_XzMajorShoolType) {
        const strThisFuncName = "IsExist_Cache";
        const arrXzMajorShoolTypeObjLst_Cache = await XzMajorShoolType_GetObjLst_Cache();
        if (arrXzMajorShoolTypeObjLst_Cache == null)
            return false;
        try {
            const arrXzMajorShoolType_Sel = arrXzMajorShoolTypeObjLst_Cache.filter(x => x.id_XzMajorShoolType == strid_XzMajorShoolType);
            if (arrXzMajorShoolType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_XzMajorShoolType, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.XzMajorShoolType_IsExist_Cache = XzMajorShoolType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_XzMajorShoolType:关键字
    * @returns 是否存在?存在返回True
    **/
    async function XzMajorShoolType_IsExistAsync(strid_XzMajorShoolType) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_XzMajorShoolType": strid_XzMajorShoolType }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_IsExistAsync = XzMajorShoolType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function XzMajorShoolType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_GetRecCountByCondAsync = XzMajorShoolType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objXzMajorShoolType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function XzMajorShoolType_GetRecCountByCond_Cache(objXzMajorShoolType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrXzMajorShoolTypeObjLst_Cache = await XzMajorShoolType_GetObjLst_Cache();
        if (arrXzMajorShoolTypeObjLst_Cache == null)
            return 0;
        let arrXzMajorShoolType_Sel = arrXzMajorShoolTypeObjLst_Cache;
        if (objXzMajorShoolType_Cond.sf_FldComparisonOp == null || objXzMajorShoolType_Cond.sf_FldComparisonOp == "")
            return arrXzMajorShoolType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objXzMajorShoolType_Cond.sf_FldComparisonOp);
        //console.log("clsXzMajorShoolTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzMajorShoolType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajorShoolType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajorShoolType_Sel = arrXzMajorShoolType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzMajorShoolType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objXzMajorShoolType_Cond), exports.xzMajorShoolType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.XzMajorShoolType_GetRecCountByCond_Cache = XzMajorShoolType_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function XzMajorShoolType_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_GetMaxStrIdAsync = XzMajorShoolType_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function XzMajorShoolType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorShoolType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorShoolType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorShoolType_GetMaxStrIdByPrefix = XzMajorShoolType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function XzMajorShoolType_GetWebApiUrl(strController, strAction) {
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
    exports.XzMajorShoolType_GetWebApiUrl = XzMajorShoolType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function XzMajorShoolType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN._CurrTabName;
        switch (clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.CacheModeId) {
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
    }
    exports.XzMajorShoolType_ReFreshCache = XzMajorShoolType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function XzMajorShoolType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN._CurrTabName;
            switch (clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.CacheModeId) {
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
    exports.XzMajorShoolType_ReFreshThisCache = XzMajorShoolType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function XzMajorShoolType_BindDdl_id_XzMajorShoolTypeInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_id_XzMajorShoolTypeInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_id_XzMajorShoolTypeInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_id_XzMajorShoolTypeInDiv_Cache");
        const arrObjLst_Sel = await XzMajorShoolType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_id_XzMajorShoolType, clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_TypeName, "专业学校类型");
    }
    exports.XzMajorShoolType_BindDdl_id_XzMajorShoolTypeInDiv_Cache = XzMajorShoolType_BindDdl_id_XzMajorShoolTypeInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzMajorShoolType_CheckPropertyNew(pobjXzMajorShoolTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.typeName) === true) {
            throw new Error("(errid:Watl000058)字段[类型名称]不能为空(In 专业学校类型)!(clsXzMajorShoolTypeBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.id_XzMajorShoolType) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorShoolTypeEN.id_XzMajorShoolType) > 4) {
            throw new Error("(errid:Watl000059)字段[专业学校类型流水号(id_XzMajorShoolType)]的长度不能超过4(In 专业学校类型(XzMajorShoolType))!值:$(pobjXzMajorShoolTypeEN.id_XzMajorShoolType)(clsXzMajorShoolTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.typeName) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorShoolTypeEN.typeName) > 200) {
            throw new Error("(errid:Watl000059)字段[类型名称(typeName)]的长度不能超过200(In 专业学校类型(XzMajorShoolType))!值:$(pobjXzMajorShoolTypeEN.typeName)(clsXzMajorShoolTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorShoolTypeEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 专业学校类型(XzMajorShoolType))!值:$(pobjXzMajorShoolTypeEN.updUserId)(clsXzMajorShoolTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorShoolTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 专业学校类型(XzMajorShoolType))!值:$(pobjXzMajorShoolTypeEN.updDate)(clsXzMajorShoolTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorShoolTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 专业学校类型(XzMajorShoolType))!值:$(pobjXzMajorShoolTypeEN.memo)(clsXzMajorShoolTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.id_XzMajorShoolType) == false && undefined !== pobjXzMajorShoolTypeEN.id_XzMajorShoolType && jsString_js_1.tzDataType.isString(pobjXzMajorShoolTypeEN.id_XzMajorShoolType) === false) {
            throw new Error("(errid:Watl000060)字段[专业学校类型流水号(id_XzMajorShoolType)]的值:[$(pobjXzMajorShoolTypeEN.id_XzMajorShoolType)], 非法，应该为字符型(In 专业学校类型(XzMajorShoolType))!(clsXzMajorShoolTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.typeName) == false && undefined !== pobjXzMajorShoolTypeEN.typeName && jsString_js_1.tzDataType.isString(pobjXzMajorShoolTypeEN.typeName) === false) {
            throw new Error("(errid:Watl000060)字段[类型名称(typeName)]的值:[$(pobjXzMajorShoolTypeEN.typeName)], 非法，应该为字符型(In 专业学校类型(XzMajorShoolType))!(clsXzMajorShoolTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.updUserId) == false && undefined !== pobjXzMajorShoolTypeEN.updUserId && jsString_js_1.tzDataType.isString(pobjXzMajorShoolTypeEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjXzMajorShoolTypeEN.updUserId)], 非法，应该为字符型(In 专业学校类型(XzMajorShoolType))!(clsXzMajorShoolTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.updDate) == false && undefined !== pobjXzMajorShoolTypeEN.updDate && jsString_js_1.tzDataType.isString(pobjXzMajorShoolTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjXzMajorShoolTypeEN.updDate)], 非法，应该为字符型(In 专业学校类型(XzMajorShoolType))!(clsXzMajorShoolTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.memo) == false && undefined !== pobjXzMajorShoolTypeEN.memo && jsString_js_1.tzDataType.isString(pobjXzMajorShoolTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjXzMajorShoolTypeEN.memo)], 非法，应该为字符型(In 专业学校类型(XzMajorShoolType))!(clsXzMajorShoolTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjXzMajorShoolTypeEN.SetIsCheckProperty(true);
    }
    exports.XzMajorShoolType_CheckPropertyNew = XzMajorShoolType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzMajorShoolType_CheckProperty4Update(pobjXzMajorShoolTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.id_XzMajorShoolType) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorShoolTypeEN.id_XzMajorShoolType) > 4) {
            throw new Error("(errid:Watl000062)字段[专业学校类型流水号(id_XzMajorShoolType)]的长度不能超过4(In 专业学校类型(XzMajorShoolType))!值:$(pobjXzMajorShoolTypeEN.id_XzMajorShoolType)(clsXzMajorShoolTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.typeName) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorShoolTypeEN.typeName) > 200) {
            throw new Error("(errid:Watl000062)字段[类型名称(typeName)]的长度不能超过200(In 专业学校类型(XzMajorShoolType))!值:$(pobjXzMajorShoolTypeEN.typeName)(clsXzMajorShoolTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorShoolTypeEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 专业学校类型(XzMajorShoolType))!值:$(pobjXzMajorShoolTypeEN.updUserId)(clsXzMajorShoolTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorShoolTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 专业学校类型(XzMajorShoolType))!值:$(pobjXzMajorShoolTypeEN.updDate)(clsXzMajorShoolTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorShoolTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 专业学校类型(XzMajorShoolType))!值:$(pobjXzMajorShoolTypeEN.memo)(clsXzMajorShoolTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.id_XzMajorShoolType) == false && undefined !== pobjXzMajorShoolTypeEN.id_XzMajorShoolType && jsString_js_1.tzDataType.isString(pobjXzMajorShoolTypeEN.id_XzMajorShoolType) === false) {
            throw new Error("(errid:Watl000063)字段[专业学校类型流水号(id_XzMajorShoolType)]的值:[$(pobjXzMajorShoolTypeEN.id_XzMajorShoolType)], 非法，应该为字符型(In 专业学校类型(XzMajorShoolType))!(clsXzMajorShoolTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.typeName) == false && undefined !== pobjXzMajorShoolTypeEN.typeName && jsString_js_1.tzDataType.isString(pobjXzMajorShoolTypeEN.typeName) === false) {
            throw new Error("(errid:Watl000063)字段[类型名称(typeName)]的值:[$(pobjXzMajorShoolTypeEN.typeName)], 非法，应该为字符型(In 专业学校类型(XzMajorShoolType))!(clsXzMajorShoolTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.updUserId) == false && undefined !== pobjXzMajorShoolTypeEN.updUserId && jsString_js_1.tzDataType.isString(pobjXzMajorShoolTypeEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjXzMajorShoolTypeEN.updUserId)], 非法，应该为字符型(In 专业学校类型(XzMajorShoolType))!(clsXzMajorShoolTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.updDate) == false && undefined !== pobjXzMajorShoolTypeEN.updDate && jsString_js_1.tzDataType.isString(pobjXzMajorShoolTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjXzMajorShoolTypeEN.updDate)], 非法，应该为字符型(In 专业学校类型(XzMajorShoolType))!(clsXzMajorShoolTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.memo) == false && undefined !== pobjXzMajorShoolTypeEN.memo && jsString_js_1.tzDataType.isString(pobjXzMajorShoolTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjXzMajorShoolTypeEN.memo)], 非法，应该为字符型(In 专业学校类型(XzMajorShoolType))!(clsXzMajorShoolTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorShoolTypeEN.id_XzMajorShoolType) === true) {
            throw new Error("(errid:Watl000064)字段[专业学校类型流水号]不能为空(In 专业学校类型)!(clsXzMajorShoolTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjXzMajorShoolTypeEN.SetIsCheckProperty(true);
    }
    exports.XzMajorShoolType_CheckProperty4Update = XzMajorShoolType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzMajorShoolType_GetJSONStrByObj(pobjXzMajorShoolTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjXzMajorShoolTypeEN.sf_UpdFldSetStr = pobjXzMajorShoolTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjXzMajorShoolTypeEN);
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
    exports.XzMajorShoolType_GetJSONStrByObj = XzMajorShoolType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function XzMajorShoolType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrXzMajorShoolTypeObjLst = new Array();
        if (strJSON === "") {
            return arrXzMajorShoolTypeObjLst;
        }
        try {
            arrXzMajorShoolTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrXzMajorShoolTypeObjLst;
        }
        return arrXzMajorShoolTypeObjLst;
    }
    exports.XzMajorShoolType_GetObjLstByJSONStr = XzMajorShoolType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrXzMajorShoolTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function XzMajorShoolType_GetObjLstByJSONObjLst(arrXzMajorShoolTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrXzMajorShoolTypeObjLst = new Array();
        for (const objInFor of arrXzMajorShoolTypeObjLstS) {
            const obj1 = XzMajorShoolType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrXzMajorShoolTypeObjLst.push(obj1);
        }
        return arrXzMajorShoolTypeObjLst;
    }
    exports.XzMajorShoolType_GetObjLstByJSONObjLst = XzMajorShoolType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzMajorShoolType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjXzMajorShoolTypeEN = new clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN();
        if (strJSON === "") {
            return pobjXzMajorShoolTypeEN;
        }
        try {
            pobjXzMajorShoolTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjXzMajorShoolTypeEN;
        }
        return pobjXzMajorShoolTypeEN;
    }
    exports.XzMajorShoolType_GetObjByJSONStr = XzMajorShoolType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function XzMajorShoolType_GetCombineCondition(objXzMajorShoolType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objXzMajorShoolType_Cond.dicFldComparisonOp, clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_id_XzMajorShoolType) == true) {
            const strComparisonOp_id_XzMajorShoolType = objXzMajorShoolType_Cond.dicFldComparisonOp[clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_id_XzMajorShoolType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_id_XzMajorShoolType, objXzMajorShoolType_Cond.id_XzMajorShoolType, strComparisonOp_id_XzMajorShoolType);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorShoolType_Cond.dicFldComparisonOp, clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_TypeName) == true) {
            const strComparisonOp_TypeName = objXzMajorShoolType_Cond.dicFldComparisonOp[clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_TypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_TypeName, objXzMajorShoolType_Cond.typeName, strComparisonOp_TypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorShoolType_Cond.dicFldComparisonOp, clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objXzMajorShoolType_Cond.dicFldComparisonOp[clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_UpdUserId, objXzMajorShoolType_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorShoolType_Cond.dicFldComparisonOp, clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objXzMajorShoolType_Cond.dicFldComparisonOp[clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_UpdDate, objXzMajorShoolType_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorShoolType_Cond.dicFldComparisonOp, clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objXzMajorShoolType_Cond.dicFldComparisonOp[clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN.con_Memo, objXzMajorShoolType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.XzMajorShoolType_GetCombineCondition = XzMajorShoolType_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--XzMajorShoolType(专业学校类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strid_XzMajorShoolType: 专业学校类型流水号(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function XzMajorShoolType_GetUniCondStr_id_XzMajorShoolType(objXzMajorShoolTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and id_XzMajorShoolType = '{0}'", objXzMajorShoolTypeEN.id_XzMajorShoolType);
        return strWhereCond;
    }
    exports.XzMajorShoolType_GetUniCondStr_id_XzMajorShoolType = XzMajorShoolType_GetUniCondStr_id_XzMajorShoolType;
    /**
    *获取唯一性条件串(Uniqueness)--XzMajorShoolType(专业学校类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strid_XzMajorShoolType: 专业学校类型流水号(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function XzMajorShoolType_GetUniCondStr4Update_id_XzMajorShoolType(objXzMajorShoolTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and id_XzMajorShoolType <> '{0}'", objXzMajorShoolTypeEN.id_XzMajorShoolType);
        strWhereCond += (0, clsString_js_1.Format)(" and id_XzMajorShoolType = '{0}'", objXzMajorShoolTypeEN.id_XzMajorShoolType);
        return strWhereCond;
    }
    exports.XzMajorShoolType_GetUniCondStr4Update_id_XzMajorShoolType = XzMajorShoolType_GetUniCondStr4Update_id_XzMajorShoolType;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objXzMajorShoolTypeENS:源对象
     * @param objXzMajorShoolTypeENT:目标对象
    */
    function XzMajorShoolType_CopyObjTo(objXzMajorShoolTypeENS, objXzMajorShoolTypeENT) {
        objXzMajorShoolTypeENT.id_XzMajorShoolType = objXzMajorShoolTypeENS.id_XzMajorShoolType; //专业学校类型流水号
        objXzMajorShoolTypeENT.typeName = objXzMajorShoolTypeENS.typeName; //类型名称
        objXzMajorShoolTypeENT.updUserId = objXzMajorShoolTypeENS.updUserId; //修改用户Id
        objXzMajorShoolTypeENT.updDate = objXzMajorShoolTypeENS.updDate; //修改日期
        objXzMajorShoolTypeENT.memo = objXzMajorShoolTypeENS.memo; //备注
        objXzMajorShoolTypeENT.sf_UpdFldSetStr = objXzMajorShoolTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.XzMajorShoolType_CopyObjTo = XzMajorShoolType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objXzMajorShoolTypeENS:源对象
     * @param objXzMajorShoolTypeENT:目标对象
    */
    function XzMajorShoolType_GetObjFromJsonObj(objXzMajorShoolTypeENS) {
        const objXzMajorShoolTypeENT = new clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzMajorShoolTypeENT, objXzMajorShoolTypeENS);
        return objXzMajorShoolTypeENT;
    }
    exports.XzMajorShoolType_GetObjFromJsonObj = XzMajorShoolType_GetObjFromJsonObj;
});
