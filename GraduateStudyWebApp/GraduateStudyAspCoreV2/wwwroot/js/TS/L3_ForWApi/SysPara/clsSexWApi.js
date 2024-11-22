/**
* 类名:clsSexWApi
* 表名:Sex(01120103)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:53:35
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:系统参数(SysPara)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/SysPara/clsSexEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Sex_GetObjFromJsonObj = exports.Sex_CopyObjTo = exports.Sex_GetCombineCondition = exports.Sex_GetObjByJSONStr = exports.Sex_GetObjLstByJSONObjLst = exports.Sex_GetObjLstByJSONStr = exports.Sex_GetJSONStrByObj = exports.Sex_CheckProperty4Update = exports.Sex_CheckPropertyNew = exports.Sex_BindDdl_id_SexInDiv_Cache = exports.Sex_ReFreshThisCache = exports.Sex_ReFreshCache = exports.Sex_GetWebApiUrl = exports.Sex_GetMaxStrIdByPrefix = exports.Sex_GetRecCountByCond_Cache = exports.Sex_GetRecCountByCondAsync = exports.Sex_IsExistAsync = exports.Sex_IsExist_Cache = exports.Sex_IsExist = exports.Sex_IsExistRecordAsync = exports.Sex_IsExistRecord_Cache = exports.Sex_UpdateWithConditionAsync = exports.Sex_UpdateRecordAsync = exports.Sex_AddNewRecordWithReturnKey = exports.Sex_AddNewRecordWithReturnKeyAsync = exports.Sex_AddNewRecordWithMaxIdAsync = exports.Sex_AddNewRecordAsync = exports.Sex_DelSexsByCondAsync = exports.Sex_DelSexsAsync = exports.Sex_DelRecordAsync = exports.Sex_GetObjLstByPagerAsync = exports.Sex_GetObjLstByPager_Cache = exports.Sex_GetObjLstByRange = exports.Sex_GetObjLstByRangeAsync = exports.Sex_GetTopObjLstAsync = exports.Sex_GetObjLstByid_SexLst_Cache = exports.Sex_GetObjLstByid_SexLstAsync = exports.Sex_GetSubObjLst_Cache = exports.Sex_GetObjLst_PureCache = exports.Sex_GetObjLst_Cache = exports.Sex_GetObjLst_sessionStorage_PureCache = exports.Sex_GetObjLst_sessionStorage = exports.Sex_GetObjLstAsync = exports.Sex_GetObjLst_localStorage_PureCache = exports.Sex_GetObjLst_localStorage = exports.Sex_GetObjLst_ClientCache = exports.Sex_GetFirstObjAsync = exports.Sex_GetFirstID = exports.Sex_GetFirstIDAsync = exports.Sex_funcKey = exports.Sex_FilterFunByKey = exports.Sex_SortFunByKey = exports.Sex_SortFun_Defa_2Fld = exports.Sex_SortFun_Defa = exports.Sex_func = exports.Sex_GetNameByid_Sex_Cache = exports.Sex_UpdateObjInLst_Cache = exports.Sex_GetObjByid_Sex_localStorage = exports.Sex_GetObjByid_Sex_Cache = exports.Sex_GetObjByid_SexAsync = exports.sex_ConstructorName = exports.sex_Controller = void 0;
    /**
     * 性别(Sex)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsSexEN_js_1 = require("../../L0_Entity/SysPara/clsSexEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.sex_Controller = "SexApi";
    exports.sex_ConstructorName = "sex";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_Sex:关键字
    * @returns 对象
    **/
    async function Sex_GetObjByid_SexAsync(strid_Sex) {
        const strThisFuncName = "GetObjByid_SexAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_Sex) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_Sex]不能为空！(In clsSexWApi.GetObjByid_SexAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_Sex.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_Sex]的长度:[{0}]不正确！(clsSexWApi.GetObjByid_SexAsync)", strid_Sex.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_Sex";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_Sex": strid_Sex,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objSex = Sex_GetObjFromJsonObj(returnObj);
                return objSex;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetObjByid_SexAsync = Sex_GetObjByid_SexAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_Sex:所给的关键字
     * @returns 对象
    */
    async function Sex_GetObjByid_Sex_Cache(strid_Sex, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_Sex_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_Sex) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_Sex]不能为空！(In clsSexWApi.GetObjByid_Sex_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_Sex.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_Sex]的长度:[{0}]不正确！(clsSexWApi.GetObjByid_Sex_Cache)", strid_Sex.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSexObjLst_Cache = await Sex_GetObjLst_Cache();
        try {
            const arrSex_Sel = arrSexObjLst_Cache.filter(x => x.id_Sex == strid_Sex);
            let objSex;
            if (arrSex_Sel.length > 0) {
                objSex = arrSex_Sel[0];
                return objSex;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objSex_Const = await Sex_GetObjByid_SexAsync(strid_Sex);
                    if (objSex_Const != null) {
                        Sex_ReFreshThisCache();
                        return objSex_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_Sex, exports.sex_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.Sex_GetObjByid_Sex_Cache = Sex_GetObjByid_Sex_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_Sex:所给的关键字
     * @returns 对象
    */
    async function Sex_GetObjByid_Sex_localStorage(strid_Sex) {
        const strThisFuncName = "GetObjByid_Sex_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_Sex) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_Sex]不能为空！(In clsSexWApi.GetObjByid_Sex_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_Sex.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_Sex]的长度:[{0}]不正确！(clsSexWApi.GetObjByid_Sex_localStorage)", strid_Sex.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSexEN_js_1.clsSexEN._CurrTabName, strid_Sex);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objSex_Cache = JSON.parse(strTempObj);
            return objSex_Cache;
        }
        try {
            const objSex = await Sex_GetObjByid_SexAsync(strid_Sex);
            if (objSex != null) {
                localStorage.setItem(strKey, JSON.stringify(objSex));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objSex;
            }
            return objSex;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_Sex, exports.sex_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.Sex_GetObjByid_Sex_localStorage = Sex_GetObjByid_Sex_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objSex:所给的对象
     * @returns 对象
    */
    async function Sex_UpdateObjInLst_Cache(objSex) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrSexObjLst_Cache = await Sex_GetObjLst_Cache();
            const obj = arrSexObjLst_Cache.find(x => x.id_Sex == objSex.id_Sex);
            if (obj != null) {
                objSex.id_Sex = obj.id_Sex;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objSex);
            }
            else {
                arrSexObjLst_Cache.push(objSex);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.sex_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.Sex_UpdateObjInLst_Cache = Sex_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_Sex:所给的关键字
     * @returns 对象
    */
    async function Sex_GetNameByid_Sex_Cache(strid_Sex) {
        const strThisFuncName = "GetNameByid_Sex_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_Sex) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_Sex]不能为空！(In clsSexWApi.GetNameByid_Sex_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_Sex.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_Sex]的长度:[{0}]不正确！(clsSexWApi.GetNameByid_Sex_Cache)", strid_Sex.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSexObjLst_Cache = await Sex_GetObjLst_Cache();
        if (arrSexObjLst_Cache == null)
            return "";
        try {
            const arrSex_Sel = arrSexObjLst_Cache.filter(x => x.id_Sex == strid_Sex);
            let objSex;
            if (arrSex_Sel.length > 0) {
                objSex = arrSex_Sel[0];
                return objSex.sexDesc;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_Sex);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.Sex_GetNameByid_Sex_Cache = Sex_GetNameByid_Sex_Cache;
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
    async function Sex_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsSexEN_js_1.clsSexEN.con_id_Sex) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsSexEN_js_1.clsSexEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsSexEN_js_1.clsSexEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_Sex = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objSex = await Sex_GetObjByid_Sex_Cache(strid_Sex);
        if (objSex == null)
            return "";
        if (objSex.GetFldValue(strOutFldName) == null)
            return "";
        return objSex.GetFldValue(strOutFldName).toString();
    }
    exports.Sex_func = Sex_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Sex_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_Sex.localeCompare(b.id_Sex);
    }
    exports.Sex_SortFun_Defa = Sex_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Sex_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.sexID == b.sexID)
            return a.sexDesc.localeCompare(b.sexDesc);
        else
            return a.sexID.localeCompare(b.sexID);
    }
    exports.Sex_SortFun_Defa_2Fld = Sex_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Sex_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSexEN_js_1.clsSexEN.con_id_Sex:
                    return (a, b) => {
                        return a.id_Sex.localeCompare(b.id_Sex);
                    };
                case clsSexEN_js_1.clsSexEN.con_SexID:
                    return (a, b) => {
                        if (a.sexID == null)
                            return -1;
                        if (b.sexID == null)
                            return 1;
                        return a.sexID.localeCompare(b.sexID);
                    };
                case clsSexEN_js_1.clsSexEN.con_SexDesc:
                    return (a, b) => {
                        if (a.sexDesc == null)
                            return -1;
                        if (b.sexDesc == null)
                            return 1;
                        return a.sexDesc.localeCompare(b.sexDesc);
                    };
                case clsSexEN_js_1.clsSexEN.con_SexDesc_EN:
                    return (a, b) => {
                        if (a.sexDesc_EN == null)
                            return -1;
                        if (b.sexDesc_EN == null)
                            return 1;
                        return a.sexDesc_EN.localeCompare(b.sexDesc_EN);
                    };
                case clsSexEN_js_1.clsSexEN.con_ModifyDate:
                    return (a, b) => {
                        if (a.modifyDate == null)
                            return -1;
                        if (b.modifyDate == null)
                            return 1;
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsSexEN_js_1.clsSexEN.con_ModifyUserID:
                    return (a, b) => {
                        if (a.modifyUserID == null)
                            return -1;
                        if (b.modifyUserID == null)
                            return 1;
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsSexEN_js_1.clsSexEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[Sex]中不存在！(in ${exports.sex_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSexEN_js_1.clsSexEN.con_id_Sex:
                    return (a, b) => {
                        return b.id_Sex.localeCompare(a.id_Sex);
                    };
                case clsSexEN_js_1.clsSexEN.con_SexID:
                    return (a, b) => {
                        if (b.sexID == null)
                            return -1;
                        if (a.sexID == null)
                            return 1;
                        return b.sexID.localeCompare(a.sexID);
                    };
                case clsSexEN_js_1.clsSexEN.con_SexDesc:
                    return (a, b) => {
                        if (b.sexDesc == null)
                            return -1;
                        if (a.sexDesc == null)
                            return 1;
                        return b.sexDesc.localeCompare(a.sexDesc);
                    };
                case clsSexEN_js_1.clsSexEN.con_SexDesc_EN:
                    return (a, b) => {
                        if (b.sexDesc_EN == null)
                            return -1;
                        if (a.sexDesc_EN == null)
                            return 1;
                        return b.sexDesc_EN.localeCompare(a.sexDesc_EN);
                    };
                case clsSexEN_js_1.clsSexEN.con_ModifyDate:
                    return (a, b) => {
                        if (b.modifyDate == null)
                            return -1;
                        if (a.modifyDate == null)
                            return 1;
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsSexEN_js_1.clsSexEN.con_ModifyUserID:
                    return (a, b) => {
                        if (b.modifyUserID == null)
                            return -1;
                        if (a.modifyUserID == null)
                            return 1;
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsSexEN_js_1.clsSexEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[Sex]中不存在！(in ${exports.sex_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.Sex_SortFunByKey = Sex_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function Sex_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSexEN_js_1.clsSexEN.con_id_Sex:
                return (obj) => {
                    return obj.id_Sex === value;
                };
            case clsSexEN_js_1.clsSexEN.con_SexID:
                return (obj) => {
                    return obj.sexID === value;
                };
            case clsSexEN_js_1.clsSexEN.con_SexDesc:
                return (obj) => {
                    return obj.sexDesc === value;
                };
            case clsSexEN_js_1.clsSexEN.con_SexDesc_EN:
                return (obj) => {
                    return obj.sexDesc_EN === value;
                };
            case clsSexEN_js_1.clsSexEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsSexEN_js_1.clsSexEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsSexEN_js_1.clsSexEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[Sex]中不存在！(in ${exports.sex_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.Sex_FilterFunByKey = Sex_FilterFunByKey;
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
    async function Sex_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsSexEN_js_1.clsSexEN.con_id_Sex) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrSex = await Sex_GetObjLst_Cache();
        if (arrSex == null)
            return [];
        let arrSex_Sel = arrSex;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrSex_Sel = arrSex_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrSex_Sel.length == 0)
            return [];
        return arrSex_Sel.map(x => x.id_Sex);
    }
    exports.Sex_funcKey = Sex_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function Sex_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetFirstIDAsync = Sex_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function Sex_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetFirstID = Sex_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function Sex_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
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
                const objSex = Sex_GetObjFromJsonObj(returnObj);
                return objSex;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetFirstObjAsync = Sex_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Sex_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSexEN_js_1.clsSexEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSexEN_js_1.clsSexEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsSexEN_js_1.clsSexEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrSexExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrSexObjLst_T = Sex_GetObjLstByJSONObjLst(arrSexExObjLst_Cache);
            return arrSexObjLst_T;
        }
        try {
            const arrSexExObjLst = await Sex_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrSexExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSexExObjLst.length);
            console.log(strInfo);
            return arrSexExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sex_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.Sex_GetObjLst_ClientCache = Sex_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Sex_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSexEN_js_1.clsSexEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSexEN_js_1.clsSexEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsSexEN_js_1.clsSexEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSexExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSexObjLst_T = Sex_GetObjLstByJSONObjLst(arrSexExObjLst_Cache);
            return arrSexObjLst_T;
        }
        try {
            const arrSexExObjLst = await Sex_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrSexExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSexExObjLst.length);
            console.log(strInfo);
            return arrSexExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sex_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.Sex_GetObjLst_localStorage = Sex_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Sex_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsSexEN_js_1.clsSexEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSexObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSexObjLst_Cache;
        }
        else
            return null;
    }
    exports.Sex_GetObjLst_localStorage_PureCache = Sex_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function Sex_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sex_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Sex_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetObjLstAsync = Sex_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Sex_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSexEN_js_1.clsSexEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSexEN_js_1.clsSexEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsSexEN_js_1.clsSexEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSexExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSexObjLst_T = Sex_GetObjLstByJSONObjLst(arrSexExObjLst_Cache);
            return arrSexObjLst_T;
        }
        try {
            const arrSexExObjLst = await Sex_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrSexExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSexExObjLst.length);
            console.log(strInfo);
            return arrSexExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sex_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.Sex_GetObjLst_sessionStorage = Sex_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Sex_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsSexEN_js_1.clsSexEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSexObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSexObjLst_Cache;
        }
        else
            return null;
    }
    exports.Sex_GetObjLst_sessionStorage_PureCache = Sex_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Sex_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrSexObjLst_Cache;
        switch (clsSexEN_js_1.clsSexEN.CacheModeId) {
            case "04": //sessionStorage
                arrSexObjLst_Cache = await Sex_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrSexObjLst_Cache = await Sex_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrSexObjLst_Cache = await Sex_GetObjLst_ClientCache();
                break;
            default:
                arrSexObjLst_Cache = await Sex_GetObjLst_ClientCache();
                break;
        }
        const arrSexObjLst = Sex_GetObjLstByJSONObjLst(arrSexObjLst_Cache);
        return arrSexObjLst_Cache;
    }
    exports.Sex_GetObjLst_Cache = Sex_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Sex_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrSexObjLst_Cache;
        switch (clsSexEN_js_1.clsSexEN.CacheModeId) {
            case "04": //sessionStorage
                arrSexObjLst_Cache = await Sex_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrSexObjLst_Cache = await Sex_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrSexObjLst_Cache = null;
                break;
            default:
                arrSexObjLst_Cache = null;
                break;
        }
        return arrSexObjLst_Cache;
    }
    exports.Sex_GetObjLst_PureCache = Sex_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_Sex_Cond:条件对象
     * @returns 对象列表子集
    */
    async function Sex_GetSubObjLst_Cache(objSex_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrSexObjLst_Cache = await Sex_GetObjLst_Cache();
        let arrSex_Sel = arrSexObjLst_Cache;
        if (objSex_Cond.sf_FldComparisonOp == null || objSex_Cond.sf_FldComparisonOp == "")
            return arrSex_Sel;
        const dicFldComparisonOp = JSON.parse(objSex_Cond.sf_FldComparisonOp);
        //console.log("clsSexWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSex_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSex_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSex_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objSex_Cond), exports.sex_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.Sex_GetSubObjLst_Cache = Sex_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_Sex:关键字列表
    * @returns 对象列表
    **/
    async function Sex_GetObjLstByid_SexLstAsync(arrid_Sex) {
        const strThisFuncName = "GetObjLstByid_SexLstAsync";
        const strAction = "GetObjLstByid_SexLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_Sex);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sex_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Sex_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetObjLstByid_SexLstAsync = Sex_GetObjLstByid_SexLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_SexLst:关键字列表
     * @returns 对象列表
    */
    async function Sex_GetObjLstByid_SexLst_Cache(arrid_SexLst) {
        const strThisFuncName = "GetObjLstByid_SexLst_Cache";
        try {
            const arrSexObjLst_Cache = await Sex_GetObjLst_Cache();
            const arrSex_Sel = arrSexObjLst_Cache.filter(x => arrid_SexLst.indexOf(x.id_Sex) > -1);
            return arrSex_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_SexLst.join(","), exports.sex_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.Sex_GetObjLstByid_SexLst_Cache = Sex_GetObjLstByid_SexLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function Sex_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sex_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Sex_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetTopObjLstAsync = Sex_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function Sex_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sex_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Sex_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetObjLstByRangeAsync = Sex_GetObjLstByRangeAsync;
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
    async function Sex_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetObjLstByRange = Sex_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function Sex_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrSexObjLst_Cache = await Sex_GetObjLst_Cache();
        if (arrSexObjLst_Cache.length == 0)
            return arrSexObjLst_Cache;
        let arrSex_Sel = arrSexObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objSex_Cond = new clsSexEN_js_1.clsSexEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSex_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsSexWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSex_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSex_Sel = arrSex_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSex_Sel.length == 0)
                return arrSex_Sel;
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
                arrSex_Sel = arrSex_Sel.sort(Sex_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrSex_Sel = arrSex_Sel.sort(objPagerPara.sortFun);
            }
            arrSex_Sel = arrSex_Sel.slice(intStart, intEnd);
            return arrSex_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sex_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.Sex_GetObjLstByPager_Cache = Sex_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function Sex_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sex_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Sex_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetObjLstByPagerAsync = Sex_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strid_Sex:关键字
    * @returns 获取删除的结果
    **/
    async function Sex_DelRecordAsync(strid_Sex) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strid_Sex);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_DelRecordAsync = Sex_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_Sex:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function Sex_DelSexsAsync(arrid_Sex) {
        const strThisFuncName = "DelSexsAsync";
        const strAction = "DelSexs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_Sex);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_DelSexsAsync = Sex_DelSexsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function Sex_DelSexsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSexsByCondAsync";
        const strAction = "DelSexsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_DelSexsByCondAsync = Sex_DelSexsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSexEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Sex_AddNewRecordAsync(objSexEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objSexEN.id_Sex === null || objSexEN.id_Sex === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objSexEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSexEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_AddNewRecordAsync = Sex_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objSexEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Sex_AddNewRecordWithMaxIdAsync(objSexEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSexEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_AddNewRecordWithMaxIdAsync = Sex_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSexEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function Sex_AddNewRecordWithReturnKeyAsync(objSexEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSexEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_AddNewRecordWithReturnKeyAsync = Sex_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSexEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function Sex_AddNewRecordWithReturnKey(objSexEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSexEN.id_Sex === null || objSexEN.id_Sex === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSexEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_AddNewRecordWithReturnKey = Sex_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSexEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function Sex_UpdateRecordAsync(objSexEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSexEN.sf_UpdFldSetStr === undefined || objSexEN.sf_UpdFldSetStr === null || objSexEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSexEN.id_Sex);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSexEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_UpdateRecordAsync = Sex_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSexEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function Sex_UpdateWithConditionAsync(objSexEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSexEN.sf_UpdFldSetStr === undefined || objSexEN.sf_UpdFldSetStr === null || objSexEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSexEN.id_Sex);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        objSexEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSexEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_UpdateWithConditionAsync = Sex_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_Sex_Cond:条件对象
     * @returns 对象列表子集
    */
    async function Sex_IsExistRecord_Cache(objSex_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrSexObjLst_Cache = await Sex_GetObjLst_Cache();
        if (arrSexObjLst_Cache == null)
            return false;
        let arrSex_Sel = arrSexObjLst_Cache;
        if (objSex_Cond.sf_FldComparisonOp == null || objSex_Cond.sf_FldComparisonOp == "")
            return arrSex_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objSex_Cond.sf_FldComparisonOp);
        //console.log("clsSexWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSex_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSex_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSex_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objSex_Cond), exports.sex_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.Sex_IsExistRecord_Cache = Sex_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function Sex_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_IsExistRecordAsync = Sex_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_Sex:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function Sex_IsExist(strid_Sex, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_Sex": strid_Sex,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_IsExist = Sex_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_Sex:所给的关键字
     * @returns 对象
    */
    async function Sex_IsExist_Cache(strid_Sex) {
        const strThisFuncName = "IsExist_Cache";
        const arrSexObjLst_Cache = await Sex_GetObjLst_Cache();
        if (arrSexObjLst_Cache == null)
            return false;
        try {
            const arrSex_Sel = arrSexObjLst_Cache.filter(x => x.id_Sex == strid_Sex);
            if (arrSex_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_Sex, exports.sex_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.Sex_IsExist_Cache = Sex_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_Sex:关键字
    * @returns 是否存在?存在返回True
    **/
    async function Sex_IsExistAsync(strid_Sex) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_Sex": strid_Sex }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_IsExistAsync = Sex_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function Sex_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetRecCountByCondAsync = Sex_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objSex_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function Sex_GetRecCountByCond_Cache(objSex_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrSexObjLst_Cache = await Sex_GetObjLst_Cache();
        if (arrSexObjLst_Cache == null)
            return 0;
        let arrSex_Sel = arrSexObjLst_Cache;
        if (objSex_Cond.sf_FldComparisonOp == null || objSex_Cond.sf_FldComparisonOp == "")
            return arrSex_Sel.length;
        const dicFldComparisonOp = JSON.parse(objSex_Cond.sf_FldComparisonOp);
        //console.log("clsSexWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSex_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSex_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSex_Sel = arrSex_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSex_Sel = arrSex_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSex_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objSex_Cond), exports.sex_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.Sex_GetRecCountByCond_Cache = Sex_GetRecCountByCond_Cache;
    /*该表的关键字类型不是字符型自增，不需要生成获取最大关键字函数！*/
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function Sex_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetMaxStrIdByPrefix = Sex_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function Sex_GetWebApiUrl(strController, strAction) {
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
    exports.Sex_GetWebApiUrl = Sex_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function Sex_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsSexEN_js_1.clsSexEN._CurrTabName;
        switch (clsSexEN_js_1.clsSexEN.CacheModeId) {
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
    exports.Sex_ReFreshCache = Sex_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function Sex_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsSexEN_js_1.clsSexEN._CurrTabName;
            switch (clsSexEN_js_1.clsSexEN.CacheModeId) {
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
    exports.Sex_ReFreshThisCache = Sex_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function Sex_BindDdl_id_SexInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_id_SexInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_id_SexInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_id_SexInDiv_Cache");
        const arrObjLst_Sel = await Sex_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsSexEN_js_1.clsSexEN.con_id_Sex, clsSexEN_js_1.clsSexEN.con_SexDesc, "性别");
    }
    exports.Sex_BindDdl_id_SexInDiv_Cache = Sex_BindDdl_id_SexInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function Sex_CheckPropertyNew(pobjSexEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.id_Sex) == false && (0, clsString_js_2.GetStrLen)(pobjSexEN.id_Sex) > 4) {
            throw new Error("(errid:Watl000059)字段[性别流水号(id_Sex)]的长度不能超过4(In 性别(Sex))!值:$(pobjSexEN.id_Sex)(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.sexID) == false && (0, clsString_js_2.GetStrLen)(pobjSexEN.sexID) > 4) {
            throw new Error("(errid:Watl000059)字段[性别ID(sexID)]的长度不能超过4(In 性别(Sex))!值:$(pobjSexEN.sexID)(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.sexDesc) == false && (0, clsString_js_2.GetStrLen)(pobjSexEN.sexDesc) > 10) {
            throw new Error("(errid:Watl000059)字段[性别名称(sexDesc)]的长度不能超过10(In 性别(Sex))!值:$(pobjSexEN.sexDesc)(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.sexDesc_EN) == false && (0, clsString_js_2.GetStrLen)(pobjSexEN.sexDesc_EN) > 10) {
            throw new Error("(errid:Watl000059)字段[SexDesc_EN(sexDesc_EN)]的长度不能超过10(In 性别(Sex))!值:$(pobjSexEN.sexDesc_EN)(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.modifyDate) == false && (0, clsString_js_2.GetStrLen)(pobjSexEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 性别(Sex))!值:$(pobjSexEN.modifyDate)(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.modifyUserID) == false && (0, clsString_js_2.GetStrLen)(pobjSexEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 性别(Sex))!值:$(pobjSexEN.modifyUserID)(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjSexEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 性别(Sex))!值:$(pobjSexEN.memo)(clsSexBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.id_Sex) == false && undefined !== pobjSexEN.id_Sex && clsString_js_1.tzDataType.isString(pobjSexEN.id_Sex) === false) {
            throw new Error("(errid:Watl000060)字段[性别流水号(id_Sex)]的值:[$(pobjSexEN.id_Sex)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.sexID) == false && undefined !== pobjSexEN.sexID && clsString_js_1.tzDataType.isString(pobjSexEN.sexID) === false) {
            throw new Error("(errid:Watl000060)字段[性别ID(sexID)]的值:[$(pobjSexEN.sexID)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.sexDesc) == false && undefined !== pobjSexEN.sexDesc && clsString_js_1.tzDataType.isString(pobjSexEN.sexDesc) === false) {
            throw new Error("(errid:Watl000060)字段[性别名称(sexDesc)]的值:[$(pobjSexEN.sexDesc)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.sexDesc_EN) == false && undefined !== pobjSexEN.sexDesc_EN && clsString_js_1.tzDataType.isString(pobjSexEN.sexDesc_EN) === false) {
            throw new Error("(errid:Watl000060)字段[SexDesc_EN(sexDesc_EN)]的值:[$(pobjSexEN.sexDesc_EN)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.modifyDate) == false && undefined !== pobjSexEN.modifyDate && clsString_js_1.tzDataType.isString(pobjSexEN.modifyDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjSexEN.modifyDate)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.modifyUserID) == false && undefined !== pobjSexEN.modifyUserID && clsString_js_1.tzDataType.isString(pobjSexEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjSexEN.modifyUserID)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.memo) == false && undefined !== pobjSexEN.memo && clsString_js_1.tzDataType.isString(pobjSexEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSexEN.memo)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSexEN.SetIsCheckProperty(true);
    }
    exports.Sex_CheckPropertyNew = Sex_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function Sex_CheckProperty4Update(pobjSexEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.id_Sex) == false && (0, clsString_js_2.GetStrLen)(pobjSexEN.id_Sex) > 4) {
            throw new Error("(errid:Watl000062)字段[性别流水号(id_Sex)]的长度不能超过4(In 性别(Sex))!值:$(pobjSexEN.id_Sex)(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.sexID) == false && (0, clsString_js_2.GetStrLen)(pobjSexEN.sexID) > 4) {
            throw new Error("(errid:Watl000062)字段[性别ID(sexID)]的长度不能超过4(In 性别(Sex))!值:$(pobjSexEN.sexID)(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.sexDesc) == false && (0, clsString_js_2.GetStrLen)(pobjSexEN.sexDesc) > 10) {
            throw new Error("(errid:Watl000062)字段[性别名称(sexDesc)]的长度不能超过10(In 性别(Sex))!值:$(pobjSexEN.sexDesc)(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.sexDesc_EN) == false && (0, clsString_js_2.GetStrLen)(pobjSexEN.sexDesc_EN) > 10) {
            throw new Error("(errid:Watl000062)字段[SexDesc_EN(sexDesc_EN)]的长度不能超过10(In 性别(Sex))!值:$(pobjSexEN.sexDesc_EN)(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.modifyDate) == false && (0, clsString_js_2.GetStrLen)(pobjSexEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 性别(Sex))!值:$(pobjSexEN.modifyDate)(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.modifyUserID) == false && (0, clsString_js_2.GetStrLen)(pobjSexEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 性别(Sex))!值:$(pobjSexEN.modifyUserID)(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjSexEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 性别(Sex))!值:$(pobjSexEN.memo)(clsSexBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.id_Sex) == false && undefined !== pobjSexEN.id_Sex && clsString_js_1.tzDataType.isString(pobjSexEN.id_Sex) === false) {
            throw new Error("(errid:Watl000063)字段[性别流水号(id_Sex)]的值:[$(pobjSexEN.id_Sex)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.sexID) == false && undefined !== pobjSexEN.sexID && clsString_js_1.tzDataType.isString(pobjSexEN.sexID) === false) {
            throw new Error("(errid:Watl000063)字段[性别ID(sexID)]的值:[$(pobjSexEN.sexID)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.sexDesc) == false && undefined !== pobjSexEN.sexDesc && clsString_js_1.tzDataType.isString(pobjSexEN.sexDesc) === false) {
            throw new Error("(errid:Watl000063)字段[性别名称(sexDesc)]的值:[$(pobjSexEN.sexDesc)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.sexDesc_EN) == false && undefined !== pobjSexEN.sexDesc_EN && clsString_js_1.tzDataType.isString(pobjSexEN.sexDesc_EN) === false) {
            throw new Error("(errid:Watl000063)字段[SexDesc_EN(sexDesc_EN)]的值:[$(pobjSexEN.sexDesc_EN)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.modifyDate) == false && undefined !== pobjSexEN.modifyDate && clsString_js_1.tzDataType.isString(pobjSexEN.modifyDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjSexEN.modifyDate)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.modifyUserID) == false && undefined !== pobjSexEN.modifyUserID && clsString_js_1.tzDataType.isString(pobjSexEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjSexEN.modifyUserID)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.memo) == false && undefined !== pobjSexEN.memo && clsString_js_1.tzDataType.isString(pobjSexEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSexEN.memo)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSexEN.id_Sex) === true) {
            throw new Error("(errid:Watl000064)字段[性别流水号]不能为空(In 性别)!(clsSexBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSexEN.SetIsCheckProperty(true);
    }
    exports.Sex_CheckProperty4Update = Sex_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function Sex_GetJSONStrByObj(pobjSexEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSexEN.sf_UpdFldSetStr = pobjSexEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSexEN);
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
    exports.Sex_GetJSONStrByObj = Sex_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function Sex_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSexObjLst = new Array();
        if (strJSON === "") {
            return arrSexObjLst;
        }
        try {
            arrSexObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSexObjLst;
        }
        return arrSexObjLst;
    }
    exports.Sex_GetObjLstByJSONStr = Sex_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSexObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function Sex_GetObjLstByJSONObjLst(arrSexObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSexObjLst = new Array();
        for (const objInFor of arrSexObjLstS) {
            const obj1 = Sex_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSexObjLst.push(obj1);
        }
        return arrSexObjLst;
    }
    exports.Sex_GetObjLstByJSONObjLst = Sex_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function Sex_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSexEN = new clsSexEN_js_1.clsSexEN();
        if (strJSON === "") {
            return pobjSexEN;
        }
        try {
            pobjSexEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSexEN;
        }
        return pobjSexEN;
    }
    exports.Sex_GetObjByJSONStr = Sex_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function Sex_GetCombineCondition(objSex_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN_js_1.clsSexEN.con_id_Sex) == true) {
            const strComparisonOp_id_Sex = objSex_Cond.dicFldComparisonOp[clsSexEN_js_1.clsSexEN.con_id_Sex];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSexEN_js_1.clsSexEN.con_id_Sex, objSex_Cond.id_Sex, strComparisonOp_id_Sex);
        }
        if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN_js_1.clsSexEN.con_SexID) == true) {
            const strComparisonOp_SexID = objSex_Cond.dicFldComparisonOp[clsSexEN_js_1.clsSexEN.con_SexID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSexEN_js_1.clsSexEN.con_SexID, objSex_Cond.sexID, strComparisonOp_SexID);
        }
        if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN_js_1.clsSexEN.con_SexDesc) == true) {
            const strComparisonOp_SexDesc = objSex_Cond.dicFldComparisonOp[clsSexEN_js_1.clsSexEN.con_SexDesc];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSexEN_js_1.clsSexEN.con_SexDesc, objSex_Cond.sexDesc, strComparisonOp_SexDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN_js_1.clsSexEN.con_SexDesc_EN) == true) {
            const strComparisonOp_SexDesc_EN = objSex_Cond.dicFldComparisonOp[clsSexEN_js_1.clsSexEN.con_SexDesc_EN];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSexEN_js_1.clsSexEN.con_SexDesc_EN, objSex_Cond.sexDesc_EN, strComparisonOp_SexDesc_EN);
        }
        if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN_js_1.clsSexEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objSex_Cond.dicFldComparisonOp[clsSexEN_js_1.clsSexEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSexEN_js_1.clsSexEN.con_ModifyDate, objSex_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN_js_1.clsSexEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objSex_Cond.dicFldComparisonOp[clsSexEN_js_1.clsSexEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSexEN_js_1.clsSexEN.con_ModifyUserID, objSex_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN_js_1.clsSexEN.con_Memo) == true) {
            const strComparisonOp_Memo = objSex_Cond.dicFldComparisonOp[clsSexEN_js_1.clsSexEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSexEN_js_1.clsSexEN.con_Memo, objSex_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.Sex_GetCombineCondition = Sex_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSexENS:源对象
     * @param objSexENT:目标对象
    */
    function Sex_CopyObjTo(objSexENS, objSexENT) {
        objSexENT.id_Sex = objSexENS.id_Sex; //性别流水号
        objSexENT.sexID = objSexENS.sexID; //性别ID
        objSexENT.sexDesc = objSexENS.sexDesc; //性别名称
        objSexENT.sexDesc_EN = objSexENS.sexDesc_EN; //SexDesc_EN
        objSexENT.modifyDate = objSexENS.modifyDate; //修改日期
        objSexENT.modifyUserID = objSexENS.modifyUserID; //修改人
        objSexENT.memo = objSexENS.memo; //备注
        objSexENT.sf_UpdFldSetStr = objSexENS.updFldString; //sf_UpdFldSetStr
    }
    exports.Sex_CopyObjTo = Sex_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSexENS:源对象
     * @param objSexENT:目标对象
    */
    function Sex_GetObjFromJsonObj(objSexENS) {
        const objSexENT = new clsSexEN_js_1.clsSexEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSexENT, objSexENS);
        return objSexENT;
    }
    exports.Sex_GetObjFromJsonObj = Sex_GetObjFromJsonObj;
});
