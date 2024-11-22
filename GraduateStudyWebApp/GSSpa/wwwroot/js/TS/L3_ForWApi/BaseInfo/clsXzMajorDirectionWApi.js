/**
* 类名:clsXzMajorDirectionWApi
* 表名:XzMajorDirection(01120552)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:08
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/BaseInfo/clsXzMajorDirectionEN.js", "../../L3_ForWApi/BaseInfo/clsvXzMajorDirectionWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzMajorDirection_GetObjFromJsonObj = exports.XzMajorDirection_CopyObjTo = exports.XzMajorDirection_GetUniCondStr4Update_id_XzMajor_MajorDirectionName = exports.XzMajorDirection_GetUniCondStr_id_XzMajor_MajorDirectionName = exports.XzMajorDirection_GetCombineCondition = exports.XzMajorDirection_GetObjByJSONStr = exports.XzMajorDirection_GetObjLstByJSONObjLst = exports.XzMajorDirection_GetObjLstByJSONStr = exports.XzMajorDirection_GetJSONStrByObj = exports.XzMajorDirection_CheckProperty4Update = exports.XzMajorDirection_CheckPropertyNew = exports.XzMajorDirection__Cache = exports.XzMajorDirection_ReFreshThisCache = exports.XzMajorDirection_ReFreshCache = exports.XzMajorDirection_GetWebApiUrl = exports.XzMajorDirection_GetMaxStrIdByPrefix = exports.XzMajorDirection_GetMaxStrIdAsync = exports.XzMajorDirection_GetRecCountByCond_Cache = exports.XzMajorDirection_GetRecCountByCondAsync = exports.XzMajorDirection_IsExistAsync = exports.XzMajorDirection_IsExist_Cache = exports.XzMajorDirection_IsExist = exports.XzMajorDirection_IsExistRecordAsync = exports.XzMajorDirection_IsExistRecord_Cache = exports.XzMajorDirection_UpdateWithConditionAsync = exports.XzMajorDirection_UpdateRecordAsync = exports.XzMajorDirection_AddNewRecordWithReturnKey = exports.XzMajorDirection_AddNewRecordWithReturnKeyAsync = exports.XzMajorDirection_AddNewRecordWithMaxIdAsync = exports.XzMajorDirection_AddNewRecordAsync = exports.XzMajorDirection_DelXzMajorDirectionsByCondAsync = exports.XzMajorDirection_DelXzMajorDirectionsAsync = exports.XzMajorDirection_DelRecordAsync = exports.XzMajorDirection_GetObjLstByPagerAsync = exports.XzMajorDirection_GetObjLstByPager_Cache = exports.XzMajorDirection_GetObjLstByRange = exports.XzMajorDirection_GetObjLstByRangeAsync = exports.XzMajorDirection_GetTopObjLstAsync = exports.XzMajorDirection_GetObjLstByMajorDirectionIdLst_Cache = exports.XzMajorDirection_GetObjLstByMajorDirectionIdLstAsync = exports.XzMajorDirection_GetSubObjLst_Cache = exports.XzMajorDirection_GetObjLst_PureCache = exports.XzMajorDirection_GetObjLst_Cache = exports.XzMajorDirection_GetObjLst_sessionStorage_PureCache = exports.XzMajorDirection_GetObjLst_sessionStorage = exports.XzMajorDirection_GetObjLstAsync = exports.XzMajorDirection_GetObjLst_localStorage_PureCache = exports.XzMajorDirection_GetObjLst_localStorage = exports.XzMajorDirection_GetObjLst_ClientCache = exports.XzMajorDirection_GetFirstObjAsync = exports.XzMajorDirection_GetFirstID = exports.XzMajorDirection_GetFirstIDAsync = exports.XzMajorDirection_FilterFunByKey = exports.XzMajorDirection_SortFunByKey = exports.XzMajorDirection_SortFun_Defa_2Fld = exports.XzMajorDirection_SortFun_Defa = exports.XzMajorDirection_func = exports.XzMajorDirection_GetNameByMajorDirectionId_Cache = exports.XzMajorDirection_UpdateObjInLst_Cache = exports.XzMajorDirection_GetObjByMajorDirectionId_localStorage = exports.XzMajorDirection_GetObjByMajorDirectionId_Cache = exports.XzMajorDirection_GetObjByMajorDirectionIdAsync = exports.xzMajorDirection_ConstructorName = exports.xzMajorDirection_Controller = void 0;
    /**
     * 专业方向(XzMajorDirection)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsXzMajorDirectionEN_js_1 = require("../../L0_Entity/BaseInfo/clsXzMajorDirectionEN.js");
    const clsvXzMajorDirectionWApi_js_1 = require("../../L3_ForWApi/BaseInfo/clsvXzMajorDirectionWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.xzMajorDirection_Controller = "XzMajorDirectionApi";
    exports.xzMajorDirection_ConstructorName = "xzMajorDirection";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strMajorDirectionId:关键字
    * @returns 对象
    **/
    async function XzMajorDirection_GetObjByMajorDirectionIdAsync(strMajorDirectionId) {
        const strThisFuncName = "GetObjByMajorDirectionIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strMajorDirectionId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strMajorDirectionId]不能为空！(In GetObjByMajorDirectionIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strMajorDirectionId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strMajorDirectionId]的长度:[{0}]不正确！", strMajorDirectionId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByMajorDirectionId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strMajorDirectionId": strMajorDirectionId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorDirection_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objXzMajorDirection = XzMajorDirection_GetObjFromJsonObj(returnObj);
                return objXzMajorDirection;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_GetObjByMajorDirectionIdAsync = XzMajorDirection_GetObjByMajorDirectionIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strMajorDirectionId:所给的关键字
     * @returns 对象
    */
    async function XzMajorDirection_GetObjByMajorDirectionId_Cache(strMajorDirectionId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByMajorDirectionId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strMajorDirectionId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strMajorDirectionId]不能为空！(In GetObjByMajorDirectionId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strMajorDirectionId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strMajorDirectionId]的长度:[{0}]不正确！", strMajorDirectionId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzMajorDirectionObjLst_Cache = await XzMajorDirection_GetObjLst_Cache();
        try {
            const arrXzMajorDirection_Sel = arrXzMajorDirectionObjLst_Cache.filter(x => x.majorDirectionId == strMajorDirectionId);
            let objXzMajorDirection;
            if (arrXzMajorDirection_Sel.length > 0) {
                objXzMajorDirection = arrXzMajorDirection_Sel[0];
                return objXzMajorDirection;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objXzMajorDirection = await XzMajorDirection_GetObjByMajorDirectionIdAsync(strMajorDirectionId);
                    if (objXzMajorDirection != null) {
                        XzMajorDirection_ReFreshThisCache();
                        return objXzMajorDirection;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strMajorDirectionId, exports.xzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.XzMajorDirection_GetObjByMajorDirectionId_Cache = XzMajorDirection_GetObjByMajorDirectionId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strMajorDirectionId:所给的关键字
     * @returns 对象
    */
    async function XzMajorDirection_GetObjByMajorDirectionId_localStorage(strMajorDirectionId) {
        const strThisFuncName = "GetObjByMajorDirectionId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strMajorDirectionId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strMajorDirectionId]不能为空！(In GetObjByMajorDirectionId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strMajorDirectionId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strMajorDirectionId]的长度:[{0}]不正确！", strMajorDirectionId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN._CurrTabName, strMajorDirectionId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objXzMajorDirection_Cache = JSON.parse(strTempObj);
            return objXzMajorDirection_Cache;
        }
        try {
            const objXzMajorDirection = await XzMajorDirection_GetObjByMajorDirectionIdAsync(strMajorDirectionId);
            if (objXzMajorDirection != null) {
                localStorage.setItem(strKey, JSON.stringify(objXzMajorDirection));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objXzMajorDirection;
            }
            return objXzMajorDirection;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strMajorDirectionId, exports.xzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.XzMajorDirection_GetObjByMajorDirectionId_localStorage = XzMajorDirection_GetObjByMajorDirectionId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objXzMajorDirection:所给的对象
     * @returns 对象
    */
    async function XzMajorDirection_UpdateObjInLst_Cache(objXzMajorDirection) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrXzMajorDirectionObjLst_Cache = await XzMajorDirection_GetObjLst_Cache();
            const obj = arrXzMajorDirectionObjLst_Cache.find(x => x.id_XzMajor == objXzMajorDirection.id_XzMajor && x.majorDirectionName == objXzMajorDirection.majorDirectionName);
            if (obj != null) {
                objXzMajorDirection.majorDirectionId = obj.majorDirectionId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objXzMajorDirection);
            }
            else {
                arrXzMajorDirectionObjLst_Cache.push(objXzMajorDirection);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.xzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.XzMajorDirection_UpdateObjInLst_Cache = XzMajorDirection_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strMajorDirectionId:所给的关键字
     * @returns 对象
    */
    async function XzMajorDirection_GetNameByMajorDirectionId_Cache(strMajorDirectionId) {
        const strThisFuncName = "GetNameByMajorDirectionId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strMajorDirectionId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strMajorDirectionId]不能为空！(In GetNameByMajorDirectionId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strMajorDirectionId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strMajorDirectionId]的长度:[{0}]不正确！", strMajorDirectionId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzMajorDirectionObjLst_Cache = await XzMajorDirection_GetObjLst_Cache();
        if (arrXzMajorDirectionObjLst_Cache == null)
            return "";
        try {
            const arrXzMajorDirection_Sel = arrXzMajorDirectionObjLst_Cache.filter(x => x.majorDirectionId == strMajorDirectionId);
            let objXzMajorDirection;
            if (arrXzMajorDirection_Sel.length > 0) {
                objXzMajorDirection = arrXzMajorDirection_Sel[0];
                return objXzMajorDirection.majorDirectionName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strMajorDirectionId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.XzMajorDirection_GetNameByMajorDirectionId_Cache = XzMajorDirection_GetNameByMajorDirectionId_Cache;
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
    async function XzMajorDirection_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strMajorDirectionId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objXzMajorDirection = await XzMajorDirection_GetObjByMajorDirectionId_Cache(strMajorDirectionId);
        if (objXzMajorDirection == null)
            return "";
        return objXzMajorDirection.GetFldValue(strOutFldName).toString();
    }
    exports.XzMajorDirection_func = XzMajorDirection_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzMajorDirection_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.majorDirectionId.localeCompare(b.majorDirectionId);
    }
    exports.XzMajorDirection_SortFun_Defa = XzMajorDirection_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzMajorDirection_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.id_XzMajor == b.id_XzMajor)
            return a.majorDirectionName.localeCompare(b.majorDirectionName);
        else
            return a.id_XzMajor.localeCompare(b.id_XzMajor);
    }
    exports.XzMajorDirection_SortFun_Defa_2Fld = XzMajorDirection_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzMajorDirection_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionId:
                    return (a, b) => {
                        return a.majorDirectionId.localeCompare(b.majorDirectionId);
                    };
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionName:
                    return (a, b) => {
                        return a.majorDirectionName.localeCompare(b.majorDirectionName);
                    };
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionENName:
                    return (a, b) => {
                        return a.majorDirectionENName.localeCompare(b.majorDirectionENName);
                    };
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionExplain:
                    return (a, b) => {
                        return a.majorDirectionExplain.localeCompare(b.majorDirectionExplain);
                    };
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_IsVisible:
                    return (a, b) => {
                        if (a.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzMajorDirection]中不存在！(in ${exports.xzMajorDirection_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionId:
                    return (a, b) => {
                        return b.majorDirectionId.localeCompare(a.majorDirectionId);
                    };
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionName:
                    return (a, b) => {
                        return b.majorDirectionName.localeCompare(a.majorDirectionName);
                    };
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionENName:
                    return (a, b) => {
                        return b.majorDirectionENName.localeCompare(a.majorDirectionENName);
                    };
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionExplain:
                    return (a, b) => {
                        return b.majorDirectionExplain.localeCompare(a.majorDirectionExplain);
                    };
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_IsVisible:
                    return (a, b) => {
                        if (b.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzMajorDirection]中不存在！(in ${exports.xzMajorDirection_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.XzMajorDirection_SortFunByKey = XzMajorDirection_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function XzMajorDirection_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionId:
                return (obj) => {
                    return obj.majorDirectionId === value;
                };
            case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionName:
                return (obj) => {
                    return obj.majorDirectionName === value;
                };
            case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionENName:
                return (obj) => {
                    return obj.majorDirectionENName === value;
                };
            case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionExplain:
                return (obj) => {
                    return obj.majorDirectionExplain === value;
                };
            case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_IsVisible:
                return (obj) => {
                    return obj.isVisible === value;
                };
            case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[XzMajorDirection]中不存在！(in ${exports.xzMajorDirection_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.XzMajorDirection_FilterFunByKey = XzMajorDirection_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzMajorDirection_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_GetFirstIDAsync = XzMajorDirection_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function XzMajorDirection_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_GetFirstID = XzMajorDirection_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function XzMajorDirection_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorDirection_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objXzMajorDirection = XzMajorDirection_GetObjFromJsonObj(returnObj);
                return objXzMajorDirection;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_GetFirstObjAsync = XzMajorDirection_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorDirection_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN._CurrTabName;
        clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrXzMajorDirectionExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrXzMajorDirectionObjLst_T = XzMajorDirection_GetObjLstByJSONObjLst(arrXzMajorDirectionExObjLst_Cache);
            return arrXzMajorDirectionObjLst_T;
        }
        try {
            const arrXzMajorDirectionExObjLst = await XzMajorDirection_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrXzMajorDirectionExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzMajorDirectionExObjLst.length);
            console.log(strInfo);
            return arrXzMajorDirectionExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzMajorDirection_GetObjLst_ClientCache = XzMajorDirection_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorDirection_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN._CurrTabName;
        clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzMajorDirectionExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzMajorDirectionObjLst_T = XzMajorDirection_GetObjLstByJSONObjLst(arrXzMajorDirectionExObjLst_Cache);
            return arrXzMajorDirectionObjLst_T;
        }
        try {
            const arrXzMajorDirectionExObjLst = await XzMajorDirection_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrXzMajorDirectionExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzMajorDirectionExObjLst.length);
            console.log(strInfo);
            return arrXzMajorDirectionExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzMajorDirection_GetObjLst_localStorage = XzMajorDirection_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorDirection_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzMajorDirectionObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzMajorDirectionObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzMajorDirection_GetObjLst_localStorage_PureCache = XzMajorDirection_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function XzMajorDirection_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorDirection_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajorDirection_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_GetObjLstAsync = XzMajorDirection_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorDirection_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN._CurrTabName;
        clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzMajorDirectionExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzMajorDirectionObjLst_T = XzMajorDirection_GetObjLstByJSONObjLst(arrXzMajorDirectionExObjLst_Cache);
            return arrXzMajorDirectionObjLst_T;
        }
        try {
            const arrXzMajorDirectionExObjLst = await XzMajorDirection_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrXzMajorDirectionExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzMajorDirectionExObjLst.length);
            console.log(strInfo);
            return arrXzMajorDirectionExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzMajorDirection_GetObjLst_sessionStorage = XzMajorDirection_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorDirection_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzMajorDirectionObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzMajorDirectionObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzMajorDirection_GetObjLst_sessionStorage_PureCache = XzMajorDirection_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorDirection_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrXzMajorDirectionObjLst_Cache;
        switch (clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzMajorDirectionObjLst_Cache = await XzMajorDirection_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrXzMajorDirectionObjLst_Cache = await XzMajorDirection_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrXzMajorDirectionObjLst_Cache = await XzMajorDirection_GetObjLst_ClientCache();
                break;
            default:
                arrXzMajorDirectionObjLst_Cache = await XzMajorDirection_GetObjLst_ClientCache();
                break;
        }
        const arrXzMajorDirectionObjLst = XzMajorDirection_GetObjLstByJSONObjLst(arrXzMajorDirectionObjLst_Cache);
        return arrXzMajorDirectionObjLst_Cache;
    }
    exports.XzMajorDirection_GetObjLst_Cache = XzMajorDirection_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorDirection_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrXzMajorDirectionObjLst_Cache;
        switch (clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzMajorDirectionObjLst_Cache = await XzMajorDirection_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrXzMajorDirectionObjLst_Cache = await XzMajorDirection_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrXzMajorDirectionObjLst_Cache = null;
                break;
            default:
                arrXzMajorDirectionObjLst_Cache = null;
                break;
        }
        return arrXzMajorDirectionObjLst_Cache;
    }
    exports.XzMajorDirection_GetObjLst_PureCache = XzMajorDirection_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrMajorDirectionId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzMajorDirection_GetSubObjLst_Cache(objXzMajorDirection_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrXzMajorDirectionObjLst_Cache = await XzMajorDirection_GetObjLst_Cache();
        let arrXzMajorDirection_Sel = arrXzMajorDirectionObjLst_Cache;
        if (objXzMajorDirection_Cond.sf_FldComparisonOp == null || objXzMajorDirection_Cond.sf_FldComparisonOp == "")
            return arrXzMajorDirection_Sel;
        const dicFldComparisonOp = JSON.parse(objXzMajorDirection_Cond.sf_FldComparisonOp);
        //console.log("clsXzMajorDirectionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzMajorDirection_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajorDirection_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzMajorDirection_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objXzMajorDirection_Cond), exports.xzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzMajorDirection_GetSubObjLst_Cache = XzMajorDirection_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrMajorDirectionId:关键字列表
    * @returns 对象列表
    **/
    async function XzMajorDirection_GetObjLstByMajorDirectionIdLstAsync(arrMajorDirectionId) {
        const strThisFuncName = "GetObjLstByMajorDirectionIdLstAsync";
        const strAction = "GetObjLstByMajorDirectionIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrMajorDirectionId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorDirection_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajorDirection_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_GetObjLstByMajorDirectionIdLstAsync = XzMajorDirection_GetObjLstByMajorDirectionIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrMajorDirectionIdLst:关键字列表
     * @returns 对象列表
    */
    async function XzMajorDirection_GetObjLstByMajorDirectionIdLst_Cache(arrMajorDirectionIdLst) {
        const strThisFuncName = "GetObjLstByMajorDirectionIdLst_Cache";
        try {
            const arrXzMajorDirectionObjLst_Cache = await XzMajorDirection_GetObjLst_Cache();
            const arrXzMajorDirection_Sel = arrXzMajorDirectionObjLst_Cache.filter(x => arrMajorDirectionIdLst.indexOf(x.majorDirectionId) > -1);
            return arrXzMajorDirection_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrMajorDirectionIdLst.join(","), exports.xzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzMajorDirection_GetObjLstByMajorDirectionIdLst_Cache = XzMajorDirection_GetObjLstByMajorDirectionIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function XzMajorDirection_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorDirection_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajorDirection_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_GetTopObjLstAsync = XzMajorDirection_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzMajorDirection_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorDirection_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajorDirection_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_GetObjLstByRangeAsync = XzMajorDirection_GetObjLstByRangeAsync;
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
    async function XzMajorDirection_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_GetObjLstByRange = XzMajorDirection_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function XzMajorDirection_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrXzMajorDirectionObjLst_Cache = await XzMajorDirection_GetObjLst_Cache();
        if (arrXzMajorDirectionObjLst_Cache.length == 0)
            return arrXzMajorDirectionObjLst_Cache;
        let arrXzMajorDirection_Sel = arrXzMajorDirectionObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objXzMajorDirection_Cond = new clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzMajorDirection_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsXzMajorDirectionWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajorDirection_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzMajorDirection_Sel.length == 0)
                return arrXzMajorDirection_Sel;
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
                arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.sort(XzMajorDirection_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.sort(objPagerPara.sortFun);
            }
            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.slice(intStart, intEnd);
            return arrXzMajorDirection_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.xzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzMajorDirection_GetObjLstByPager_Cache = XzMajorDirection_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzMajorDirection_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorDirection_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajorDirection_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_GetObjLstByPagerAsync = XzMajorDirection_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strMajorDirectionId:关键字
    * @returns 获取删除的结果
    **/
    async function XzMajorDirection_DelRecordAsync(strMajorDirectionId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strMajorDirectionId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strMajorDirectionId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_DelRecordAsync = XzMajorDirection_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrMajorDirectionId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function XzMajorDirection_DelXzMajorDirectionsAsync(arrMajorDirectionId) {
        const strThisFuncName = "DelXzMajorDirectionsAsync";
        const strAction = "DelXzMajorDirections";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrMajorDirectionId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_DelXzMajorDirectionsAsync = XzMajorDirection_DelXzMajorDirectionsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function XzMajorDirection_DelXzMajorDirectionsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelXzMajorDirectionsByCondAsync";
        const strAction = "DelXzMajorDirectionsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_DelXzMajorDirectionsByCondAsync = XzMajorDirection_DelXzMajorDirectionsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objXzMajorDirectionEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzMajorDirection_AddNewRecordAsync(objXzMajorDirectionEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objXzMajorDirectionEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorDirectionEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_AddNewRecordAsync = XzMajorDirection_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objXzMajorDirectionEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzMajorDirection_AddNewRecordWithMaxIdAsync(objXzMajorDirectionEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorDirectionEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_AddNewRecordWithMaxIdAsync = XzMajorDirection_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objXzMajorDirectionEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function XzMajorDirection_AddNewRecordWithReturnKeyAsync(objXzMajorDirectionEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorDirectionEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_AddNewRecordWithReturnKeyAsync = XzMajorDirection_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objXzMajorDirectionEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function XzMajorDirection_AddNewRecordWithReturnKey(objXzMajorDirectionEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objXzMajorDirectionEN.majorDirectionId === null || objXzMajorDirectionEN.majorDirectionId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorDirectionEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_AddNewRecordWithReturnKey = XzMajorDirection_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objXzMajorDirectionEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function XzMajorDirection_UpdateRecordAsync(objXzMajorDirectionEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objXzMajorDirectionEN.sf_UpdFldSetStr === undefined || objXzMajorDirectionEN.sf_UpdFldSetStr === null || objXzMajorDirectionEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzMajorDirectionEN.majorDirectionId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorDirectionEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_UpdateRecordAsync = XzMajorDirection_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objXzMajorDirectionEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzMajorDirection_UpdateWithConditionAsync(objXzMajorDirectionEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objXzMajorDirectionEN.sf_UpdFldSetStr === undefined || objXzMajorDirectionEN.sf_UpdFldSetStr === null || objXzMajorDirectionEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzMajorDirectionEN.majorDirectionId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        objXzMajorDirectionEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorDirectionEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_UpdateWithConditionAsync = XzMajorDirection_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrMajorDirectionId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzMajorDirection_IsExistRecord_Cache(objXzMajorDirection_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrXzMajorDirectionObjLst_Cache = await XzMajorDirection_GetObjLst_Cache();
        if (arrXzMajorDirectionObjLst_Cache == null)
            return false;
        let arrXzMajorDirection_Sel = arrXzMajorDirectionObjLst_Cache;
        if (objXzMajorDirection_Cond.sf_FldComparisonOp == null || objXzMajorDirection_Cond.sf_FldComparisonOp == "")
            return arrXzMajorDirection_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objXzMajorDirection_Cond.sf_FldComparisonOp);
        //console.log("clsXzMajorDirectionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzMajorDirection_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajorDirection_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzMajorDirection_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objXzMajorDirection_Cond), exports.xzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.XzMajorDirection_IsExistRecord_Cache = XzMajorDirection_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function XzMajorDirection_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_IsExistRecordAsync = XzMajorDirection_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strMajorDirectionId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function XzMajorDirection_IsExist(strMajorDirectionId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "MajorDirectionId": strMajorDirectionId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_IsExist = XzMajorDirection_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strMajorDirectionId:所给的关键字
     * @returns 对象
    */
    async function XzMajorDirection_IsExist_Cache(strMajorDirectionId) {
        const strThisFuncName = "IsExist_Cache";
        const arrXzMajorDirectionObjLst_Cache = await XzMajorDirection_GetObjLst_Cache();
        if (arrXzMajorDirectionObjLst_Cache == null)
            return false;
        try {
            const arrXzMajorDirection_Sel = arrXzMajorDirectionObjLst_Cache.filter(x => x.majorDirectionId == strMajorDirectionId);
            if (arrXzMajorDirection_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strMajorDirectionId, exports.xzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.XzMajorDirection_IsExist_Cache = XzMajorDirection_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strMajorDirectionId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function XzMajorDirection_IsExistAsync(strMajorDirectionId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strMajorDirectionId": strMajorDirectionId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_IsExistAsync = XzMajorDirection_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function XzMajorDirection_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_GetRecCountByCondAsync = XzMajorDirection_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objXzMajorDirection_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function XzMajorDirection_GetRecCountByCond_Cache(objXzMajorDirection_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrXzMajorDirectionObjLst_Cache = await XzMajorDirection_GetObjLst_Cache();
        if (arrXzMajorDirectionObjLst_Cache == null)
            return 0;
        let arrXzMajorDirection_Sel = arrXzMajorDirectionObjLst_Cache;
        if (objXzMajorDirection_Cond.sf_FldComparisonOp == null || objXzMajorDirection_Cond.sf_FldComparisonOp == "")
            return arrXzMajorDirection_Sel.length;
        const dicFldComparisonOp = JSON.parse(objXzMajorDirection_Cond.sf_FldComparisonOp);
        //console.log("clsXzMajorDirectionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzMajorDirection_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajorDirection_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzMajorDirection_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objXzMajorDirection_Cond), exports.xzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.XzMajorDirection_GetRecCountByCond_Cache = XzMajorDirection_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function XzMajorDirection_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_GetMaxStrIdAsync = XzMajorDirection_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function XzMajorDirection_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorDirection_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorDirection_GetMaxStrIdByPrefix = XzMajorDirection_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function XzMajorDirection_GetWebApiUrl(strController, strAction) {
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
    exports.XzMajorDirection_GetWebApiUrl = XzMajorDirection_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function XzMajorDirection_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN._CurrTabName;
        switch (clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.CacheModeId) {
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
        (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_ReFreshThisCache)();
    }
    exports.XzMajorDirection_ReFreshCache = XzMajorDirection_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function XzMajorDirection_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN._CurrTabName;
            switch (clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.CacheModeId) {
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
    exports.XzMajorDirection_ReFreshThisCache = XzMajorDirection_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function XzMajorDirection__Cache(strDivName, strDdlName) {
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
        const arrObjLst_Sel = await XzMajorDirection_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionId, clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionName, "专业方向");
    }
    exports.XzMajorDirection__Cache = XzMajorDirection__Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzMajorDirection_CheckPropertyNew(pobjXzMajorDirectionEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.id_XzMajor) === true
            || pobjXzMajorDirectionEN.id_XzMajor.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[专业流水号]不能为空(In 专业方向)!(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionName) === true) {
            throw new Error("(errid:Watl000058)字段[研究方向名]不能为空(In 专业方向)!(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if (null === pobjXzMajorDirectionEN.isVisible
            || pobjXzMajorDirectionEN.isVisible != null && pobjXzMajorDirectionEN.isVisible.toString() === "") {
            throw new Error("(errid:Watl000058)字段[是否显示]不能为空(In 专业方向)!(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.updUser) === true) {
            throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 专业方向)!(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionId) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorDirectionEN.majorDirectionId) > 8) {
            throw new Error("(errid:Watl000059)字段[研究方向Id(majorDirectionId)]的长度不能超过8(In 专业方向(XzMajorDirection))!值:$(pobjXzMajorDirectionEN.majorDirectionId)(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.id_XzMajor) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorDirectionEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000059)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 专业方向(XzMajorDirection))!值:$(pobjXzMajorDirectionEN.id_XzMajor)(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionName) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorDirectionEN.majorDirectionName) > 100) {
            throw new Error("(errid:Watl000059)字段[研究方向名(majorDirectionName)]的长度不能超过100(In 专业方向(XzMajorDirection))!值:$(pobjXzMajorDirectionEN.majorDirectionName)(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionENName) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorDirectionEN.majorDirectionENName) > 200) {
            throw new Error("(errid:Watl000059)字段[研究方向英文名(majorDirectionENName)]的长度不能超过200(In 专业方向(XzMajorDirection))!值:$(pobjXzMajorDirectionEN.majorDirectionENName)(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionExplain) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorDirectionEN.majorDirectionExplain) > 2000) {
            throw new Error("(errid:Watl000059)字段[专业方向说明(majorDirectionExplain)]的长度不能超过2000(In 专业方向(XzMajorDirection))!值:$(pobjXzMajorDirectionEN.majorDirectionExplain)(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorDirectionEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 专业方向(XzMajorDirection))!值:$(pobjXzMajorDirectionEN.updDate)(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorDirectionEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 专业方向(XzMajorDirection))!值:$(pobjXzMajorDirectionEN.updUser)(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorDirectionEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 专业方向(XzMajorDirection))!值:$(pobjXzMajorDirectionEN.memo)(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionId) == false && undefined !== pobjXzMajorDirectionEN.majorDirectionId && jsString_js_1.tzDataType.isString(pobjXzMajorDirectionEN.majorDirectionId) === false) {
            throw new Error("(errid:Watl000060)字段[研究方向Id(majorDirectionId)]的值:[$(pobjXzMajorDirectionEN.majorDirectionId)], 非法，应该为字符型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.id_XzMajor) == false && undefined !== pobjXzMajorDirectionEN.id_XzMajor && jsString_js_1.tzDataType.isString(pobjXzMajorDirectionEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000060)字段[专业流水号(id_XzMajor)]的值:[$(pobjXzMajorDirectionEN.id_XzMajor)], 非法，应该为字符型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionName) == false && undefined !== pobjXzMajorDirectionEN.majorDirectionName && jsString_js_1.tzDataType.isString(pobjXzMajorDirectionEN.majorDirectionName) === false) {
            throw new Error("(errid:Watl000060)字段[研究方向名(majorDirectionName)]的值:[$(pobjXzMajorDirectionEN.majorDirectionName)], 非法，应该为字符型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionENName) == false && undefined !== pobjXzMajorDirectionEN.majorDirectionENName && jsString_js_1.tzDataType.isString(pobjXzMajorDirectionEN.majorDirectionENName) === false) {
            throw new Error("(errid:Watl000060)字段[研究方向英文名(majorDirectionENName)]的值:[$(pobjXzMajorDirectionEN.majorDirectionENName)], 非法，应该为字符型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionExplain) == false && undefined !== pobjXzMajorDirectionEN.majorDirectionExplain && jsString_js_1.tzDataType.isString(pobjXzMajorDirectionEN.majorDirectionExplain) === false) {
            throw new Error("(errid:Watl000060)字段[专业方向说明(majorDirectionExplain)]的值:[$(pobjXzMajorDirectionEN.majorDirectionExplain)], 非法，应该为字符型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if (null != pobjXzMajorDirectionEN.isVisible && undefined !== pobjXzMajorDirectionEN.isVisible && jsString_js_1.tzDataType.isBoolean(pobjXzMajorDirectionEN.isVisible) === false) {
            throw new Error("(errid:Watl000060)字段[是否显示(isVisible)]的值:[$(pobjXzMajorDirectionEN.isVisible)], 非法，应该为布尔型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.updDate) == false && undefined !== pobjXzMajorDirectionEN.updDate && jsString_js_1.tzDataType.isString(pobjXzMajorDirectionEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjXzMajorDirectionEN.updDate)], 非法，应该为字符型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.updUser) == false && undefined !== pobjXzMajorDirectionEN.updUser && jsString_js_1.tzDataType.isString(pobjXzMajorDirectionEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjXzMajorDirectionEN.updUser)], 非法，应该为字符型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.memo) == false && undefined !== pobjXzMajorDirectionEN.memo && jsString_js_1.tzDataType.isString(pobjXzMajorDirectionEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjXzMajorDirectionEN.memo)], 非法，应该为字符型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjXzMajorDirectionEN.SetIsCheckProperty(true);
    }
    exports.XzMajorDirection_CheckPropertyNew = XzMajorDirection_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzMajorDirection_CheckProperty4Update(pobjXzMajorDirectionEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionId) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorDirectionEN.majorDirectionId) > 8) {
            throw new Error("(errid:Watl000062)字段[研究方向Id(majorDirectionId)]的长度不能超过8(In 专业方向(XzMajorDirection))!值:$(pobjXzMajorDirectionEN.majorDirectionId)(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.id_XzMajor) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorDirectionEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000062)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 专业方向(XzMajorDirection))!值:$(pobjXzMajorDirectionEN.id_XzMajor)(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionName) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorDirectionEN.majorDirectionName) > 100) {
            throw new Error("(errid:Watl000062)字段[研究方向名(majorDirectionName)]的长度不能超过100(In 专业方向(XzMajorDirection))!值:$(pobjXzMajorDirectionEN.majorDirectionName)(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionENName) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorDirectionEN.majorDirectionENName) > 200) {
            throw new Error("(errid:Watl000062)字段[研究方向英文名(majorDirectionENName)]的长度不能超过200(In 专业方向(XzMajorDirection))!值:$(pobjXzMajorDirectionEN.majorDirectionENName)(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionExplain) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorDirectionEN.majorDirectionExplain) > 2000) {
            throw new Error("(errid:Watl000062)字段[专业方向说明(majorDirectionExplain)]的长度不能超过2000(In 专业方向(XzMajorDirection))!值:$(pobjXzMajorDirectionEN.majorDirectionExplain)(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorDirectionEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 专业方向(XzMajorDirection))!值:$(pobjXzMajorDirectionEN.updDate)(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorDirectionEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 专业方向(XzMajorDirection))!值:$(pobjXzMajorDirectionEN.updUser)(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorDirectionEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 专业方向(XzMajorDirection))!值:$(pobjXzMajorDirectionEN.memo)(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionId) == false && undefined !== pobjXzMajorDirectionEN.majorDirectionId && jsString_js_1.tzDataType.isString(pobjXzMajorDirectionEN.majorDirectionId) === false) {
            throw new Error("(errid:Watl000063)字段[研究方向Id(majorDirectionId)]的值:[$(pobjXzMajorDirectionEN.majorDirectionId)], 非法，应该为字符型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.id_XzMajor) == false && undefined !== pobjXzMajorDirectionEN.id_XzMajor && jsString_js_1.tzDataType.isString(pobjXzMajorDirectionEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000063)字段[专业流水号(id_XzMajor)]的值:[$(pobjXzMajorDirectionEN.id_XzMajor)], 非法，应该为字符型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionName) == false && undefined !== pobjXzMajorDirectionEN.majorDirectionName && jsString_js_1.tzDataType.isString(pobjXzMajorDirectionEN.majorDirectionName) === false) {
            throw new Error("(errid:Watl000063)字段[研究方向名(majorDirectionName)]的值:[$(pobjXzMajorDirectionEN.majorDirectionName)], 非法，应该为字符型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionENName) == false && undefined !== pobjXzMajorDirectionEN.majorDirectionENName && jsString_js_1.tzDataType.isString(pobjXzMajorDirectionEN.majorDirectionENName) === false) {
            throw new Error("(errid:Watl000063)字段[研究方向英文名(majorDirectionENName)]的值:[$(pobjXzMajorDirectionEN.majorDirectionENName)], 非法，应该为字符型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionExplain) == false && undefined !== pobjXzMajorDirectionEN.majorDirectionExplain && jsString_js_1.tzDataType.isString(pobjXzMajorDirectionEN.majorDirectionExplain) === false) {
            throw new Error("(errid:Watl000063)字段[专业方向说明(majorDirectionExplain)]的值:[$(pobjXzMajorDirectionEN.majorDirectionExplain)], 非法，应该为字符型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        if (null != pobjXzMajorDirectionEN.isVisible && undefined !== pobjXzMajorDirectionEN.isVisible && jsString_js_1.tzDataType.isBoolean(pobjXzMajorDirectionEN.isVisible) === false) {
            throw new Error("(errid:Watl000063)字段[是否显示(isVisible)]的值:[$(pobjXzMajorDirectionEN.isVisible)], 非法，应该为布尔型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.updDate) == false && undefined !== pobjXzMajorDirectionEN.updDate && jsString_js_1.tzDataType.isString(pobjXzMajorDirectionEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjXzMajorDirectionEN.updDate)], 非法，应该为字符型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.updUser) == false && undefined !== pobjXzMajorDirectionEN.updUser && jsString_js_1.tzDataType.isString(pobjXzMajorDirectionEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjXzMajorDirectionEN.updUser)], 非法，应该为字符型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.memo) == false && undefined !== pobjXzMajorDirectionEN.memo && jsString_js_1.tzDataType.isString(pobjXzMajorDirectionEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjXzMajorDirectionEN.memo)], 非法，应该为字符型(In 专业方向(XzMajorDirection))!(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorDirectionEN.majorDirectionId) === true
            || pobjXzMajorDirectionEN.majorDirectionId.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[研究方向Id]不能为空(In 专业方向)!(clsXzMajorDirectionBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjXzMajorDirectionEN.SetIsCheckProperty(true);
    }
    exports.XzMajorDirection_CheckProperty4Update = XzMajorDirection_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzMajorDirection_GetJSONStrByObj(pobjXzMajorDirectionEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjXzMajorDirectionEN.sf_UpdFldSetStr = pobjXzMajorDirectionEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjXzMajorDirectionEN);
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
    exports.XzMajorDirection_GetJSONStrByObj = XzMajorDirection_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function XzMajorDirection_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrXzMajorDirectionObjLst = new Array();
        if (strJSON === "") {
            return arrXzMajorDirectionObjLst;
        }
        try {
            arrXzMajorDirectionObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrXzMajorDirectionObjLst;
        }
        return arrXzMajorDirectionObjLst;
    }
    exports.XzMajorDirection_GetObjLstByJSONStr = XzMajorDirection_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrXzMajorDirectionObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function XzMajorDirection_GetObjLstByJSONObjLst(arrXzMajorDirectionObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrXzMajorDirectionObjLst = new Array();
        for (const objInFor of arrXzMajorDirectionObjLstS) {
            const obj1 = XzMajorDirection_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrXzMajorDirectionObjLst.push(obj1);
        }
        return arrXzMajorDirectionObjLst;
    }
    exports.XzMajorDirection_GetObjLstByJSONObjLst = XzMajorDirection_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzMajorDirection_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjXzMajorDirectionEN = new clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN();
        if (strJSON === "") {
            return pobjXzMajorDirectionEN;
        }
        try {
            pobjXzMajorDirectionEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjXzMajorDirectionEN;
        }
        return pobjXzMajorDirectionEN;
    }
    exports.XzMajorDirection_GetObjByJSONStr = XzMajorDirection_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function XzMajorDirection_GetCombineCondition(objXzMajorDirection_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objXzMajorDirection_Cond.dicFldComparisonOp, clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionId) == true) {
            const strComparisonOp_MajorDirectionId = objXzMajorDirection_Cond.dicFldComparisonOp[clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionId, objXzMajorDirection_Cond.majorDirectionId, strComparisonOp_MajorDirectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorDirection_Cond.dicFldComparisonOp, clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objXzMajorDirection_Cond.dicFldComparisonOp[clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_id_XzMajor, objXzMajorDirection_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorDirection_Cond.dicFldComparisonOp, clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionName) == true) {
            const strComparisonOp_MajorDirectionName = objXzMajorDirection_Cond.dicFldComparisonOp[clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionName, objXzMajorDirection_Cond.majorDirectionName, strComparisonOp_MajorDirectionName);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorDirection_Cond.dicFldComparisonOp, clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionENName) == true) {
            const strComparisonOp_MajorDirectionENName = objXzMajorDirection_Cond.dicFldComparisonOp[clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionENName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionENName, objXzMajorDirection_Cond.majorDirectionENName, strComparisonOp_MajorDirectionENName);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorDirection_Cond.dicFldComparisonOp, clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionExplain) == true) {
            const strComparisonOp_MajorDirectionExplain = objXzMajorDirection_Cond.dicFldComparisonOp[clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionExplain];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionExplain, objXzMajorDirection_Cond.majorDirectionExplain, strComparisonOp_MajorDirectionExplain);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorDirection_Cond.dicFldComparisonOp, clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_IsVisible) == true) {
            if (objXzMajorDirection_Cond.isVisible == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_IsVisible);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_IsVisible);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorDirection_Cond.dicFldComparisonOp, clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objXzMajorDirection_Cond.dicFldComparisonOp[clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_UpdDate, objXzMajorDirection_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorDirection_Cond.dicFldComparisonOp, clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objXzMajorDirection_Cond.dicFldComparisonOp[clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_UpdUser, objXzMajorDirection_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorDirection_Cond.dicFldComparisonOp, clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_Memo) == true) {
            const strComparisonOp_Memo = objXzMajorDirection_Cond.dicFldComparisonOp[clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_Memo, objXzMajorDirection_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.XzMajorDirection_GetCombineCondition = XzMajorDirection_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--XzMajorDirection(专业方向),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strid_XzMajor: 专业流水号(要求唯一的字段)
    * @param strMajorDirectionName: 研究方向名(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function XzMajorDirection_GetUniCondStr_id_XzMajor_MajorDirectionName(objXzMajorDirectionEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and id_XzMajor = '{0}'", objXzMajorDirectionEN.id_XzMajor);
        strWhereCond += (0, clsString_js_1.Format)(" and MajorDirectionName = '{0}'", objXzMajorDirectionEN.majorDirectionName);
        return strWhereCond;
    }
    exports.XzMajorDirection_GetUniCondStr_id_XzMajor_MajorDirectionName = XzMajorDirection_GetUniCondStr_id_XzMajor_MajorDirectionName;
    /**
    *获取唯一性条件串(Uniqueness)--XzMajorDirection(专业方向),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strid_XzMajor: 专业流水号(要求唯一的字段)
    * @param strMajorDirectionName: 研究方向名(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function XzMajorDirection_GetUniCondStr4Update_id_XzMajor_MajorDirectionName(objXzMajorDirectionEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and MajorDirectionId <> '{0}'", objXzMajorDirectionEN.majorDirectionId);
        strWhereCond += (0, clsString_js_1.Format)(" and id_XzMajor = '{0}'", objXzMajorDirectionEN.id_XzMajor);
        strWhereCond += (0, clsString_js_1.Format)(" and MajorDirectionName = '{0}'", objXzMajorDirectionEN.majorDirectionName);
        return strWhereCond;
    }
    exports.XzMajorDirection_GetUniCondStr4Update_id_XzMajor_MajorDirectionName = XzMajorDirection_GetUniCondStr4Update_id_XzMajor_MajorDirectionName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objXzMajorDirectionENS:源对象
     * @param objXzMajorDirectionENT:目标对象
    */
    function XzMajorDirection_CopyObjTo(objXzMajorDirectionENS, objXzMajorDirectionENT) {
        objXzMajorDirectionENT.majorDirectionId = objXzMajorDirectionENS.majorDirectionId; //研究方向Id
        objXzMajorDirectionENT.id_XzMajor = objXzMajorDirectionENS.id_XzMajor; //专业流水号
        objXzMajorDirectionENT.majorDirectionName = objXzMajorDirectionENS.majorDirectionName; //研究方向名
        objXzMajorDirectionENT.majorDirectionENName = objXzMajorDirectionENS.majorDirectionENName; //研究方向英文名
        objXzMajorDirectionENT.majorDirectionExplain = objXzMajorDirectionENS.majorDirectionExplain; //专业方向说明
        objXzMajorDirectionENT.isVisible = objXzMajorDirectionENS.isVisible; //是否显示
        objXzMajorDirectionENT.updDate = objXzMajorDirectionENS.updDate; //修改日期
        objXzMajorDirectionENT.updUser = objXzMajorDirectionENS.updUser; //修改人
        objXzMajorDirectionENT.memo = objXzMajorDirectionENS.memo; //备注
        objXzMajorDirectionENT.sf_UpdFldSetStr = objXzMajorDirectionENS.updFldString; //sf_UpdFldSetStr
    }
    exports.XzMajorDirection_CopyObjTo = XzMajorDirection_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objXzMajorDirectionENS:源对象
     * @param objXzMajorDirectionENT:目标对象
    */
    function XzMajorDirection_GetObjFromJsonObj(objXzMajorDirectionENS) {
        const objXzMajorDirectionENT = new clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzMajorDirectionENT, objXzMajorDirectionENS);
        return objXzMajorDirectionENT;
    }
    exports.XzMajorDirection_GetObjFromJsonObj = XzMajorDirection_GetObjFromJsonObj;
});
