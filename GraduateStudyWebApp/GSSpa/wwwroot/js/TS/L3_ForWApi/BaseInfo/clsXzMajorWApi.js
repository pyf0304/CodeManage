/**
* 类名:clsXzMajorWApi
* 表名:XzMajor(01120065)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:07
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/BaseInfo/clsXzMajorEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzMajor_GetObjFromJsonObj = exports.XzMajor_CopyObjTo = exports.XzMajor_GetUniCondStr4Update_id_XzMajor = exports.XzMajor_GetUniCondStr_id_XzMajor = exports.XzMajor_GetCombineCondition = exports.XzMajor_GetObjByJSONStr = exports.XzMajor_GetObjLstByJSONObjLst = exports.XzMajor_GetObjLstByJSONStr = exports.XzMajor_GetJSONStrByObj = exports.XzMajor_CheckProperty4Update = exports.XzMajor_CheckPropertyNew = exports.XzMajor_BindDdl_id_XzMajor_Cache = exports.XzMajor_BindDdl_id_XzMajorByid_XzMajorShoolTypeInDiv_Cache = exports.XzMajor_ReFreshThisCache = exports.XzMajor_ReFreshCache = exports.XzMajor_GetWebApiUrl = exports.XzMajor_GetMaxStrIdByPrefix = exports.XzMajor_GetMaxStrIdAsync = exports.XzMajor_GetRecCountByCond_Cache = exports.XzMajor_GetRecCountByCondAsync = exports.XzMajor_IsExistAsync = exports.XzMajor_IsExist_Cache = exports.XzMajor_IsExist = exports.XzMajor_IsExistRecordAsync = exports.XzMajor_IsExistRecord_Cache = exports.XzMajor_UpdateWithConditionAsync = exports.XzMajor_UpdateRecordAsync = exports.XzMajor_AddNewRecordWithReturnKey = exports.XzMajor_AddNewRecordWithReturnKeyAsync = exports.XzMajor_AddNewRecordWithMaxIdAsync = exports.XzMajor_AddNewRecordAsync = exports.XzMajor_DelXzMajorsByCondAsync = exports.XzMajor_DelXzMajorsAsync = exports.XzMajor_DelRecordAsync = exports.XzMajor_GetObjLstByPagerAsync = exports.XzMajor_GetObjLstByPager_Cache = exports.XzMajor_GetObjLstByRange = exports.XzMajor_GetObjLstByRangeAsync = exports.XzMajor_GetTopObjLstAsync = exports.XzMajor_GetObjLstByid_XzMajorLst_Cache = exports.XzMajor_GetObjLstByid_XzMajorLstAsync = exports.XzMajor_GetSubObjLst_Cache = exports.XzMajor_GetObjLst_PureCache = exports.XzMajor_GetObjLst_Cache = exports.XzMajor_GetObjLst_sessionStorage_PureCache = exports.XzMajor_GetObjLst_sessionStorage = exports.XzMajor_GetObjLstAsync = exports.XzMajor_GetObjLst_localStorage_PureCache = exports.XzMajor_GetObjLst_localStorage = exports.XzMajor_GetObjLst_ClientCache = exports.XzMajor_GetFirstObjAsync = exports.XzMajor_GetFirstID = exports.XzMajor_GetFirstIDAsync = exports.XzMajor_FilterFunByKey = exports.XzMajor_SortFunByKey = exports.XzMajor_SortFun_Defa_2Fld = exports.XzMajor_SortFun_Defa = exports.XzMajor_func = exports.XzMajor_GetNameByid_XzMajor_Cache = exports.XzMajor_UpdateObjInLst_Cache = exports.XzMajor_GetObjByid_XzMajor_localStorage = exports.XzMajor_GetObjByid_XzMajor_Cache = exports.XzMajor_GetObjByid_XzMajorAsync = exports.xzMajor_ConstructorName = exports.xzMajor_Controller = void 0;
    /**
     * 专业(XzMajor)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsXzMajorEN_js_1 = require("../../L0_Entity/BaseInfo/clsXzMajorEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.xzMajor_Controller = "XzMajorApi";
    exports.xzMajor_ConstructorName = "xzMajor";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_XzMajor:关键字
    * @returns 对象
    **/
    async function XzMajor_GetObjByid_XzMajorAsync(strid_XzMajor) {
        const strThisFuncName = "GetObjByid_XzMajorAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzMajor) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzMajor]不能为空！(In GetObjByid_XzMajorAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzMajor.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！", strid_XzMajor.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_XzMajor";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_XzMajor": strid_XzMajor,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajor_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objXzMajor = XzMajor_GetObjFromJsonObj(returnObj);
                return objXzMajor;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_GetObjByid_XzMajorAsync = XzMajor_GetObjByid_XzMajorAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_XzMajor:所给的关键字
     * @returns 对象
    */
    async function XzMajor_GetObjByid_XzMajor_Cache(strid_XzMajor, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_XzMajor_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzMajor) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzMajor]不能为空！(In GetObjByid_XzMajor_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzMajor.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！", strid_XzMajor.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
        try {
            const arrXzMajor_Sel = arrXzMajorObjLst_Cache.filter(x => x.id_XzMajor == strid_XzMajor);
            let objXzMajor;
            if (arrXzMajor_Sel.length > 0) {
                objXzMajor = arrXzMajor_Sel[0];
                return objXzMajor;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objXzMajor = await XzMajor_GetObjByid_XzMajorAsync(strid_XzMajor);
                    if (objXzMajor != null) {
                        XzMajor_ReFreshThisCache();
                        return objXzMajor;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_XzMajor, exports.xzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.XzMajor_GetObjByid_XzMajor_Cache = XzMajor_GetObjByid_XzMajor_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_XzMajor:所给的关键字
     * @returns 对象
    */
    async function XzMajor_GetObjByid_XzMajor_localStorage(strid_XzMajor) {
        const strThisFuncName = "GetObjByid_XzMajor_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzMajor) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzMajor]不能为空！(In GetObjByid_XzMajor_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzMajor.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！", strid_XzMajor.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsXzMajorEN_js_1.clsXzMajorEN._CurrTabName, strid_XzMajor);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objXzMajor_Cache = JSON.parse(strTempObj);
            return objXzMajor_Cache;
        }
        try {
            const objXzMajor = await XzMajor_GetObjByid_XzMajorAsync(strid_XzMajor);
            if (objXzMajor != null) {
                localStorage.setItem(strKey, JSON.stringify(objXzMajor));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objXzMajor;
            }
            return objXzMajor;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_XzMajor, exports.xzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.XzMajor_GetObjByid_XzMajor_localStorage = XzMajor_GetObjByid_XzMajor_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objXzMajor:所给的对象
     * @returns 对象
    */
    async function XzMajor_UpdateObjInLst_Cache(objXzMajor) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
            const obj = arrXzMajorObjLst_Cache.find(x => x.id_XzMajor == objXzMajor.id_XzMajor);
            if (obj != null) {
                objXzMajor.id_XzMajor = obj.id_XzMajor;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objXzMajor);
            }
            else {
                arrXzMajorObjLst_Cache.push(objXzMajor);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.xzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.XzMajor_UpdateObjInLst_Cache = XzMajor_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_XzMajor:所给的关键字
     * @returns 对象
    */
    async function XzMajor_GetNameByid_XzMajor_Cache(strid_XzMajor) {
        const strThisFuncName = "GetNameByid_XzMajor_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzMajor) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzMajor]不能为空！(In GetNameByid_XzMajor_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzMajor.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！", strid_XzMajor.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
        if (arrXzMajorObjLst_Cache == null)
            return "";
        try {
            const arrXzMajor_Sel = arrXzMajorObjLst_Cache.filter(x => x.id_XzMajor == strid_XzMajor);
            let objXzMajor;
            if (arrXzMajor_Sel.length > 0) {
                objXzMajor = arrXzMajor_Sel[0];
                return objXzMajor.majorName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_XzMajor);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.XzMajor_GetNameByid_XzMajor_Cache = XzMajor_GetNameByid_XzMajor_Cache;
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
    async function XzMajor_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsXzMajorEN_js_1.clsXzMajorEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsXzMajorEN_js_1.clsXzMajorEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_XzMajor = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objXzMajor = await XzMajor_GetObjByid_XzMajor_Cache(strid_XzMajor);
        if (objXzMajor == null)
            return "";
        return objXzMajor.GetFldValue(strOutFldName).toString();
    }
    exports.XzMajor_func = XzMajor_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzMajor_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_XzMajor.localeCompare(b.id_XzMajor);
    }
    exports.XzMajor_SortFun_Defa = XzMajor_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzMajor_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.majorID == b.majorID)
            return a.majorName.localeCompare(b.majorName);
        else
            return a.majorID.localeCompare(b.majorID);
    }
    exports.XzMajor_SortFun_Defa_2Fld = XzMajor_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzMajor_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorID:
                    return (a, b) => {
                        return a.majorID.localeCompare(b.majorID);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorEnglishName:
                    return (a, b) => {
                        return a.majorEnglishName.localeCompare(b.majorEnglishName);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorExplain:
                    return (a, b) => {
                        return a.majorExplain.localeCompare(b.majorExplain);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorNationalID:
                    return (a, b) => {
                        return a.majorNationalID.localeCompare(b.majorNationalID);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzCollege:
                    return (a, b) => {
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_id_MajorType:
                    return (a, b) => {
                        return a.id_MajorType.localeCompare(b.id_MajorType);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_id_DegreeType:
                    return (a, b) => {
                        return a.id_DegreeType.localeCompare(b.id_DegreeType);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_IsMainMajor:
                    return (a, b) => {
                        if (a.isMainMajor == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorDirection:
                    return (a, b) => {
                        return a.majorDirection.localeCompare(b.majorDirection);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_IsVisible:
                    return (a, b) => {
                        if (a.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_IsNormal:
                    return (a, b) => {
                        if (a.isNormal == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_ModifyDate:
                    return (a, b) => {
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_ModifyUserID:
                    return (a, b) => {
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajorShoolType:
                    return (a, b) => {
                        return a.id_XzMajorShoolType.localeCompare(b.id_XzMajorShoolType);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzMajor]中不存在！(in ${exports.xzMajor_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorID:
                    return (a, b) => {
                        return b.majorID.localeCompare(a.majorID);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorEnglishName:
                    return (a, b) => {
                        return b.majorEnglishName.localeCompare(a.majorEnglishName);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorExplain:
                    return (a, b) => {
                        return b.majorExplain.localeCompare(a.majorExplain);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorNationalID:
                    return (a, b) => {
                        return b.majorNationalID.localeCompare(a.majorNationalID);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzCollege:
                    return (a, b) => {
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_id_MajorType:
                    return (a, b) => {
                        return b.id_MajorType.localeCompare(a.id_MajorType);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_id_DegreeType:
                    return (a, b) => {
                        return b.id_DegreeType.localeCompare(a.id_DegreeType);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_IsMainMajor:
                    return (a, b) => {
                        if (b.isMainMajor == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorDirection:
                    return (a, b) => {
                        return b.majorDirection.localeCompare(a.majorDirection);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_IsVisible:
                    return (a, b) => {
                        if (b.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_IsNormal:
                    return (a, b) => {
                        if (b.isNormal == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_ModifyDate:
                    return (a, b) => {
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_ModifyUserID:
                    return (a, b) => {
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajorShoolType:
                    return (a, b) => {
                        return b.id_XzMajorShoolType.localeCompare(a.id_XzMajorShoolType);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzMajor]中不存在！(in ${exports.xzMajor_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.XzMajor_SortFunByKey = XzMajor_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function XzMajor_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorID:
                return (obj) => {
                    return obj.majorID === value;
                };
            case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorEnglishName:
                return (obj) => {
                    return obj.majorEnglishName === value;
                };
            case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorExplain:
                return (obj) => {
                    return obj.majorExplain === value;
                };
            case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorNationalID:
                return (obj) => {
                    return obj.majorNationalID === value;
                };
            case clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsXzMajorEN_js_1.clsXzMajorEN.con_id_MajorType:
                return (obj) => {
                    return obj.id_MajorType === value;
                };
            case clsXzMajorEN_js_1.clsXzMajorEN.con_id_DegreeType:
                return (obj) => {
                    return obj.id_DegreeType === value;
                };
            case clsXzMajorEN_js_1.clsXzMajorEN.con_IsMainMajor:
                return (obj) => {
                    return obj.isMainMajor === value;
                };
            case clsXzMajorEN_js_1.clsXzMajorEN.con_MajorDirection:
                return (obj) => {
                    return obj.majorDirection === value;
                };
            case clsXzMajorEN_js_1.clsXzMajorEN.con_IsVisible:
                return (obj) => {
                    return obj.isVisible === value;
                };
            case clsXzMajorEN_js_1.clsXzMajorEN.con_IsNormal:
                return (obj) => {
                    return obj.isNormal === value;
                };
            case clsXzMajorEN_js_1.clsXzMajorEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsXzMajorEN_js_1.clsXzMajorEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsXzMajorEN_js_1.clsXzMajorEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajorShoolType:
                return (obj) => {
                    return obj.id_XzMajorShoolType === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[XzMajor]中不存在！(in ${exports.xzMajor_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.XzMajor_FilterFunByKey = XzMajor_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzMajor_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_GetFirstIDAsync = XzMajor_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function XzMajor_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_GetFirstID = XzMajor_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function XzMajor_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajor_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objXzMajor = XzMajor_GetObjFromJsonObj(returnObj);
                return objXzMajor;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_GetFirstObjAsync = XzMajor_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajor_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzMajorEN_js_1.clsXzMajorEN._CurrTabName;
        clsXzMajorEN_js_1.clsXzMajorEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsXzMajorEN_js_1.clsXzMajorEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsXzMajorEN_js_1.clsXzMajorEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsXzMajorEN_js_1.clsXzMajorEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrXzMajorExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrXzMajorObjLst_T = XzMajor_GetObjLstByJSONObjLst(arrXzMajorExObjLst_Cache);
            return arrXzMajorObjLst_T;
        }
        try {
            const arrXzMajorExObjLst = await XzMajor_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrXzMajorExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzMajorExObjLst.length);
            console.log(strInfo);
            return arrXzMajorExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzMajor_GetObjLst_ClientCache = XzMajor_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajor_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzMajorEN_js_1.clsXzMajorEN._CurrTabName;
        clsXzMajorEN_js_1.clsXzMajorEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsXzMajorEN_js_1.clsXzMajorEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsXzMajorEN_js_1.clsXzMajorEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsXzMajorEN_js_1.clsXzMajorEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzMajorExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzMajorObjLst_T = XzMajor_GetObjLstByJSONObjLst(arrXzMajorExObjLst_Cache);
            return arrXzMajorObjLst_T;
        }
        try {
            const arrXzMajorExObjLst = await XzMajor_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrXzMajorExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzMajorExObjLst.length);
            console.log(strInfo);
            return arrXzMajorExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzMajor_GetObjLst_localStorage = XzMajor_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajor_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzMajorEN_js_1.clsXzMajorEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzMajorObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzMajorObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzMajor_GetObjLst_localStorage_PureCache = XzMajor_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function XzMajor_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajor_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_GetObjLstAsync = XzMajor_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajor_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzMajorEN_js_1.clsXzMajorEN._CurrTabName;
        clsXzMajorEN_js_1.clsXzMajorEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsXzMajorEN_js_1.clsXzMajorEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsXzMajorEN_js_1.clsXzMajorEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsXzMajorEN_js_1.clsXzMajorEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzMajorExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzMajorObjLst_T = XzMajor_GetObjLstByJSONObjLst(arrXzMajorExObjLst_Cache);
            return arrXzMajorObjLst_T;
        }
        try {
            const arrXzMajorExObjLst = await XzMajor_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrXzMajorExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzMajorExObjLst.length);
            console.log(strInfo);
            return arrXzMajorExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzMajor_GetObjLst_sessionStorage = XzMajor_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajor_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzMajorEN_js_1.clsXzMajorEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzMajorObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzMajorObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzMajor_GetObjLst_sessionStorage_PureCache = XzMajor_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajor_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrXzMajorObjLst_Cache;
        switch (clsXzMajorEN_js_1.clsXzMajorEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_ClientCache();
                break;
            default:
                arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_ClientCache();
                break;
        }
        const arrXzMajorObjLst = XzMajor_GetObjLstByJSONObjLst(arrXzMajorObjLst_Cache);
        return arrXzMajorObjLst_Cache;
    }
    exports.XzMajor_GetObjLst_Cache = XzMajor_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajor_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrXzMajorObjLst_Cache;
        switch (clsXzMajorEN_js_1.clsXzMajorEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrXzMajorObjLst_Cache = null;
                break;
            default:
                arrXzMajorObjLst_Cache = null;
                break;
        }
        return arrXzMajorObjLst_Cache;
    }
    exports.XzMajor_GetObjLst_PureCache = XzMajor_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_XzMajor_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzMajor_GetSubObjLst_Cache(objXzMajor_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
        let arrXzMajor_Sel = arrXzMajorObjLst_Cache;
        if (objXzMajor_Cond.sf_FldComparisonOp == null || objXzMajor_Cond.sf_FldComparisonOp == "")
            return arrXzMajor_Sel;
        const dicFldComparisonOp = JSON.parse(objXzMajor_Cond.sf_FldComparisonOp);
        //console.log("clsXzMajorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzMajor_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajor_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzMajor_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objXzMajor_Cond), exports.xzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzMajor_GetSubObjLst_Cache = XzMajor_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_XzMajor:关键字列表
    * @returns 对象列表
    **/
    async function XzMajor_GetObjLstByid_XzMajorLstAsync(arrid_XzMajor) {
        const strThisFuncName = "GetObjLstByid_XzMajorLstAsync";
        const strAction = "GetObjLstByid_XzMajorLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_XzMajor);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajor_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_GetObjLstByid_XzMajorLstAsync = XzMajor_GetObjLstByid_XzMajorLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_XzMajorLst:关键字列表
     * @returns 对象列表
    */
    async function XzMajor_GetObjLstByid_XzMajorLst_Cache(arrid_XzMajorLst) {
        const strThisFuncName = "GetObjLstByid_XzMajorLst_Cache";
        try {
            const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
            const arrXzMajor_Sel = arrXzMajorObjLst_Cache.filter(x => arrid_XzMajorLst.indexOf(x.id_XzMajor) > -1);
            return arrXzMajor_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_XzMajorLst.join(","), exports.xzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzMajor_GetObjLstByid_XzMajorLst_Cache = XzMajor_GetObjLstByid_XzMajorLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function XzMajor_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajor_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_GetTopObjLstAsync = XzMajor_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzMajor_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajor_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_GetObjLstByRangeAsync = XzMajor_GetObjLstByRangeAsync;
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
    async function XzMajor_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_GetObjLstByRange = XzMajor_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function XzMajor_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
        if (arrXzMajorObjLst_Cache.length == 0)
            return arrXzMajorObjLst_Cache;
        let arrXzMajor_Sel = arrXzMajorObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objXzMajor_Cond = new clsXzMajorEN_js_1.clsXzMajorEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzMajor_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsXzMajorWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajor_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzMajor_Sel.length == 0)
                return arrXzMajor_Sel;
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
                arrXzMajor_Sel = arrXzMajor_Sel.sort(XzMajor_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrXzMajor_Sel = arrXzMajor_Sel.sort(objPagerPara.sortFun);
            }
            arrXzMajor_Sel = arrXzMajor_Sel.slice(intStart, intEnd);
            return arrXzMajor_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.xzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzMajor_GetObjLstByPager_Cache = XzMajor_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzMajor_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajor_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_GetObjLstByPagerAsync = XzMajor_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strid_XzMajor:关键字
    * @returns 获取删除的结果
    **/
    async function XzMajor_DelRecordAsync(strid_XzMajor) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strid_XzMajor);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strid_XzMajor, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_DelRecordAsync = XzMajor_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_XzMajor:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function XzMajor_DelXzMajorsAsync(arrid_XzMajor) {
        const strThisFuncName = "DelXzMajorsAsync";
        const strAction = "DelXzMajors";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_XzMajor);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_DelXzMajorsAsync = XzMajor_DelXzMajorsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function XzMajor_DelXzMajorsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelXzMajorsByCondAsync";
        const strAction = "DelXzMajorsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_DelXzMajorsByCondAsync = XzMajor_DelXzMajorsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objXzMajorEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzMajor_AddNewRecordAsync(objXzMajorEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objXzMajorEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_AddNewRecordAsync = XzMajor_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objXzMajorEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzMajor_AddNewRecordWithMaxIdAsync(objXzMajorEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_AddNewRecordWithMaxIdAsync = XzMajor_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objXzMajorEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function XzMajor_AddNewRecordWithReturnKeyAsync(objXzMajorEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_AddNewRecordWithReturnKeyAsync = XzMajor_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objXzMajorEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function XzMajor_AddNewRecordWithReturnKey(objXzMajorEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objXzMajorEN.id_XzMajor === null || objXzMajorEN.id_XzMajor === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_AddNewRecordWithReturnKey = XzMajor_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objXzMajorEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function XzMajor_UpdateRecordAsync(objXzMajorEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objXzMajorEN.sf_UpdFldSetStr === undefined || objXzMajorEN.sf_UpdFldSetStr === null || objXzMajorEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzMajorEN.id_XzMajor);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_UpdateRecordAsync = XzMajor_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objXzMajorEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzMajor_UpdateWithConditionAsync(objXzMajorEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objXzMajorEN.sf_UpdFldSetStr === undefined || objXzMajorEN.sf_UpdFldSetStr === null || objXzMajorEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzMajorEN.id_XzMajor);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        objXzMajorEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_UpdateWithConditionAsync = XzMajor_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_XzMajor_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzMajor_IsExistRecord_Cache(objXzMajor_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
        if (arrXzMajorObjLst_Cache == null)
            return false;
        let arrXzMajor_Sel = arrXzMajorObjLst_Cache;
        if (objXzMajor_Cond.sf_FldComparisonOp == null || objXzMajor_Cond.sf_FldComparisonOp == "")
            return arrXzMajor_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objXzMajor_Cond.sf_FldComparisonOp);
        //console.log("clsXzMajorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzMajor_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajor_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzMajor_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objXzMajor_Cond), exports.xzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.XzMajor_IsExistRecord_Cache = XzMajor_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function XzMajor_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_IsExistRecordAsync = XzMajor_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_XzMajor:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function XzMajor_IsExist(strid_XzMajor, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_XzMajor": strid_XzMajor,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_IsExist = XzMajor_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_XzMajor:所给的关键字
     * @returns 对象
    */
    async function XzMajor_IsExist_Cache(strid_XzMajor) {
        const strThisFuncName = "IsExist_Cache";
        const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
        if (arrXzMajorObjLst_Cache == null)
            return false;
        try {
            const arrXzMajor_Sel = arrXzMajorObjLst_Cache.filter(x => x.id_XzMajor == strid_XzMajor);
            if (arrXzMajor_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_XzMajor, exports.xzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.XzMajor_IsExist_Cache = XzMajor_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_XzMajor:关键字
    * @returns 是否存在?存在返回True
    **/
    async function XzMajor_IsExistAsync(strid_XzMajor) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_XzMajor": strid_XzMajor }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_IsExistAsync = XzMajor_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function XzMajor_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_GetRecCountByCondAsync = XzMajor_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objXzMajor_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function XzMajor_GetRecCountByCond_Cache(objXzMajor_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
        if (arrXzMajorObjLst_Cache == null)
            return 0;
        let arrXzMajor_Sel = arrXzMajorObjLst_Cache;
        if (objXzMajor_Cond.sf_FldComparisonOp == null || objXzMajor_Cond.sf_FldComparisonOp == "")
            return arrXzMajor_Sel.length;
        const dicFldComparisonOp = JSON.parse(objXzMajor_Cond.sf_FldComparisonOp);
        //console.log("clsXzMajorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzMajor_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajor_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzMajor_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objXzMajor_Cond), exports.xzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.XzMajor_GetRecCountByCond_Cache = XzMajor_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function XzMajor_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_GetMaxStrIdAsync = XzMajor_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function XzMajor_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajor_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajor_GetMaxStrIdByPrefix = XzMajor_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function XzMajor_GetWebApiUrl(strController, strAction) {
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
    exports.XzMajor_GetWebApiUrl = XzMajor_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function XzMajor_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsXzMajorEN_js_1.clsXzMajorEN._CurrTabName;
        switch (clsXzMajorEN_js_1.clsXzMajorEN.CacheModeId) {
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
    exports.XzMajor_ReFreshCache = XzMajor_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function XzMajor_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsXzMajorEN_js_1.clsXzMajorEN._CurrTabName;
            switch (clsXzMajorEN_js_1.clsXzMajorEN.CacheModeId) {
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
    exports.XzMajor_ReFreshThisCache = XzMajor_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
     * @param strid_XzMajorShoolType:专业学校类型流水号
    */
    async function XzMajor_BindDdl_id_XzMajorByid_XzMajorShoolTypeInDiv_Cache(strDivName, strDdlName, strid_XzMajorShoolType) {
        const strThisFuncName = "BindDdl_id_XzMajorByid_XzMajorShoolTypeInDiv_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzMajorShoolType) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzMajorShoolType]不能为空！(In BindDdl_id_XzMajorByid_XzMajorShoolTypeInDiv)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzMajorShoolType.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzMajorShoolType]的长度:[{0}]不正确！", strid_XzMajorShoolType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_id_XzMajorByid_XzMajorShoolTypeInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_id_XzMajorByid_XzMajorShoolTypeInDiv_Cache");
        let arrObjLst_Sel = await XzMajor_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        arrObjLst_Sel = arrObjLst_Sel.filter(x => x.id_XzMajorShoolType == strid_XzMajorShoolType);
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, "专业");
    }
    exports.XzMajor_BindDdl_id_XzMajorByid_XzMajorShoolTypeInDiv_Cache = XzMajor_BindDdl_id_XzMajorByid_XzMajorShoolTypeInDiv_Cache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function XzMajor_BindDdl_id_XzMajor_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_id_XzMajor_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_id_XzMajor)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_id_XzMajor_Cache");
        const arrObjLst_Sel = await XzMajor_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, "专业");
    }
    exports.XzMajor_BindDdl_id_XzMajor_Cache = XzMajor_BindDdl_id_XzMajor_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzMajor_CheckPropertyNew(pobjXzMajorEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorID) === true) {
            throw new Error("(errid:Watl000058)字段[专业ID]不能为空(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorName) === true) {
            throw new Error("(errid:Watl000058)字段[专业名称]不能为空(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_XzCollege) === true
            || pobjXzMajorEN.id_XzCollege.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[学院流水号]不能为空(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
        }
        if (null === pobjXzMajorEN.isVisible
            || pobjXzMajorEN.isVisible != null && pobjXzMajorEN.isVisible.toString() === "") {
            throw new Error("(errid:Watl000058)字段[是否显示]不能为空(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_XzMajor) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000059)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_XzMajor)(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorID) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.majorID) > 4) {
            throw new Error("(errid:Watl000059)字段[专业ID(majorID)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorID)(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorName) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.majorName) > 100) {
            throw new Error("(errid:Watl000059)字段[专业名称(majorName)]的长度不能超过100(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorName)(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorEnglishName) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.majorEnglishName) > 200) {
            throw new Error("(errid:Watl000059)字段[专业英文名称(majorEnglishName)]的长度不能超过200(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorEnglishName)(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorExplain) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.majorExplain) > 2000) {
            throw new Error("(errid:Watl000059)字段[专业说明(majorExplain)]的长度不能超过2000(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorExplain)(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorNationalID) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.majorNationalID) > 10) {
            throw new Error("(errid:Watl000059)字段[专业国家代码(majorNationalID)]的长度不能超过10(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorNationalID)(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_XzCollege) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_XzCollege)(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_MajorType) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.id_MajorType) > 4) {
            throw new Error("(errid:Watl000059)字段[专业类型(文理工)流水号(id_MajorType)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_MajorType)(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_DegreeType) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.id_DegreeType) > 4) {
            throw new Error("(errid:Watl000059)字段[学位类型流水号(id_DegreeType)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_DegreeType)(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorDirection) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.majorDirection) > 30) {
            throw new Error("(errid:Watl000059)字段[专业方向(majorDirection)]的长度不能超过30(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorDirection)(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.modifyDate) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 专业(XzMajor))!值:$(pobjXzMajorEN.modifyDate)(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.modifyUserID) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 专业(XzMajor))!值:$(pobjXzMajorEN.modifyUserID)(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 专业(XzMajor))!值:$(pobjXzMajorEN.memo)(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_XzMajorShoolType) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.id_XzMajorShoolType) > 4) {
            throw new Error("(errid:Watl000059)字段[专业学校类型流水号(id_XzMajorShoolType)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_XzMajorShoolType)(clsXzMajorBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_XzMajor) == false && undefined !== pobjXzMajorEN.id_XzMajor && jsString_js_1.tzDataType.isString(pobjXzMajorEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000060)字段[专业流水号(id_XzMajor)]的值:[$(pobjXzMajorEN.id_XzMajor)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorID) == false && undefined !== pobjXzMajorEN.majorID && jsString_js_1.tzDataType.isString(pobjXzMajorEN.majorID) === false) {
            throw new Error("(errid:Watl000060)字段[专业ID(majorID)]的值:[$(pobjXzMajorEN.majorID)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorName) == false && undefined !== pobjXzMajorEN.majorName && jsString_js_1.tzDataType.isString(pobjXzMajorEN.majorName) === false) {
            throw new Error("(errid:Watl000060)字段[专业名称(majorName)]的值:[$(pobjXzMajorEN.majorName)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorEnglishName) == false && undefined !== pobjXzMajorEN.majorEnglishName && jsString_js_1.tzDataType.isString(pobjXzMajorEN.majorEnglishName) === false) {
            throw new Error("(errid:Watl000060)字段[专业英文名称(majorEnglishName)]的值:[$(pobjXzMajorEN.majorEnglishName)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorExplain) == false && undefined !== pobjXzMajorEN.majorExplain && jsString_js_1.tzDataType.isString(pobjXzMajorEN.majorExplain) === false) {
            throw new Error("(errid:Watl000060)字段[专业说明(majorExplain)]的值:[$(pobjXzMajorEN.majorExplain)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorNationalID) == false && undefined !== pobjXzMajorEN.majorNationalID && jsString_js_1.tzDataType.isString(pobjXzMajorEN.majorNationalID) === false) {
            throw new Error("(errid:Watl000060)字段[专业国家代码(majorNationalID)]的值:[$(pobjXzMajorEN.majorNationalID)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_XzCollege) == false && undefined !== pobjXzMajorEN.id_XzCollege && jsString_js_1.tzDataType.isString(pobjXzMajorEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjXzMajorEN.id_XzCollege)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_MajorType) == false && undefined !== pobjXzMajorEN.id_MajorType && jsString_js_1.tzDataType.isString(pobjXzMajorEN.id_MajorType) === false) {
            throw new Error("(errid:Watl000060)字段[专业类型(文理工)流水号(id_MajorType)]的值:[$(pobjXzMajorEN.id_MajorType)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_DegreeType) == false && undefined !== pobjXzMajorEN.id_DegreeType && jsString_js_1.tzDataType.isString(pobjXzMajorEN.id_DegreeType) === false) {
            throw new Error("(errid:Watl000060)字段[学位类型流水号(id_DegreeType)]的值:[$(pobjXzMajorEN.id_DegreeType)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        if (null != pobjXzMajorEN.isMainMajor && undefined !== pobjXzMajorEN.isMainMajor && jsString_js_1.tzDataType.isBoolean(pobjXzMajorEN.isMainMajor) === false) {
            throw new Error("(errid:Watl000060)字段[是否重要专业(isMainMajor)]的值:[$(pobjXzMajorEN.isMainMajor)], 非法，应该为布尔型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorDirection) == false && undefined !== pobjXzMajorEN.majorDirection && jsString_js_1.tzDataType.isString(pobjXzMajorEN.majorDirection) === false) {
            throw new Error("(errid:Watl000060)字段[专业方向(majorDirection)]的值:[$(pobjXzMajorEN.majorDirection)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        if (null != pobjXzMajorEN.isVisible && undefined !== pobjXzMajorEN.isVisible && jsString_js_1.tzDataType.isBoolean(pobjXzMajorEN.isVisible) === false) {
            throw new Error("(errid:Watl000060)字段[是否显示(isVisible)]的值:[$(pobjXzMajorEN.isVisible)], 非法，应该为布尔型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        if (null != pobjXzMajorEN.isNormal && undefined !== pobjXzMajorEN.isNormal && jsString_js_1.tzDataType.isBoolean(pobjXzMajorEN.isNormal) === false) {
            throw new Error("(errid:Watl000060)字段[IsNormal(isNormal)]的值:[$(pobjXzMajorEN.isNormal)], 非法，应该为布尔型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.modifyDate) == false && undefined !== pobjXzMajorEN.modifyDate && jsString_js_1.tzDataType.isString(pobjXzMajorEN.modifyDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjXzMajorEN.modifyDate)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.modifyUserID) == false && undefined !== pobjXzMajorEN.modifyUserID && jsString_js_1.tzDataType.isString(pobjXzMajorEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjXzMajorEN.modifyUserID)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.memo) == false && undefined !== pobjXzMajorEN.memo && jsString_js_1.tzDataType.isString(pobjXzMajorEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjXzMajorEN.memo)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_XzMajorShoolType) == false && undefined !== pobjXzMajorEN.id_XzMajorShoolType && jsString_js_1.tzDataType.isString(pobjXzMajorEN.id_XzMajorShoolType) === false) {
            throw new Error("(errid:Watl000060)字段[专业学校类型流水号(id_XzMajorShoolType)]的值:[$(pobjXzMajorEN.id_XzMajorShoolType)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_XzCollege) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.id_XzCollege) != 4) {
            throw ("(errid:Watl000061)字段[学院流水号]作为外键字段,长度应该为4(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_MajorType) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.id_MajorType) != 4) {
            throw ("(errid:Watl000061)字段[专业类型(文理工)流水号]作为外键字段,长度应该为4(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_DegreeType) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.id_DegreeType) != 4) {
            throw ("(errid:Watl000061)字段[学位类型流水号]作为外键字段,长度应该为4(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjXzMajorEN.SetIsCheckProperty(true);
    }
    exports.XzMajor_CheckPropertyNew = XzMajor_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzMajor_CheckProperty4Update(pobjXzMajorEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_XzMajor) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000062)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_XzMajor)(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorID) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.majorID) > 4) {
            throw new Error("(errid:Watl000062)字段[专业ID(majorID)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorID)(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorName) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.majorName) > 100) {
            throw new Error("(errid:Watl000062)字段[专业名称(majorName)]的长度不能超过100(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorName)(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorEnglishName) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.majorEnglishName) > 200) {
            throw new Error("(errid:Watl000062)字段[专业英文名称(majorEnglishName)]的长度不能超过200(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorEnglishName)(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorExplain) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.majorExplain) > 2000) {
            throw new Error("(errid:Watl000062)字段[专业说明(majorExplain)]的长度不能超过2000(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorExplain)(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorNationalID) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.majorNationalID) > 10) {
            throw new Error("(errid:Watl000062)字段[专业国家代码(majorNationalID)]的长度不能超过10(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorNationalID)(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_XzCollege) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_XzCollege)(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_MajorType) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.id_MajorType) > 4) {
            throw new Error("(errid:Watl000062)字段[专业类型(文理工)流水号(id_MajorType)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_MajorType)(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_DegreeType) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.id_DegreeType) > 4) {
            throw new Error("(errid:Watl000062)字段[学位类型流水号(id_DegreeType)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_DegreeType)(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorDirection) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.majorDirection) > 30) {
            throw new Error("(errid:Watl000062)字段[专业方向(majorDirection)]的长度不能超过30(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorDirection)(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.modifyDate) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 专业(XzMajor))!值:$(pobjXzMajorEN.modifyDate)(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.modifyUserID) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 专业(XzMajor))!值:$(pobjXzMajorEN.modifyUserID)(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 专业(XzMajor))!值:$(pobjXzMajorEN.memo)(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_XzMajorShoolType) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.id_XzMajorShoolType) > 4) {
            throw new Error("(errid:Watl000062)字段[专业学校类型流水号(id_XzMajorShoolType)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_XzMajorShoolType)(clsXzMajorBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_XzMajor) == false && undefined !== pobjXzMajorEN.id_XzMajor && jsString_js_1.tzDataType.isString(pobjXzMajorEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000063)字段[专业流水号(id_XzMajor)]的值:[$(pobjXzMajorEN.id_XzMajor)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorID) == false && undefined !== pobjXzMajorEN.majorID && jsString_js_1.tzDataType.isString(pobjXzMajorEN.majorID) === false) {
            throw new Error("(errid:Watl000063)字段[专业ID(majorID)]的值:[$(pobjXzMajorEN.majorID)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorName) == false && undefined !== pobjXzMajorEN.majorName && jsString_js_1.tzDataType.isString(pobjXzMajorEN.majorName) === false) {
            throw new Error("(errid:Watl000063)字段[专业名称(majorName)]的值:[$(pobjXzMajorEN.majorName)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorEnglishName) == false && undefined !== pobjXzMajorEN.majorEnglishName && jsString_js_1.tzDataType.isString(pobjXzMajorEN.majorEnglishName) === false) {
            throw new Error("(errid:Watl000063)字段[专业英文名称(majorEnglishName)]的值:[$(pobjXzMajorEN.majorEnglishName)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorExplain) == false && undefined !== pobjXzMajorEN.majorExplain && jsString_js_1.tzDataType.isString(pobjXzMajorEN.majorExplain) === false) {
            throw new Error("(errid:Watl000063)字段[专业说明(majorExplain)]的值:[$(pobjXzMajorEN.majorExplain)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorNationalID) == false && undefined !== pobjXzMajorEN.majorNationalID && jsString_js_1.tzDataType.isString(pobjXzMajorEN.majorNationalID) === false) {
            throw new Error("(errid:Watl000063)字段[专业国家代码(majorNationalID)]的值:[$(pobjXzMajorEN.majorNationalID)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_XzCollege) == false && undefined !== pobjXzMajorEN.id_XzCollege && jsString_js_1.tzDataType.isString(pobjXzMajorEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjXzMajorEN.id_XzCollege)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_MajorType) == false && undefined !== pobjXzMajorEN.id_MajorType && jsString_js_1.tzDataType.isString(pobjXzMajorEN.id_MajorType) === false) {
            throw new Error("(errid:Watl000063)字段[专业类型(文理工)流水号(id_MajorType)]的值:[$(pobjXzMajorEN.id_MajorType)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_DegreeType) == false && undefined !== pobjXzMajorEN.id_DegreeType && jsString_js_1.tzDataType.isString(pobjXzMajorEN.id_DegreeType) === false) {
            throw new Error("(errid:Watl000063)字段[学位类型流水号(id_DegreeType)]的值:[$(pobjXzMajorEN.id_DegreeType)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        if (null != pobjXzMajorEN.isMainMajor && undefined !== pobjXzMajorEN.isMainMajor && jsString_js_1.tzDataType.isBoolean(pobjXzMajorEN.isMainMajor) === false) {
            throw new Error("(errid:Watl000063)字段[是否重要专业(isMainMajor)]的值:[$(pobjXzMajorEN.isMainMajor)], 非法，应该为布尔型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.majorDirection) == false && undefined !== pobjXzMajorEN.majorDirection && jsString_js_1.tzDataType.isString(pobjXzMajorEN.majorDirection) === false) {
            throw new Error("(errid:Watl000063)字段[专业方向(majorDirection)]的值:[$(pobjXzMajorEN.majorDirection)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        if (null != pobjXzMajorEN.isVisible && undefined !== pobjXzMajorEN.isVisible && jsString_js_1.tzDataType.isBoolean(pobjXzMajorEN.isVisible) === false) {
            throw new Error("(errid:Watl000063)字段[是否显示(isVisible)]的值:[$(pobjXzMajorEN.isVisible)], 非法，应该为布尔型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        if (null != pobjXzMajorEN.isNormal && undefined !== pobjXzMajorEN.isNormal && jsString_js_1.tzDataType.isBoolean(pobjXzMajorEN.isNormal) === false) {
            throw new Error("(errid:Watl000063)字段[IsNormal(isNormal)]的值:[$(pobjXzMajorEN.isNormal)], 非法，应该为布尔型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.modifyDate) == false && undefined !== pobjXzMajorEN.modifyDate && jsString_js_1.tzDataType.isString(pobjXzMajorEN.modifyDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjXzMajorEN.modifyDate)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.modifyUserID) == false && undefined !== pobjXzMajorEN.modifyUserID && jsString_js_1.tzDataType.isString(pobjXzMajorEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjXzMajorEN.modifyUserID)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.memo) == false && undefined !== pobjXzMajorEN.memo && jsString_js_1.tzDataType.isString(pobjXzMajorEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjXzMajorEN.memo)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_XzMajorShoolType) == false && undefined !== pobjXzMajorEN.id_XzMajorShoolType && jsString_js_1.tzDataType.isString(pobjXzMajorEN.id_XzMajorShoolType) === false) {
            throw new Error("(errid:Watl000063)字段[专业学校类型流水号(id_XzMajorShoolType)]的值:[$(pobjXzMajorEN.id_XzMajorShoolType)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_XzMajor) === true
            || pobjXzMajorEN.id_XzMajor.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[专业流水号]不能为空(In 专业)!(clsXzMajorBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_XzCollege) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.id_XzCollege) != 4) {
            throw ("(errid:Watl000065)字段[学院流水号]作为外键字段,长度应该为4(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_MajorType) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.id_MajorType) != 4) {
            throw ("(errid:Watl000065)字段[专业类型(文理工)流水号]作为外键字段,长度应该为4(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzMajorEN.id_DegreeType) == false && (0, clsString_js_1.GetStrLen)(pobjXzMajorEN.id_DegreeType) != 4) {
            throw ("(errid:Watl000065)字段[学位类型流水号]作为外键字段,长度应该为4(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
        }
        pobjXzMajorEN.SetIsCheckProperty(true);
    }
    exports.XzMajor_CheckProperty4Update = XzMajor_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzMajor_GetJSONStrByObj(pobjXzMajorEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjXzMajorEN.sf_UpdFldSetStr = pobjXzMajorEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjXzMajorEN);
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
    exports.XzMajor_GetJSONStrByObj = XzMajor_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function XzMajor_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrXzMajorObjLst = new Array();
        if (strJSON === "") {
            return arrXzMajorObjLst;
        }
        try {
            arrXzMajorObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrXzMajorObjLst;
        }
        return arrXzMajorObjLst;
    }
    exports.XzMajor_GetObjLstByJSONStr = XzMajor_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrXzMajorObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function XzMajor_GetObjLstByJSONObjLst(arrXzMajorObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrXzMajorObjLst = new Array();
        for (const objInFor of arrXzMajorObjLstS) {
            const obj1 = XzMajor_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrXzMajorObjLst.push(obj1);
        }
        return arrXzMajorObjLst;
    }
    exports.XzMajor_GetObjLstByJSONObjLst = XzMajor_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzMajor_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjXzMajorEN = new clsXzMajorEN_js_1.clsXzMajorEN();
        if (strJSON === "") {
            return pobjXzMajorEN;
        }
        try {
            pobjXzMajorEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjXzMajorEN;
        }
        return pobjXzMajorEN;
    }
    exports.XzMajor_GetObjByJSONStr = XzMajor_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function XzMajor_GetCombineCondition(objXzMajor_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor, objXzMajor_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorID) == true) {
            const strComparisonOp_MajorID = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN_js_1.clsXzMajorEN.con_MajorID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorEN_js_1.clsXzMajorEN.con_MajorID, objXzMajor_Cond.majorID, strComparisonOp_MajorID);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, objXzMajor_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorEnglishName) == true) {
            const strComparisonOp_MajorEnglishName = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN_js_1.clsXzMajorEN.con_MajorEnglishName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorEN_js_1.clsXzMajorEN.con_MajorEnglishName, objXzMajor_Cond.majorEnglishName, strComparisonOp_MajorEnglishName);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorExplain) == true) {
            const strComparisonOp_MajorExplain = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN_js_1.clsXzMajorEN.con_MajorExplain];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorEN_js_1.clsXzMajorEN.con_MajorExplain, objXzMajor_Cond.majorExplain, strComparisonOp_MajorExplain);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorNationalID) == true) {
            const strComparisonOp_MajorNationalID = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN_js_1.clsXzMajorEN.con_MajorNationalID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorEN_js_1.clsXzMajorEN.con_MajorNationalID, objXzMajor_Cond.majorNationalID, strComparisonOp_MajorNationalID);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzCollege, objXzMajor_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_id_MajorType) == true) {
            const strComparisonOp_id_MajorType = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN_js_1.clsXzMajorEN.con_id_MajorType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorEN_js_1.clsXzMajorEN.con_id_MajorType, objXzMajor_Cond.id_MajorType, strComparisonOp_id_MajorType);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_id_DegreeType) == true) {
            const strComparisonOp_id_DegreeType = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN_js_1.clsXzMajorEN.con_id_DegreeType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorEN_js_1.clsXzMajorEN.con_id_DegreeType, objXzMajor_Cond.id_DegreeType, strComparisonOp_id_DegreeType);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_IsMainMajor) == true) {
            if (objXzMajor_Cond.isMainMajor == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsXzMajorEN_js_1.clsXzMajorEN.con_IsMainMajor);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsXzMajorEN_js_1.clsXzMajorEN.con_IsMainMajor);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorDirection) == true) {
            const strComparisonOp_MajorDirection = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN_js_1.clsXzMajorEN.con_MajorDirection];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorEN_js_1.clsXzMajorEN.con_MajorDirection, objXzMajor_Cond.majorDirection, strComparisonOp_MajorDirection);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_IsVisible) == true) {
            if (objXzMajor_Cond.isVisible == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsXzMajorEN_js_1.clsXzMajorEN.con_IsVisible);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsXzMajorEN_js_1.clsXzMajorEN.con_IsVisible);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_IsNormal) == true) {
            if (objXzMajor_Cond.isNormal == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsXzMajorEN_js_1.clsXzMajorEN.con_IsNormal);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsXzMajorEN_js_1.clsXzMajorEN.con_IsNormal);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN_js_1.clsXzMajorEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorEN_js_1.clsXzMajorEN.con_ModifyDate, objXzMajor_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN_js_1.clsXzMajorEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorEN_js_1.clsXzMajorEN.con_ModifyUserID, objXzMajor_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_Memo) == true) {
            const strComparisonOp_Memo = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN_js_1.clsXzMajorEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorEN_js_1.clsXzMajorEN.con_Memo, objXzMajor_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajorShoolType) == true) {
            const strComparisonOp_id_XzMajorShoolType = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajorShoolType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajorShoolType, objXzMajor_Cond.id_XzMajorShoolType, strComparisonOp_id_XzMajorShoolType);
        }
        return strWhereCond;
    }
    exports.XzMajor_GetCombineCondition = XzMajor_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--XzMajor(专业),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strid_XzMajor: 专业流水号(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function XzMajor_GetUniCondStr_id_XzMajor(objXzMajorEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and id_XzMajor = '{0}'", objXzMajorEN.id_XzMajor);
        return strWhereCond;
    }
    exports.XzMajor_GetUniCondStr_id_XzMajor = XzMajor_GetUniCondStr_id_XzMajor;
    /**
    *获取唯一性条件串(Uniqueness)--XzMajor(专业),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strid_XzMajor: 专业流水号(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function XzMajor_GetUniCondStr4Update_id_XzMajor(objXzMajorEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and id_XzMajor <> '{0}'", objXzMajorEN.id_XzMajor);
        strWhereCond += (0, clsString_js_1.Format)(" and id_XzMajor = '{0}'", objXzMajorEN.id_XzMajor);
        return strWhereCond;
    }
    exports.XzMajor_GetUniCondStr4Update_id_XzMajor = XzMajor_GetUniCondStr4Update_id_XzMajor;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objXzMajorENS:源对象
     * @param objXzMajorENT:目标对象
    */
    function XzMajor_CopyObjTo(objXzMajorENS, objXzMajorENT) {
        objXzMajorENT.id_XzMajor = objXzMajorENS.id_XzMajor; //专业流水号
        objXzMajorENT.majorID = objXzMajorENS.majorID; //专业ID
        objXzMajorENT.majorName = objXzMajorENS.majorName; //专业名称
        objXzMajorENT.majorEnglishName = objXzMajorENS.majorEnglishName; //专业英文名称
        objXzMajorENT.majorExplain = objXzMajorENS.majorExplain; //专业说明
        objXzMajorENT.majorNationalID = objXzMajorENS.majorNationalID; //专业国家代码
        objXzMajorENT.id_XzCollege = objXzMajorENS.id_XzCollege; //学院流水号
        objXzMajorENT.id_MajorType = objXzMajorENS.id_MajorType; //专业类型(文理工)流水号
        objXzMajorENT.id_DegreeType = objXzMajorENS.id_DegreeType; //学位类型流水号
        objXzMajorENT.isMainMajor = objXzMajorENS.isMainMajor; //是否重要专业
        objXzMajorENT.majorDirection = objXzMajorENS.majorDirection; //专业方向
        objXzMajorENT.isVisible = objXzMajorENS.isVisible; //是否显示
        objXzMajorENT.isNormal = objXzMajorENS.isNormal; //IsNormal
        objXzMajorENT.modifyDate = objXzMajorENS.modifyDate; //修改日期
        objXzMajorENT.modifyUserID = objXzMajorENS.modifyUserID; //修改人
        objXzMajorENT.memo = objXzMajorENS.memo; //备注
        objXzMajorENT.id_XzMajorShoolType = objXzMajorENS.id_XzMajorShoolType; //专业学校类型流水号
        objXzMajorENT.sf_UpdFldSetStr = objXzMajorENS.updFldString; //sf_UpdFldSetStr
    }
    exports.XzMajor_CopyObjTo = XzMajor_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objXzMajorENS:源对象
     * @param objXzMajorENT:目标对象
    */
    function XzMajor_GetObjFromJsonObj(objXzMajorENS) {
        const objXzMajorENT = new clsXzMajorEN_js_1.clsXzMajorEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzMajorENT, objXzMajorENS);
        return objXzMajorENT;
    }
    exports.XzMajor_GetObjFromJsonObj = XzMajor_GetObjFromJsonObj;
});
