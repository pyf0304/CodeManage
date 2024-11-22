/**
* 类名:clsgs_ColorWApi
* 表名:gs_Color(01120751)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:36
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培参数(ParameterTable)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/ParameterTable/clsgs_ColorEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_Color_GetObjFromJsonObj = exports.gs_Color_CopyObjTo = exports.gs_Color_GetUniCondStr4Update_ColorId = exports.gs_Color_GetUniCondStr_ColorId = exports.gs_Color_GetCombineCondition = exports.gs_Color_GetObjByJSONStr = exports.gs_Color_GetObjLstByJSONObjLst = exports.gs_Color_GetObjLstByJSONStr = exports.gs_Color_GetJSONStrByObj = exports.gs_Color_CheckProperty4Update = exports.gs_Color_CheckPropertyNew = exports.gs_Color_ReFreshThisCache = exports.gs_Color_ReFreshCache = exports.gs_Color_GetWebApiUrl = exports.gs_Color_GetMaxStrIdByPrefix = exports.gs_Color_GetMaxStrIdAsync = exports.gs_Color_GetRecCountByCond_Cache = exports.gs_Color_GetRecCountByCondAsync = exports.gs_Color_IsExistAsync = exports.gs_Color_IsExist_Cache = exports.gs_Color_IsExist = exports.gs_Color_IsExistRecordAsync = exports.gs_Color_IsExistRecord_Cache = exports.gs_Color_UpdateWithConditionAsync = exports.gs_Color_UpdateRecordAsync = exports.gs_Color_AddNewRecordWithReturnKey = exports.gs_Color_AddNewRecordWithReturnKeyAsync = exports.gs_Color_AddNewRecordWithMaxIdAsync = exports.gs_Color_AddNewRecordAsync = exports.gs_Color_Delgs_ColorsByCondAsync = exports.gs_Color_Delgs_ColorsAsync = exports.gs_Color_DelRecordAsync = exports.gs_Color_GetObjLstByPagerAsync = exports.gs_Color_GetObjLstByPager_Cache = exports.gs_Color_GetObjLstByRange = exports.gs_Color_GetObjLstByRangeAsync = exports.gs_Color_GetTopObjLstAsync = exports.gs_Color_GetObjLstByColorIdLst_Cache = exports.gs_Color_GetObjLstByColorIdLstAsync = exports.gs_Color_GetSubObjLst_Cache = exports.gs_Color_GetObjLst_PureCache = exports.gs_Color_GetObjLst_Cache = exports.gs_Color_GetObjLst_sessionStorage_PureCache = exports.gs_Color_GetObjLst_sessionStorage = exports.gs_Color_GetObjLstAsync = exports.gs_Color_GetObjLst_localStorage_PureCache = exports.gs_Color_GetObjLst_localStorage = exports.gs_Color_GetObjLst_ClientCache = exports.gs_Color_GetFirstObjAsync = exports.gs_Color_GetFirstID = exports.gs_Color_GetFirstIDAsync = exports.gs_Color_FilterFunByKey = exports.gs_Color_SortFunByKey = exports.gs_Color_SortFun_Defa_2Fld = exports.gs_Color_SortFun_Defa = exports.gs_Color_func = exports.gs_Color_UpdateObjInLst_Cache = exports.gs_Color_GetObjByColorId_localStorage = exports.gs_Color_GetObjByColorId_Cache = exports.gs_Color_GetObjByColorIdAsync = exports.gs_Color_ConstructorName = exports.gs_Color_Controller = void 0;
    /**
     * 颜色表(gs_Color)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_ColorEN_js_1 = require("../../L0_Entity/ParameterTable/clsgs_ColorEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_Color_Controller = "gs_ColorApi";
    exports.gs_Color_ConstructorName = "gs_Color";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strColorId:关键字
    * @returns 对象
    **/
    async function gs_Color_GetObjByColorIdAsync(strColorId) {
        const strThisFuncName = "GetObjByColorIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strColorId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strColorId]不能为空！(In GetObjByColorIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strColorId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strColorId]的长度:[{0}]不正确！", strColorId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByColorId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strColorId": strColorId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_Color_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_Color = gs_Color_GetObjFromJsonObj(returnObj);
                return objgs_Color;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_GetObjByColorIdAsync = gs_Color_GetObjByColorIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strColorId:所给的关键字
     * @returns 对象
    */
    async function gs_Color_GetObjByColorId_Cache(strColorId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByColorId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strColorId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strColorId]不能为空！(In GetObjByColorId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strColorId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strColorId]的长度:[{0}]不正确！", strColorId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_Cache();
        try {
            const arrgs_Color_Sel = arrgs_ColorObjLst_Cache.filter(x => x.colorId == strColorId);
            let objgs_Color;
            if (arrgs_Color_Sel.length > 0) {
                objgs_Color = arrgs_Color_Sel[0];
                return objgs_Color;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objgs_Color = await gs_Color_GetObjByColorIdAsync(strColorId);
                    if (objgs_Color != null) {
                        gs_Color_ReFreshThisCache();
                        return objgs_Color;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strColorId, exports.gs_Color_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_Color_GetObjByColorId_Cache = gs_Color_GetObjByColorId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strColorId:所给的关键字
     * @returns 对象
    */
    async function gs_Color_GetObjByColorId_localStorage(strColorId) {
        const strThisFuncName = "GetObjByColorId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strColorId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strColorId]不能为空！(In GetObjByColorId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strColorId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strColorId]的长度:[{0}]不正确！", strColorId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_ColorEN_js_1.clsgs_ColorEN._CurrTabName, strColorId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_Color_Cache = JSON.parse(strTempObj);
            return objgs_Color_Cache;
        }
        try {
            const objgs_Color = await gs_Color_GetObjByColorIdAsync(strColorId);
            if (objgs_Color != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_Color));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_Color;
            }
            return objgs_Color;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strColorId, exports.gs_Color_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_Color_GetObjByColorId_localStorage = gs_Color_GetObjByColorId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_Color:所给的对象
     * @returns 对象
    */
    async function gs_Color_UpdateObjInLst_Cache(objgs_Color) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_Cache();
            const obj = arrgs_ColorObjLst_Cache.find(x => x.colorId == objgs_Color.colorId);
            if (obj != null) {
                objgs_Color.colorId = obj.colorId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_Color);
            }
            else {
                arrgs_ColorObjLst_Cache.push(objgs_Color);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_Color_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_Color_UpdateObjInLst_Cache = gs_Color_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
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
    async function gs_Color_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsgs_ColorEN_js_1.clsgs_ColorEN.con_ColorId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_ColorEN_js_1.clsgs_ColorEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsgs_ColorEN_js_1.clsgs_ColorEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strColorId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objgs_Color = await gs_Color_GetObjByColorId_Cache(strColorId);
        if (objgs_Color == null)
            return "";
        return objgs_Color.GetFldValue(strOutFldName).toString();
    }
    exports.gs_Color_func = gs_Color_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_Color_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.colorId.localeCompare(b.colorId);
    }
    exports.gs_Color_SortFun_Defa = gs_Color_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_Color_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.userNo == b.userNo)
            return a.colorCode.localeCompare(b.colorCode);
        else
            return a.userNo - b.userNo;
    }
    exports.gs_Color_SortFun_Defa_2Fld = gs_Color_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_Color_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_ColorEN_js_1.clsgs_ColorEN.con_ColorId:
                    return (a, b) => {
                        return a.colorId.localeCompare(b.colorId);
                    };
                case clsgs_ColorEN_js_1.clsgs_ColorEN.con_UserNo:
                    return (a, b) => {
                        return a.userNo - b.userNo;
                    };
                case clsgs_ColorEN_js_1.clsgs_ColorEN.con_ColorCode:
                    return (a, b) => {
                        return a.colorCode.localeCompare(b.colorCode);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_Color]中不存在！(in ${exports.gs_Color_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_ColorEN_js_1.clsgs_ColorEN.con_ColorId:
                    return (a, b) => {
                        return b.colorId.localeCompare(a.colorId);
                    };
                case clsgs_ColorEN_js_1.clsgs_ColorEN.con_UserNo:
                    return (a, b) => {
                        return b.userNo - a.userNo;
                    };
                case clsgs_ColorEN_js_1.clsgs_ColorEN.con_ColorCode:
                    return (a, b) => {
                        return b.colorCode.localeCompare(a.colorCode);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_Color]中不存在！(in ${exports.gs_Color_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_Color_SortFunByKey = gs_Color_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_Color_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_ColorEN_js_1.clsgs_ColorEN.con_ColorId:
                return (obj) => {
                    return obj.colorId === value;
                };
            case clsgs_ColorEN_js_1.clsgs_ColorEN.con_UserNo:
                return (obj) => {
                    return obj.userNo === value;
                };
            case clsgs_ColorEN_js_1.clsgs_ColorEN.con_ColorCode:
                return (obj) => {
                    return obj.colorCode === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_Color]中不存在！(in ${exports.gs_Color_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_Color_FilterFunByKey = gs_Color_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_Color_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_GetFirstIDAsync = gs_Color_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_Color_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_GetFirstID = gs_Color_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_Color_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_Color_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_Color = gs_Color_GetObjFromJsonObj(returnObj);
                return objgs_Color;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_GetFirstObjAsync = gs_Color_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_Color_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_ColorEN_js_1.clsgs_ColorEN._CurrTabName;
        clsgs_ColorEN_js_1.clsgs_ColorEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_ColorEN_js_1.clsgs_ColorEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_ColorEN_js_1.clsgs_ColorEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_ColorEN_js_1.clsgs_ColorEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_ColorExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrgs_ColorObjLst_T = gs_Color_GetObjLstByJSONObjLst(arrgs_ColorExObjLst_Cache);
            return arrgs_ColorObjLst_T;
        }
        try {
            const arrgs_ColorExObjLst = await gs_Color_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrgs_ColorExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ColorExObjLst.length);
            console.log(strInfo);
            return arrgs_ColorExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_Color_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_Color_GetObjLst_ClientCache = gs_Color_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_Color_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_ColorEN_js_1.clsgs_ColorEN._CurrTabName;
        clsgs_ColorEN_js_1.clsgs_ColorEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_ColorEN_js_1.clsgs_ColorEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_ColorEN_js_1.clsgs_ColorEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_ColorEN_js_1.clsgs_ColorEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_ColorExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_ColorObjLst_T = gs_Color_GetObjLstByJSONObjLst(arrgs_ColorExObjLst_Cache);
            return arrgs_ColorObjLst_T;
        }
        try {
            const arrgs_ColorExObjLst = await gs_Color_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_ColorExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ColorExObjLst.length);
            console.log(strInfo);
            return arrgs_ColorExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_Color_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_Color_GetObjLst_localStorage = gs_Color_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_Color_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_ColorEN_js_1.clsgs_ColorEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_ColorObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_ColorObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_Color_GetObjLst_localStorage_PureCache = gs_Color_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_Color_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_Color_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_Color_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_GetObjLstAsync = gs_Color_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_Color_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_ColorEN_js_1.clsgs_ColorEN._CurrTabName;
        clsgs_ColorEN_js_1.clsgs_ColorEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_ColorEN_js_1.clsgs_ColorEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_ColorEN_js_1.clsgs_ColorEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_ColorEN_js_1.clsgs_ColorEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_ColorExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_ColorObjLst_T = gs_Color_GetObjLstByJSONObjLst(arrgs_ColorExObjLst_Cache);
            return arrgs_ColorObjLst_T;
        }
        try {
            const arrgs_ColorExObjLst = await gs_Color_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_ColorExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ColorExObjLst.length);
            console.log(strInfo);
            return arrgs_ColorExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_Color_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_Color_GetObjLst_sessionStorage = gs_Color_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_Color_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_ColorEN_js_1.clsgs_ColorEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_ColorObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_ColorObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_Color_GetObjLst_sessionStorage_PureCache = gs_Color_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_Color_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrgs_ColorObjLst_Cache;
        switch (clsgs_ColorEN_js_1.clsgs_ColorEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_ClientCache();
                break;
            default:
                arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_ClientCache();
                break;
        }
        const arrgs_ColorObjLst = gs_Color_GetObjLstByJSONObjLst(arrgs_ColorObjLst_Cache);
        return arrgs_ColorObjLst_Cache;
    }
    exports.gs_Color_GetObjLst_Cache = gs_Color_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_Color_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_ColorObjLst_Cache;
        switch (clsgs_ColorEN_js_1.clsgs_ColorEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrgs_ColorObjLst_Cache = null;
                break;
            default:
                arrgs_ColorObjLst_Cache = null;
                break;
        }
        return arrgs_ColorObjLst_Cache;
    }
    exports.gs_Color_GetObjLst_PureCache = gs_Color_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrColorId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_Color_GetSubObjLst_Cache(objgs_Color_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_Cache();
        let arrgs_Color_Sel = arrgs_ColorObjLst_Cache;
        if (objgs_Color_Cond.sf_FldComparisonOp == null || objgs_Color_Cond.sf_FldComparisonOp == "")
            return arrgs_Color_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_Color_Cond.sf_FldComparisonOp);
        //console.log("clsgs_ColorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_Color_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_Color_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_Color_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_Color_Cond), exports.gs_Color_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_Color_GetSubObjLst_Cache = gs_Color_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrColorId:关键字列表
    * @returns 对象列表
    **/
    async function gs_Color_GetObjLstByColorIdLstAsync(arrColorId) {
        const strThisFuncName = "GetObjLstByColorIdLstAsync";
        const strAction = "GetObjLstByColorIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrColorId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_Color_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_Color_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_GetObjLstByColorIdLstAsync = gs_Color_GetObjLstByColorIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrColorIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_Color_GetObjLstByColorIdLst_Cache(arrColorIdLst) {
        const strThisFuncName = "GetObjLstByColorIdLst_Cache";
        try {
            const arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_Cache();
            const arrgs_Color_Sel = arrgs_ColorObjLst_Cache.filter(x => arrColorIdLst.indexOf(x.colorId) > -1);
            return arrgs_Color_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrColorIdLst.join(","), exports.gs_Color_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_Color_GetObjLstByColorIdLst_Cache = gs_Color_GetObjLstByColorIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_Color_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_Color_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_Color_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_GetTopObjLstAsync = gs_Color_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_Color_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_Color_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_Color_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_GetObjLstByRangeAsync = gs_Color_GetObjLstByRangeAsync;
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
    async function gs_Color_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_GetObjLstByRange = gs_Color_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_Color_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_Cache();
        if (arrgs_ColorObjLst_Cache.length == 0)
            return arrgs_ColorObjLst_Cache;
        let arrgs_Color_Sel = arrgs_ColorObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_Color_Cond = new clsgs_ColorEN_js_1.clsgs_ColorEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_Color_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_ColorWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_Color_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_Color_Sel.length == 0)
                return arrgs_Color_Sel;
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
                arrgs_Color_Sel = arrgs_Color_Sel.sort(gs_Color_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_Color_Sel = arrgs_Color_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_Color_Sel = arrgs_Color_Sel.slice(intStart, intEnd);
            return arrgs_Color_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_Color_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_Color_GetObjLstByPager_Cache = gs_Color_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_Color_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_Color_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_Color_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_GetObjLstByPagerAsync = gs_Color_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strColorId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_Color_DelRecordAsync(strColorId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strColorId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strColorId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_DelRecordAsync = gs_Color_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrColorId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_Color_Delgs_ColorsAsync(arrColorId) {
        const strThisFuncName = "Delgs_ColorsAsync";
        const strAction = "Delgs_Colors";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrColorId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_Delgs_ColorsAsync = gs_Color_Delgs_ColorsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_Color_Delgs_ColorsByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_ColorsByCondAsync";
        const strAction = "Delgs_ColorsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_Delgs_ColorsByCondAsync = gs_Color_Delgs_ColorsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_ColorEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_Color_AddNewRecordAsync(objgs_ColorEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_ColorEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ColorEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_AddNewRecordAsync = gs_Color_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_ColorEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_Color_AddNewRecordWithMaxIdAsync(objgs_ColorEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ColorEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_AddNewRecordWithMaxIdAsync = gs_Color_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_ColorEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_Color_AddNewRecordWithReturnKeyAsync(objgs_ColorEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ColorEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_AddNewRecordWithReturnKeyAsync = gs_Color_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_ColorEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_Color_AddNewRecordWithReturnKey(objgs_ColorEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_ColorEN.colorId === null || objgs_ColorEN.colorId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ColorEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_AddNewRecordWithReturnKey = gs_Color_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_ColorEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_Color_UpdateRecordAsync(objgs_ColorEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_ColorEN.sf_UpdFldSetStr === undefined || objgs_ColorEN.sf_UpdFldSetStr === null || objgs_ColorEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ColorEN.colorId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ColorEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_UpdateRecordAsync = gs_Color_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_ColorEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_Color_UpdateWithConditionAsync(objgs_ColorEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_ColorEN.sf_UpdFldSetStr === undefined || objgs_ColorEN.sf_UpdFldSetStr === null || objgs_ColorEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ColorEN.colorId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        objgs_ColorEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_ColorEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_UpdateWithConditionAsync = gs_Color_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrColorId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_Color_IsExistRecord_Cache(objgs_Color_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_Cache();
        if (arrgs_ColorObjLst_Cache == null)
            return false;
        let arrgs_Color_Sel = arrgs_ColorObjLst_Cache;
        if (objgs_Color_Cond.sf_FldComparisonOp == null || objgs_Color_Cond.sf_FldComparisonOp == "")
            return arrgs_Color_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_Color_Cond.sf_FldComparisonOp);
        //console.log("clsgs_ColorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_Color_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_Color_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_Color_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_Color_Cond), exports.gs_Color_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_Color_IsExistRecord_Cache = gs_Color_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_Color_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_IsExistRecordAsync = gs_Color_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strColorId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_Color_IsExist(strColorId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ColorId": strColorId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_IsExist = gs_Color_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strColorId:所给的关键字
     * @returns 对象
    */
    async function gs_Color_IsExist_Cache(strColorId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_Cache();
        if (arrgs_ColorObjLst_Cache == null)
            return false;
        try {
            const arrgs_Color_Sel = arrgs_ColorObjLst_Cache.filter(x => x.colorId == strColorId);
            if (arrgs_Color_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strColorId, exports.gs_Color_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_Color_IsExist_Cache = gs_Color_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strColorId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_Color_IsExistAsync(strColorId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strColorId": strColorId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_IsExistAsync = gs_Color_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_Color_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_GetRecCountByCondAsync = gs_Color_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_Color_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_Color_GetRecCountByCond_Cache(objgs_Color_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_Cache();
        if (arrgs_ColorObjLst_Cache == null)
            return 0;
        let arrgs_Color_Sel = arrgs_ColorObjLst_Cache;
        if (objgs_Color_Cond.sf_FldComparisonOp == null || objgs_Color_Cond.sf_FldComparisonOp == "")
            return arrgs_Color_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_Color_Cond.sf_FldComparisonOp);
        //console.log("clsgs_ColorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_Color_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_Color_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_Color_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_Color_Cond), exports.gs_Color_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_Color_GetRecCountByCond_Cache = gs_Color_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function gs_Color_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_GetMaxStrIdAsync = gs_Color_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_Color_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_Color_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_Color_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_Color_GetMaxStrIdByPrefix = gs_Color_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_Color_GetWebApiUrl(strController, strAction) {
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
    exports.gs_Color_GetWebApiUrl = gs_Color_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_Color_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsgs_ColorEN_js_1.clsgs_ColorEN._CurrTabName;
        switch (clsgs_ColorEN_js_1.clsgs_ColorEN.CacheModeId) {
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
    exports.gs_Color_ReFreshCache = gs_Color_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_Color_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsgs_ColorEN_js_1.clsgs_ColorEN._CurrTabName;
            switch (clsgs_ColorEN_js_1.clsgs_ColorEN.CacheModeId) {
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
    exports.gs_Color_ReFreshThisCache = gs_Color_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_Color_CheckPropertyNew(pobjgs_ColorEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ColorEN.colorId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ColorEN.colorId) > 2) {
            throw new Error("(errid:Watl000059)字段[颜色Id(colorId)]的长度不能超过2(In 颜色表(gs_Color))!值:$(pobjgs_ColorEN.colorId)(clsgs_ColorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ColorEN.colorCode) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ColorEN.colorCode) > 200) {
            throw new Error("(errid:Watl000059)字段[颜色码(colorCode)]的长度不能超过200(In 颜色表(gs_Color))!值:$(pobjgs_ColorEN.colorCode)(clsgs_ColorBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ColorEN.colorId) == false && undefined !== pobjgs_ColorEN.colorId && jsString_js_1.tzDataType.isString(pobjgs_ColorEN.colorId) === false) {
            throw new Error("(errid:Watl000060)字段[颜色Id(colorId)]的值:[$(pobjgs_ColorEN.colorId)], 非法，应该为字符型(In 颜色表(gs_Color))!(clsgs_ColorBL:CheckPropertyNew)");
        }
        if (null != pobjgs_ColorEN.userNo && undefined !== pobjgs_ColorEN.userNo && jsString_js_1.tzDataType.isNumber(pobjgs_ColorEN.userNo) === false) {
            throw new Error("(errid:Watl000060)字段[用户号(userNo)]的值:[$(pobjgs_ColorEN.userNo)], 非法，应该为数值型(In 颜色表(gs_Color))!(clsgs_ColorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ColorEN.colorCode) == false && undefined !== pobjgs_ColorEN.colorCode && jsString_js_1.tzDataType.isString(pobjgs_ColorEN.colorCode) === false) {
            throw new Error("(errid:Watl000060)字段[颜色码(colorCode)]的值:[$(pobjgs_ColorEN.colorCode)], 非法，应该为字符型(In 颜色表(gs_Color))!(clsgs_ColorBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_ColorEN.SetIsCheckProperty(true);
    }
    exports.gs_Color_CheckPropertyNew = gs_Color_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_Color_CheckProperty4Update(pobjgs_ColorEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ColorEN.colorId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ColorEN.colorId) > 2) {
            throw new Error("(errid:Watl000062)字段[颜色Id(colorId)]的长度不能超过2(In 颜色表(gs_Color))!值:$(pobjgs_ColorEN.colorId)(clsgs_ColorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ColorEN.colorCode) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ColorEN.colorCode) > 200) {
            throw new Error("(errid:Watl000062)字段[颜色码(colorCode)]的长度不能超过200(In 颜色表(gs_Color))!值:$(pobjgs_ColorEN.colorCode)(clsgs_ColorBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ColorEN.colorId) == false && undefined !== pobjgs_ColorEN.colorId && jsString_js_1.tzDataType.isString(pobjgs_ColorEN.colorId) === false) {
            throw new Error("(errid:Watl000063)字段[颜色Id(colorId)]的值:[$(pobjgs_ColorEN.colorId)], 非法，应该为字符型(In 颜色表(gs_Color))!(clsgs_ColorBL:CheckProperty4Update)");
        }
        if (null != pobjgs_ColorEN.userNo && undefined !== pobjgs_ColorEN.userNo && jsString_js_1.tzDataType.isNumber(pobjgs_ColorEN.userNo) === false) {
            throw new Error("(errid:Watl000063)字段[用户号(userNo)]的值:[$(pobjgs_ColorEN.userNo)], 非法，应该为数值型(In 颜色表(gs_Color))!(clsgs_ColorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ColorEN.colorCode) == false && undefined !== pobjgs_ColorEN.colorCode && jsString_js_1.tzDataType.isString(pobjgs_ColorEN.colorCode) === false) {
            throw new Error("(errid:Watl000063)字段[颜色码(colorCode)]的值:[$(pobjgs_ColorEN.colorCode)], 非法，应该为字符型(In 颜色表(gs_Color))!(clsgs_ColorBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ColorEN.colorId) === true) {
            throw new Error("(errid:Watl000064)字段[颜色Id]不能为空(In 颜色表)!(clsgs_ColorBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_ColorEN.SetIsCheckProperty(true);
    }
    exports.gs_Color_CheckProperty4Update = gs_Color_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_Color_GetJSONStrByObj(pobjgs_ColorEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_ColorEN.sf_UpdFldSetStr = pobjgs_ColorEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_ColorEN);
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
    exports.gs_Color_GetJSONStrByObj = gs_Color_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_Color_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_ColorObjLst = new Array();
        if (strJSON === "") {
            return arrgs_ColorObjLst;
        }
        try {
            arrgs_ColorObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_ColorObjLst;
        }
        return arrgs_ColorObjLst;
    }
    exports.gs_Color_GetObjLstByJSONStr = gs_Color_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_ColorObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_Color_GetObjLstByJSONObjLst(arrgs_ColorObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_ColorObjLst = new Array();
        for (const objInFor of arrgs_ColorObjLstS) {
            const obj1 = gs_Color_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_ColorObjLst.push(obj1);
        }
        return arrgs_ColorObjLst;
    }
    exports.gs_Color_GetObjLstByJSONObjLst = gs_Color_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_Color_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_ColorEN = new clsgs_ColorEN_js_1.clsgs_ColorEN();
        if (strJSON === "") {
            return pobjgs_ColorEN;
        }
        try {
            pobjgs_ColorEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_ColorEN;
        }
        return pobjgs_ColorEN;
    }
    exports.gs_Color_GetObjByJSONStr = gs_Color_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_Color_GetCombineCondition(objgs_Color_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_Color_Cond.dicFldComparisonOp, clsgs_ColorEN_js_1.clsgs_ColorEN.con_ColorId) == true) {
            const strComparisonOp_ColorId = objgs_Color_Cond.dicFldComparisonOp[clsgs_ColorEN_js_1.clsgs_ColorEN.con_ColorId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ColorEN_js_1.clsgs_ColorEN.con_ColorId, objgs_Color_Cond.colorId, strComparisonOp_ColorId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Color_Cond.dicFldComparisonOp, clsgs_ColorEN_js_1.clsgs_ColorEN.con_UserNo) == true) {
            const strComparisonOp_UserNo = objgs_Color_Cond.dicFldComparisonOp[clsgs_ColorEN_js_1.clsgs_ColorEN.con_UserNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_ColorEN_js_1.clsgs_ColorEN.con_UserNo, objgs_Color_Cond.userNo, strComparisonOp_UserNo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_Color_Cond.dicFldComparisonOp, clsgs_ColorEN_js_1.clsgs_ColorEN.con_ColorCode) == true) {
            const strComparisonOp_ColorCode = objgs_Color_Cond.dicFldComparisonOp[clsgs_ColorEN_js_1.clsgs_ColorEN.con_ColorCode];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ColorEN_js_1.clsgs_ColorEN.con_ColorCode, objgs_Color_Cond.colorCode, strComparisonOp_ColorCode);
        }
        return strWhereCond;
    }
    exports.gs_Color_GetCombineCondition = gs_Color_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_Color(颜色表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strColorId: 颜色Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_Color_GetUniCondStr_ColorId(objgs_ColorEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ColorId = '{0}'", objgs_ColorEN.colorId);
        return strWhereCond;
    }
    exports.gs_Color_GetUniCondStr_ColorId = gs_Color_GetUniCondStr_ColorId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_Color(颜色表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strColorId: 颜色Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_Color_GetUniCondStr4Update_ColorId(objgs_ColorEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ColorId <> '{0}'", objgs_ColorEN.colorId);
        strWhereCond += (0, clsString_js_1.Format)(" and ColorId = '{0}'", objgs_ColorEN.colorId);
        return strWhereCond;
    }
    exports.gs_Color_GetUniCondStr4Update_ColorId = gs_Color_GetUniCondStr4Update_ColorId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_ColorENS:源对象
     * @param objgs_ColorENT:目标对象
    */
    function gs_Color_CopyObjTo(objgs_ColorENS, objgs_ColorENT) {
        objgs_ColorENT.colorId = objgs_ColorENS.colorId; //颜色Id
        objgs_ColorENT.userNo = objgs_ColorENS.userNo; //用户号
        objgs_ColorENT.colorCode = objgs_ColorENS.colorCode; //颜色码
        objgs_ColorENT.sf_UpdFldSetStr = objgs_ColorENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_Color_CopyObjTo = gs_Color_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_ColorENS:源对象
     * @param objgs_ColorENT:目标对象
    */
    function gs_Color_GetObjFromJsonObj(objgs_ColorENS) {
        const objgs_ColorENT = new clsgs_ColorEN_js_1.clsgs_ColorEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_ColorENT, objgs_ColorENS);
        return objgs_ColorENT;
    }
    exports.gs_Color_GetObjFromJsonObj = gs_Color_GetObjFromJsonObj;
});
