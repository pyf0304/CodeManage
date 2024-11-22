/**
* 类名:clsXzClgWApi
* 表名:XzClg(01120064)
* 版本:2023.02.24.1(服务器:WIN-SRV103-116)
* 日期:2023/02/24 13:39:34
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/BaseInfo/clsXzClgEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzClg_GetObjFromJsonObj = exports.XzClg_CopyObjTo = exports.XzClg_GetCombineCondition = exports.XzClg_GetObjByJSONStr = exports.XzClg_GetObjLstByJSONObjLst = exports.XzClg_GetObjLstByJSONStr = exports.XzClg_GetJSONStrByObj = exports.XzClg_CheckProperty4Update = exports.XzClg_CheckPropertyNew = exports.XzClg_BindDdl_id_XzCollegeInDiv_Cache = exports.XzClg_ReFreshThisCache = exports.XzClg_ReFreshCache = exports.XzClg_GetWebApiUrl = exports.XzClg_GetMaxStrIdByPrefix = exports.XzClg_GetRecCountByCond_Cache = exports.XzClg_GetRecCountByCondAsync = exports.XzClg_IsExistAsync = exports.XzClg_IsExist_Cache = exports.XzClg_IsExist = exports.XzClg_IsExistRecordAsync = exports.XzClg_IsExistRecord_Cache = exports.XzClg_UpdateWithConditionAsync = exports.XzClg_UpdateRecordAsync = exports.XzClg_AddNewRecordWithReturnKey = exports.XzClg_AddNewRecordWithReturnKeyAsync = exports.XzClg_AddNewRecordWithMaxIdAsync = exports.XzClg_AddNewRecordAsync = exports.XzClg_DelXzClgsByCondAsync = exports.XzClg_DelXzClgsAsync = exports.XzClg_DelRecordAsync = exports.XzClg_GetObjLstByPagerAsync = exports.XzClg_GetObjLstByPager_Cache = exports.XzClg_GetObjLstByRange = exports.XzClg_GetObjLstByRangeAsync = exports.XzClg_GetTopObjLstAsync = exports.XzClg_GetObjLstByid_XzCollegeLst_Cache = exports.XzClg_GetObjLstByid_XzCollegeLstAsync = exports.XzClg_GetSubObjLst_Cache = exports.XzClg_GetObjLst_PureCache = exports.XzClg_GetObjLst_Cache = exports.XzClg_GetObjLst_sessionStorage_PureCache = exports.XzClg_GetObjLst_sessionStorage = exports.XzClg_GetObjLstAsync = exports.XzClg_GetObjLst_localStorage_PureCache = exports.XzClg_GetObjLst_localStorage = exports.XzClg_GetObjLst_ClientCache = exports.XzClg_GetFirstObjAsync = exports.XzClg_GetFirstID = exports.XzClg_GetFirstIDAsync = exports.XzClg_funcKey = exports.XzClg_FilterFunByKey = exports.XzClg_SortFunByKey = exports.XzClg_SortFun_Defa_2Fld = exports.XzClg_SortFun_Defa = exports.XzClg_func = exports.XzClg_GetNameByid_XzCollege_Cache = exports.XzClg_UpdateObjInLst_Cache = exports.XzClg_GetObjByid_XzCollege_localStorage = exports.XzClg_GetObjByid_XzCollege_Cache = exports.XzClg_GetObjByid_XzCollegeAsync = exports.xzClg_ConstructorName = exports.xzClg_Controller = void 0;
    /**
     * 学院(XzClg)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年02月24日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsXzClgEN_js_1 = require("../../L0_Entity/BaseInfo/clsXzClgEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.xzClg_Controller = "XzClgApi";
    exports.xzClg_ConstructorName = "xzClg";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_XzCollege:关键字
    * @returns 对象
    **/
    async function XzClg_GetObjByid_XzCollegeAsync(strid_XzCollege) {
        const strThisFuncName = "GetObjByid_XzCollegeAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzCollege) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzCollege]不能为空！(In GetObjByid_XzCollegeAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzCollege.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzCollege]的长度:[{0}]不正确！", strid_XzCollege.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_XzCollege";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_XzCollege": strid_XzCollege,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objXzClg = XzClg_GetObjFromJsonObj(returnObj);
                return objXzClg;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_GetObjByid_XzCollegeAsync = XzClg_GetObjByid_XzCollegeAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_XzCollege:所给的关键字
     * @returns 对象
    */
    async function XzClg_GetObjByid_XzCollege_Cache(strid_XzCollege, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_XzCollege_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzCollege) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzCollege]不能为空！(In GetObjByid_XzCollege_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzCollege.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzCollege]的长度:[{0}]不正确！", strid_XzCollege.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzClgObjLst_Cache = await XzClg_GetObjLst_Cache();
        try {
            const arrXzClg_Sel = arrXzClgObjLst_Cache.filter(x => x.id_XzCollege == strid_XzCollege);
            let objXzClg;
            if (arrXzClg_Sel.length > 0) {
                objXzClg = arrXzClg_Sel[0];
                return objXzClg;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objXzClg_Const = await XzClg_GetObjByid_XzCollegeAsync(strid_XzCollege);
                    if (objXzClg_Const != null) {
                        XzClg_ReFreshThisCache();
                        return objXzClg_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_XzCollege, exports.xzClg_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.XzClg_GetObjByid_XzCollege_Cache = XzClg_GetObjByid_XzCollege_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_XzCollege:所给的关键字
     * @returns 对象
    */
    async function XzClg_GetObjByid_XzCollege_localStorage(strid_XzCollege) {
        const strThisFuncName = "GetObjByid_XzCollege_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzCollege) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzCollege]不能为空！(In GetObjByid_XzCollege_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzCollege.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzCollege]的长度:[{0}]不正确！", strid_XzCollege.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsXzClgEN_js_1.clsXzClgEN._CurrTabName, strid_XzCollege);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objXzClg_Cache = JSON.parse(strTempObj);
            return objXzClg_Cache;
        }
        try {
            const objXzClg = await XzClg_GetObjByid_XzCollegeAsync(strid_XzCollege);
            if (objXzClg != null) {
                localStorage.setItem(strKey, JSON.stringify(objXzClg));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objXzClg;
            }
            return objXzClg;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_XzCollege, exports.xzClg_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.XzClg_GetObjByid_XzCollege_localStorage = XzClg_GetObjByid_XzCollege_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objXzClg:所给的对象
     * @returns 对象
    */
    async function XzClg_UpdateObjInLst_Cache(objXzClg) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrXzClgObjLst_Cache = await XzClg_GetObjLst_Cache();
            const obj = arrXzClgObjLst_Cache.find(x => x.id_XzCollege == objXzClg.id_XzCollege);
            if (obj != null) {
                objXzClg.id_XzCollege = obj.id_XzCollege;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objXzClg);
            }
            else {
                arrXzClgObjLst_Cache.push(objXzClg);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.xzClg_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.XzClg_UpdateObjInLst_Cache = XzClg_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_XzCollege:所给的关键字
     * @returns 对象
    */
    async function XzClg_GetNameByid_XzCollege_Cache(strid_XzCollege) {
        const strThisFuncName = "GetNameByid_XzCollege_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzCollege) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzCollege]不能为空！(In GetNameByid_XzCollege_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzCollege.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzCollege]的长度:[{0}]不正确！", strid_XzCollege.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzClgObjLst_Cache = await XzClg_GetObjLst_Cache();
        if (arrXzClgObjLst_Cache == null)
            return "";
        try {
            const arrXzClg_Sel = arrXzClgObjLst_Cache.filter(x => x.id_XzCollege == strid_XzCollege);
            let objXzClg;
            if (arrXzClg_Sel.length > 0) {
                objXzClg = arrXzClg_Sel[0];
                return objXzClg.collegeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_XzCollege);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.XzClg_GetNameByid_XzCollege_Cache = XzClg_GetNameByid_XzCollege_Cache;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function XzClg_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsXzClgEN_js_1.clsXzClgEN.con_id_XzCollege) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsXzClgEN_js_1.clsXzClgEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsXzClgEN_js_1.clsXzClgEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_XzCollege = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objXzClg = await XzClg_GetObjByid_XzCollege_Cache(strid_XzCollege);
        if (objXzClg == null)
            return "";
        if (objXzClg.GetFldValue(strOutFldName) == null)
            return "";
        return objXzClg.GetFldValue(strOutFldName).toString();
    }
    exports.XzClg_func = XzClg_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzClg_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_XzCollege.localeCompare(b.id_XzCollege);
    }
    exports.XzClg_SortFun_Defa = XzClg_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzClg_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.collegeID == b.collegeID)
            return a.collegeName.localeCompare(b.collegeName);
        else
            return a.collegeID.localeCompare(b.collegeID);
    }
    exports.XzClg_SortFun_Defa_2Fld = XzClg_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzClg_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsXzClgEN_js_1.clsXzClgEN.con_id_XzCollege:
                    return (a, b) => {
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_CollegeID:
                    return (a, b) => {
                        return a.collegeID.localeCompare(b.collegeID);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_CollegeName:
                    return (a, b) => {
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_CollegeIdInGP:
                    return (a, b) => {
                        if (a.collegeIdInGP == null)
                            return -1;
                        if (b.collegeIdInGP == null)
                            return 1;
                        return a.collegeIdInGP.localeCompare(b.collegeIdInGP);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_ClgEnglishName:
                    return (a, b) => {
                        if (a.clgEnglishName == null)
                            return -1;
                        if (b.clgEnglishName == null)
                            return 1;
                        return a.clgEnglishName.localeCompare(b.clgEnglishName);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_CollegeNameA:
                    return (a, b) => {
                        return a.collegeNameA.localeCompare(b.collegeNameA);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_PhoneNumber:
                    return (a, b) => {
                        if (a.phoneNumber == null)
                            return -1;
                        if (b.phoneNumber == null)
                            return 1;
                        return a.phoneNumber.localeCompare(b.phoneNumber);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_WebSite:
                    return (a, b) => {
                        if (a.webSite == null)
                            return -1;
                        if (b.webSite == null)
                            return 1;
                        return a.webSite.localeCompare(b.webSite);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_id_School:
                    return (a, b) => {
                        if (a.id_School == null)
                            return -1;
                        if (b.id_School == null)
                            return 1;
                        return a.id_School.localeCompare(b.id_School);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_id_Uni:
                    return (a, b) => {
                        if (a.id_Uni == null)
                            return -1;
                        if (b.id_Uni == null)
                            return 1;
                        return a.id_Uni.localeCompare(b.id_Uni);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_IsVisible4Tea:
                    return (a, b) => {
                        if (a.isVisible4Tea == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_IsVisible:
                    return (a, b) => {
                        if (a.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_ModifyDate:
                    return (a, b) => {
                        if (a.modifyDate == null)
                            return -1;
                        if (b.modifyDate == null)
                            return 1;
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_ModifyUserID:
                    return (a, b) => {
                        if (a.modifyUserID == null)
                            return -1;
                        if (b.modifyUserID == null)
                            return 1;
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzClg]中不存在！(in ${exports.xzClg_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsXzClgEN_js_1.clsXzClgEN.con_id_XzCollege:
                    return (a, b) => {
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_CollegeID:
                    return (a, b) => {
                        return b.collegeID.localeCompare(a.collegeID);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_CollegeName:
                    return (a, b) => {
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_CollegeIdInGP:
                    return (a, b) => {
                        if (b.collegeIdInGP == null)
                            return -1;
                        if (a.collegeIdInGP == null)
                            return 1;
                        return b.collegeIdInGP.localeCompare(a.collegeIdInGP);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_ClgEnglishName:
                    return (a, b) => {
                        if (b.clgEnglishName == null)
                            return -1;
                        if (a.clgEnglishName == null)
                            return 1;
                        return b.clgEnglishName.localeCompare(a.clgEnglishName);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_CollegeNameA:
                    return (a, b) => {
                        return b.collegeNameA.localeCompare(a.collegeNameA);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_PhoneNumber:
                    return (a, b) => {
                        if (b.phoneNumber == null)
                            return -1;
                        if (a.phoneNumber == null)
                            return 1;
                        return b.phoneNumber.localeCompare(a.phoneNumber);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_WebSite:
                    return (a, b) => {
                        if (b.webSite == null)
                            return -1;
                        if (a.webSite == null)
                            return 1;
                        return b.webSite.localeCompare(a.webSite);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_id_School:
                    return (a, b) => {
                        if (b.id_School == null)
                            return -1;
                        if (a.id_School == null)
                            return 1;
                        return b.id_School.localeCompare(a.id_School);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_id_Uni:
                    return (a, b) => {
                        if (b.id_Uni == null)
                            return -1;
                        if (a.id_Uni == null)
                            return 1;
                        return b.id_Uni.localeCompare(a.id_Uni);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_IsVisible4Tea:
                    return (a, b) => {
                        if (b.isVisible4Tea == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_IsVisible:
                    return (a, b) => {
                        if (b.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_ModifyDate:
                    return (a, b) => {
                        if (b.modifyDate == null)
                            return -1;
                        if (a.modifyDate == null)
                            return 1;
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_ModifyUserID:
                    return (a, b) => {
                        if (b.modifyUserID == null)
                            return -1;
                        if (a.modifyUserID == null)
                            return 1;
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsXzClgEN_js_1.clsXzClgEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzClg]中不存在！(in ${exports.xzClg_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.XzClg_SortFunByKey = XzClg_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function XzClg_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsXzClgEN_js_1.clsXzClgEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsXzClgEN_js_1.clsXzClgEN.con_CollegeID:
                return (obj) => {
                    return obj.collegeID === value;
                };
            case clsXzClgEN_js_1.clsXzClgEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsXzClgEN_js_1.clsXzClgEN.con_CollegeIdInGP:
                return (obj) => {
                    return obj.collegeIdInGP === value;
                };
            case clsXzClgEN_js_1.clsXzClgEN.con_ClgEnglishName:
                return (obj) => {
                    return obj.clgEnglishName === value;
                };
            case clsXzClgEN_js_1.clsXzClgEN.con_CollegeNameA:
                return (obj) => {
                    return obj.collegeNameA === value;
                };
            case clsXzClgEN_js_1.clsXzClgEN.con_PhoneNumber:
                return (obj) => {
                    return obj.phoneNumber === value;
                };
            case clsXzClgEN_js_1.clsXzClgEN.con_WebSite:
                return (obj) => {
                    return obj.webSite === value;
                };
            case clsXzClgEN_js_1.clsXzClgEN.con_id_School:
                return (obj) => {
                    return obj.id_School === value;
                };
            case clsXzClgEN_js_1.clsXzClgEN.con_id_Uni:
                return (obj) => {
                    return obj.id_Uni === value;
                };
            case clsXzClgEN_js_1.clsXzClgEN.con_IsVisible4Tea:
                return (obj) => {
                    return obj.isVisible4Tea === value;
                };
            case clsXzClgEN_js_1.clsXzClgEN.con_IsVisible:
                return (obj) => {
                    return obj.isVisible === value;
                };
            case clsXzClgEN_js_1.clsXzClgEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsXzClgEN_js_1.clsXzClgEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsXzClgEN_js_1.clsXzClgEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsXzClgEN_js_1.clsXzClgEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[XzClg]中不存在！(in ${exports.xzClg_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.XzClg_FilterFunByKey = XzClg_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function XzClg_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsXzClgEN_js_1.clsXzClgEN.con_id_XzCollege) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrXzClg = await XzClg_GetObjLst_Cache();
        if (arrXzClg == null)
            return [];
        let arrXzClg_Sel = arrXzClg;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrXzClg_Sel = arrXzClg_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrXzClg_Sel.length == 0)
            return [];
        return arrXzClg_Sel.map(x => x.id_XzCollege);
    }
    exports.XzClg_funcKey = XzClg_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzClg_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_GetFirstIDAsync = XzClg_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function XzClg_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_GetFirstID = XzClg_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function XzClg_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
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
                const objXzClg = XzClg_GetObjFromJsonObj(returnObj);
                return objXzClg;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_GetFirstObjAsync = XzClg_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzClg_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzClgEN_js_1.clsXzClgEN._CurrTabName;
        clsXzClgEN_js_1.clsXzClgEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsXzClgEN_js_1.clsXzClgEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsXzClgEN_js_1.clsXzClgEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsXzClgEN_js_1.clsXzClgEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrXzClgExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrXzClgObjLst_T = XzClg_GetObjLstByJSONObjLst(arrXzClgExObjLst_Cache);
            return arrXzClgObjLst_T;
        }
        try {
            const arrXzClgExObjLst = await XzClg_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrXzClgExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzClgExObjLst.length);
            console.log(strInfo);
            return arrXzClgExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzClg_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzClg_GetObjLst_ClientCache = XzClg_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzClg_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzClgEN_js_1.clsXzClgEN._CurrTabName;
        clsXzClgEN_js_1.clsXzClgEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsXzClgEN_js_1.clsXzClgEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsXzClgEN_js_1.clsXzClgEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsXzClgEN_js_1.clsXzClgEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzClgExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzClgObjLst_T = XzClg_GetObjLstByJSONObjLst(arrXzClgExObjLst_Cache);
            return arrXzClgObjLst_T;
        }
        try {
            const arrXzClgExObjLst = await XzClg_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrXzClgExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzClgExObjLst.length);
            console.log(strInfo);
            return arrXzClgExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzClg_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzClg_GetObjLst_localStorage = XzClg_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzClg_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzClgEN_js_1.clsXzClgEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzClgObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzClgObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzClg_GetObjLst_localStorage_PureCache = XzClg_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function XzClg_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzClg_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzClg_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_GetObjLstAsync = XzClg_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzClg_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzClgEN_js_1.clsXzClgEN._CurrTabName;
        clsXzClgEN_js_1.clsXzClgEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsXzClgEN_js_1.clsXzClgEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsXzClgEN_js_1.clsXzClgEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsXzClgEN_js_1.clsXzClgEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzClgExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzClgObjLst_T = XzClg_GetObjLstByJSONObjLst(arrXzClgExObjLst_Cache);
            return arrXzClgObjLst_T;
        }
        try {
            const arrXzClgExObjLst = await XzClg_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrXzClgExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzClgExObjLst.length);
            console.log(strInfo);
            return arrXzClgExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzClg_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzClg_GetObjLst_sessionStorage = XzClg_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzClg_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzClgEN_js_1.clsXzClgEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzClgObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzClgObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzClg_GetObjLst_sessionStorage_PureCache = XzClg_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzClg_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrXzClgObjLst_Cache;
        switch (clsXzClgEN_js_1.clsXzClgEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzClgObjLst_Cache = await XzClg_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrXzClgObjLst_Cache = await XzClg_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrXzClgObjLst_Cache = await XzClg_GetObjLst_ClientCache();
                break;
            default:
                arrXzClgObjLst_Cache = await XzClg_GetObjLst_ClientCache();
                break;
        }
        const arrXzClgObjLst = XzClg_GetObjLstByJSONObjLst(arrXzClgObjLst_Cache);
        return arrXzClgObjLst_Cache;
    }
    exports.XzClg_GetObjLst_Cache = XzClg_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzClg_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrXzClgObjLst_Cache;
        switch (clsXzClgEN_js_1.clsXzClgEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzClgObjLst_Cache = await XzClg_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrXzClgObjLst_Cache = await XzClg_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrXzClgObjLst_Cache = null;
                break;
            default:
                arrXzClgObjLst_Cache = null;
                break;
        }
        return arrXzClgObjLst_Cache;
    }
    exports.XzClg_GetObjLst_PureCache = XzClg_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_XzCollege_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzClg_GetSubObjLst_Cache(objXzClg_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrXzClgObjLst_Cache = await XzClg_GetObjLst_Cache();
        let arrXzClg_Sel = arrXzClgObjLst_Cache;
        if (objXzClg_Cond.sf_FldComparisonOp == null || objXzClg_Cond.sf_FldComparisonOp == "")
            return arrXzClg_Sel;
        const dicFldComparisonOp = JSON.parse(objXzClg_Cond.sf_FldComparisonOp);
        //console.log("clsXzClgWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzClg_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzClg_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzClg_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objXzClg_Cond), exports.xzClg_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzClg_GetSubObjLst_Cache = XzClg_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_XzCollege:关键字列表
    * @returns 对象列表
    **/
    async function XzClg_GetObjLstByid_XzCollegeLstAsync(arrid_XzCollege) {
        const strThisFuncName = "GetObjLstByid_XzCollegeLstAsync";
        const strAction = "GetObjLstByid_XzCollegeLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_XzCollege);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzClg_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzClg_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_GetObjLstByid_XzCollegeLstAsync = XzClg_GetObjLstByid_XzCollegeLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_XzCollegeLst:关键字列表
     * @returns 对象列表
    */
    async function XzClg_GetObjLstByid_XzCollegeLst_Cache(arrid_XzCollegeLst) {
        const strThisFuncName = "GetObjLstByid_XzCollegeLst_Cache";
        try {
            const arrXzClgObjLst_Cache = await XzClg_GetObjLst_Cache();
            const arrXzClg_Sel = arrXzClgObjLst_Cache.filter(x => arrid_XzCollegeLst.indexOf(x.id_XzCollege) > -1);
            return arrXzClg_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_XzCollegeLst.join(","), exports.xzClg_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzClg_GetObjLstByid_XzCollegeLst_Cache = XzClg_GetObjLstByid_XzCollegeLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function XzClg_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzClg_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzClg_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_GetTopObjLstAsync = XzClg_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzClg_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzClg_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzClg_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_GetObjLstByRangeAsync = XzClg_GetObjLstByRangeAsync;
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
    async function XzClg_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_GetObjLstByRange = XzClg_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function XzClg_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrXzClgObjLst_Cache = await XzClg_GetObjLst_Cache();
        if (arrXzClgObjLst_Cache.length == 0)
            return arrXzClgObjLst_Cache;
        let arrXzClg_Sel = arrXzClgObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objXzClg_Cond = new clsXzClgEN_js_1.clsXzClgEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzClg_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsXzClgWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzClg_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzClg_Sel.length == 0)
                return arrXzClg_Sel;
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
                arrXzClg_Sel = arrXzClg_Sel.sort(XzClg_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrXzClg_Sel = arrXzClg_Sel.sort(objPagerPara.sortFun);
            }
            arrXzClg_Sel = arrXzClg_Sel.slice(intStart, intEnd);
            return arrXzClg_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.xzClg_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzClg_GetObjLstByPager_Cache = XzClg_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzClg_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzClg_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzClg_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_GetObjLstByPagerAsync = XzClg_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strid_XzCollege:关键字
    * @returns 获取删除的结果
    **/
    async function XzClg_DelRecordAsync(strid_XzCollege) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strid_XzCollege);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_DelRecordAsync = XzClg_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_XzCollege:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function XzClg_DelXzClgsAsync(arrid_XzCollege) {
        const strThisFuncName = "DelXzClgsAsync";
        const strAction = "DelXzClgs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_XzCollege);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_DelXzClgsAsync = XzClg_DelXzClgsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function XzClg_DelXzClgsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelXzClgsByCondAsync";
        const strAction = "DelXzClgsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_DelXzClgsByCondAsync = XzClg_DelXzClgsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objXzClgEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzClg_AddNewRecordAsync(objXzClgEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objXzClgEN.id_XzCollege === null || objXzClgEN.id_XzCollege === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objXzClgEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzClgEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_AddNewRecordAsync = XzClg_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objXzClgEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzClg_AddNewRecordWithMaxIdAsync(objXzClgEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzClgEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_AddNewRecordWithMaxIdAsync = XzClg_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objXzClgEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function XzClg_AddNewRecordWithReturnKeyAsync(objXzClgEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzClgEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_AddNewRecordWithReturnKeyAsync = XzClg_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objXzClgEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function XzClg_AddNewRecordWithReturnKey(objXzClgEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objXzClgEN.id_XzCollege === null || objXzClgEN.id_XzCollege === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzClgEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_AddNewRecordWithReturnKey = XzClg_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objXzClgEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function XzClg_UpdateRecordAsync(objXzClgEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objXzClgEN.sf_UpdFldSetStr === undefined || objXzClgEN.sf_UpdFldSetStr === null || objXzClgEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzClgEN.id_XzCollege);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzClgEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_UpdateRecordAsync = XzClg_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objXzClgEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzClg_UpdateWithConditionAsync(objXzClgEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objXzClgEN.sf_UpdFldSetStr === undefined || objXzClgEN.sf_UpdFldSetStr === null || objXzClgEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzClgEN.id_XzCollege);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
        objXzClgEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objXzClgEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_UpdateWithConditionAsync = XzClg_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_XzCollege_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzClg_IsExistRecord_Cache(objXzClg_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrXzClgObjLst_Cache = await XzClg_GetObjLst_Cache();
        if (arrXzClgObjLst_Cache == null)
            return false;
        let arrXzClg_Sel = arrXzClgObjLst_Cache;
        if (objXzClg_Cond.sf_FldComparisonOp == null || objXzClg_Cond.sf_FldComparisonOp == "")
            return arrXzClg_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objXzClg_Cond.sf_FldComparisonOp);
        //console.log("clsXzClgWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzClg_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzClg_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzClg_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objXzClg_Cond), exports.xzClg_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.XzClg_IsExistRecord_Cache = XzClg_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function XzClg_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_IsExistRecordAsync = XzClg_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_XzCollege:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function XzClg_IsExist(strid_XzCollege, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_XzCollege": strid_XzCollege,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_IsExist = XzClg_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_XzCollege:所给的关键字
     * @returns 对象
    */
    async function XzClg_IsExist_Cache(strid_XzCollege) {
        const strThisFuncName = "IsExist_Cache";
        const arrXzClgObjLst_Cache = await XzClg_GetObjLst_Cache();
        if (arrXzClgObjLst_Cache == null)
            return false;
        try {
            const arrXzClg_Sel = arrXzClgObjLst_Cache.filter(x => x.id_XzCollege == strid_XzCollege);
            if (arrXzClg_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_XzCollege, exports.xzClg_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.XzClg_IsExist_Cache = XzClg_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_XzCollege:关键字
    * @returns 是否存在?存在返回True
    **/
    async function XzClg_IsExistAsync(strid_XzCollege) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_XzCollege": strid_XzCollege }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_IsExistAsync = XzClg_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function XzClg_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_GetRecCountByCondAsync = XzClg_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objXzClg_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function XzClg_GetRecCountByCond_Cache(objXzClg_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrXzClgObjLst_Cache = await XzClg_GetObjLst_Cache();
        if (arrXzClgObjLst_Cache == null)
            return 0;
        let arrXzClg_Sel = arrXzClgObjLst_Cache;
        if (objXzClg_Cond.sf_FldComparisonOp == null || objXzClg_Cond.sf_FldComparisonOp == "")
            return arrXzClg_Sel.length;
        const dicFldComparisonOp = JSON.parse(objXzClg_Cond.sf_FldComparisonOp);
        //console.log("clsXzClgWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzClg_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzClg_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzClg_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objXzClg_Cond), exports.xzClg_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.XzClg_GetRecCountByCond_Cache = XzClg_GetRecCountByCond_Cache;
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
    async function XzClg_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzClg_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzClg_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzClg_GetMaxStrIdByPrefix = XzClg_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function XzClg_GetWebApiUrl(strController, strAction) {
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
    exports.XzClg_GetWebApiUrl = XzClg_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function XzClg_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsXzClgEN_js_1.clsXzClgEN._CurrTabName;
        switch (clsXzClgEN_js_1.clsXzClgEN.CacheModeId) {
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
    exports.XzClg_ReFreshCache = XzClg_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function XzClg_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsXzClgEN_js_1.clsXzClgEN._CurrTabName;
            switch (clsXzClgEN_js_1.clsXzClgEN.CacheModeId) {
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
    exports.XzClg_ReFreshThisCache = XzClg_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function XzClg_BindDdl_id_XzCollegeInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_id_XzCollegeInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_id_XzCollegeInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_id_XzCollegeInDiv_Cache");
        const arrObjLst_Sel = await XzClg_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsXzClgEN_js_1.clsXzClgEN.con_id_XzCollege, clsXzClgEN_js_1.clsXzClgEN.con_CollegeName, "学院");
    }
    exports.XzClg_BindDdl_id_XzCollegeInDiv_Cache = XzClg_BindDdl_id_XzCollegeInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzClg_CheckPropertyNew(pobjXzClgEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeID) === true) {
            throw new Error("(errid:Watl000058)字段[学院ID]不能为空(In 学院)!(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeName) === true) {
            throw new Error("(errid:Watl000058)字段[学院名称]不能为空(In 学院)!(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeNameA) === true) {
            throw new Error("(errid:Watl000058)字段[学院名称简写]不能为空(In 学院)!(clsXzClgBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.id_XzCollege) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 学院(XzClg))!值:$(pobjXzClgEN.id_XzCollege)(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeID) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.collegeID) > 4) {
            throw new Error("(errid:Watl000059)字段[学院ID(collegeID)]的长度不能超过4(In 学院(XzClg))!值:$(pobjXzClgEN.collegeID)(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeName) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.collegeName) > 100) {
            throw new Error("(errid:Watl000059)字段[学院名称(collegeName)]的长度不能超过100(In 学院(XzClg))!值:$(pobjXzClgEN.collegeName)(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeIdInGP) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.collegeIdInGP) > 6) {
            throw new Error("(errid:Watl000059)字段[CollegeIdInGP(collegeIdInGP)]的长度不能超过6(In 学院(XzClg))!值:$(pobjXzClgEN.collegeIdInGP)(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.clgEnglishName) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.clgEnglishName) > 60) {
            throw new Error("(errid:Watl000059)字段[ClgEnglishName(clgEnglishName)]的长度不能超过60(In 学院(XzClg))!值:$(pobjXzClgEN.clgEnglishName)(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeNameA) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.collegeNameA) > 12) {
            throw new Error("(errid:Watl000059)字段[学院名称简写(collegeNameA)]的长度不能超过12(In 学院(XzClg))!值:$(pobjXzClgEN.collegeNameA)(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.phoneNumber) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.phoneNumber) > 15) {
            throw new Error("(errid:Watl000059)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In 学院(XzClg))!值:$(pobjXzClgEN.phoneNumber)(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.webSite) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.webSite) > 60) {
            throw new Error("(errid:Watl000059)字段[个人主页(webSite)]的长度不能超过60(In 学院(XzClg))!值:$(pobjXzClgEN.webSite)(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.id_School) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.id_School) > 4) {
            throw new Error("(errid:Watl000059)字段[学校流水号(id_School)]的长度不能超过4(In 学院(XzClg))!值:$(pobjXzClgEN.id_School)(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.id_Uni) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.id_Uni) > 4) {
            throw new Error("(errid:Watl000059)字段[id_Uni(id_Uni)]的长度不能超过4(In 学院(XzClg))!值:$(pobjXzClgEN.id_Uni)(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.modifyDate) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 学院(XzClg))!值:$(pobjXzClgEN.modifyDate)(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.modifyUserID) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 学院(XzClg))!值:$(pobjXzClgEN.modifyUserID)(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 学院(XzClg))!值:$(pobjXzClgEN.memo)(clsXzClgBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.id_XzCollege) == false && undefined !== pobjXzClgEN.id_XzCollege && jsString_js_1.tzDataType.isString(pobjXzClgEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjXzClgEN.id_XzCollege)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeID) == false && undefined !== pobjXzClgEN.collegeID && jsString_js_1.tzDataType.isString(pobjXzClgEN.collegeID) === false) {
            throw new Error("(errid:Watl000060)字段[学院ID(collegeID)]的值:[$(pobjXzClgEN.collegeID)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeName) == false && undefined !== pobjXzClgEN.collegeName && jsString_js_1.tzDataType.isString(pobjXzClgEN.collegeName) === false) {
            throw new Error("(errid:Watl000060)字段[学院名称(collegeName)]的值:[$(pobjXzClgEN.collegeName)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeIdInGP) == false && undefined !== pobjXzClgEN.collegeIdInGP && jsString_js_1.tzDataType.isString(pobjXzClgEN.collegeIdInGP) === false) {
            throw new Error("(errid:Watl000060)字段[CollegeIdInGP(collegeIdInGP)]的值:[$(pobjXzClgEN.collegeIdInGP)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.clgEnglishName) == false && undefined !== pobjXzClgEN.clgEnglishName && jsString_js_1.tzDataType.isString(pobjXzClgEN.clgEnglishName) === false) {
            throw new Error("(errid:Watl000060)字段[ClgEnglishName(clgEnglishName)]的值:[$(pobjXzClgEN.clgEnglishName)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeNameA) == false && undefined !== pobjXzClgEN.collegeNameA && jsString_js_1.tzDataType.isString(pobjXzClgEN.collegeNameA) === false) {
            throw new Error("(errid:Watl000060)字段[学院名称简写(collegeNameA)]的值:[$(pobjXzClgEN.collegeNameA)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.phoneNumber) == false && undefined !== pobjXzClgEN.phoneNumber && jsString_js_1.tzDataType.isString(pobjXzClgEN.phoneNumber) === false) {
            throw new Error("(errid:Watl000060)字段[PhoneNumber(phoneNumber)]的值:[$(pobjXzClgEN.phoneNumber)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.webSite) == false && undefined !== pobjXzClgEN.webSite && jsString_js_1.tzDataType.isString(pobjXzClgEN.webSite) === false) {
            throw new Error("(errid:Watl000060)字段[个人主页(webSite)]的值:[$(pobjXzClgEN.webSite)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.id_School) == false && undefined !== pobjXzClgEN.id_School && jsString_js_1.tzDataType.isString(pobjXzClgEN.id_School) === false) {
            throw new Error("(errid:Watl000060)字段[学校流水号(id_School)]的值:[$(pobjXzClgEN.id_School)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.id_Uni) == false && undefined !== pobjXzClgEN.id_Uni && jsString_js_1.tzDataType.isString(pobjXzClgEN.id_Uni) === false) {
            throw new Error("(errid:Watl000060)字段[id_Uni(id_Uni)]的值:[$(pobjXzClgEN.id_Uni)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckPropertyNew)");
        }
        if (null != pobjXzClgEN.isVisible4Tea && undefined !== pobjXzClgEN.isVisible4Tea && jsString_js_1.tzDataType.isBoolean(pobjXzClgEN.isVisible4Tea) === false) {
            throw new Error("(errid:Watl000060)字段[IsVisible4Tea(isVisible4Tea)]的值:[$(pobjXzClgEN.isVisible4Tea)], 非法，应该为布尔型(In 学院(XzClg))!(clsXzClgBL:CheckPropertyNew)");
        }
        if (null != pobjXzClgEN.isVisible && undefined !== pobjXzClgEN.isVisible && jsString_js_1.tzDataType.isBoolean(pobjXzClgEN.isVisible) === false) {
            throw new Error("(errid:Watl000060)字段[是否显示(isVisible)]的值:[$(pobjXzClgEN.isVisible)], 非法，应该为布尔型(In 学院(XzClg))!(clsXzClgBL:CheckPropertyNew)");
        }
        if (null != pobjXzClgEN.orderNum && undefined !== pobjXzClgEN.orderNum && jsString_js_1.tzDataType.isNumber(pobjXzClgEN.orderNum) === false) {
            throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjXzClgEN.orderNum)], 非法，应该为数值型(In 学院(XzClg))!(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.modifyDate) == false && undefined !== pobjXzClgEN.modifyDate && jsString_js_1.tzDataType.isString(pobjXzClgEN.modifyDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjXzClgEN.modifyDate)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.modifyUserID) == false && undefined !== pobjXzClgEN.modifyUserID && jsString_js_1.tzDataType.isString(pobjXzClgEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjXzClgEN.modifyUserID)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.memo) == false && undefined !== pobjXzClgEN.memo && jsString_js_1.tzDataType.isString(pobjXzClgEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjXzClgEN.memo)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjXzClgEN.SetIsCheckProperty(true);
    }
    exports.XzClg_CheckPropertyNew = XzClg_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzClg_CheckProperty4Update(pobjXzClgEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.id_XzCollege) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 学院(XzClg))!值:$(pobjXzClgEN.id_XzCollege)(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeID) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.collegeID) > 4) {
            throw new Error("(errid:Watl000062)字段[学院ID(collegeID)]的长度不能超过4(In 学院(XzClg))!值:$(pobjXzClgEN.collegeID)(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeName) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.collegeName) > 100) {
            throw new Error("(errid:Watl000062)字段[学院名称(collegeName)]的长度不能超过100(In 学院(XzClg))!值:$(pobjXzClgEN.collegeName)(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeIdInGP) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.collegeIdInGP) > 6) {
            throw new Error("(errid:Watl000062)字段[CollegeIdInGP(collegeIdInGP)]的长度不能超过6(In 学院(XzClg))!值:$(pobjXzClgEN.collegeIdInGP)(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.clgEnglishName) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.clgEnglishName) > 60) {
            throw new Error("(errid:Watl000062)字段[ClgEnglishName(clgEnglishName)]的长度不能超过60(In 学院(XzClg))!值:$(pobjXzClgEN.clgEnglishName)(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeNameA) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.collegeNameA) > 12) {
            throw new Error("(errid:Watl000062)字段[学院名称简写(collegeNameA)]的长度不能超过12(In 学院(XzClg))!值:$(pobjXzClgEN.collegeNameA)(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.phoneNumber) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.phoneNumber) > 15) {
            throw new Error("(errid:Watl000062)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In 学院(XzClg))!值:$(pobjXzClgEN.phoneNumber)(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.webSite) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.webSite) > 60) {
            throw new Error("(errid:Watl000062)字段[个人主页(webSite)]的长度不能超过60(In 学院(XzClg))!值:$(pobjXzClgEN.webSite)(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.id_School) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.id_School) > 4) {
            throw new Error("(errid:Watl000062)字段[学校流水号(id_School)]的长度不能超过4(In 学院(XzClg))!值:$(pobjXzClgEN.id_School)(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.id_Uni) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.id_Uni) > 4) {
            throw new Error("(errid:Watl000062)字段[id_Uni(id_Uni)]的长度不能超过4(In 学院(XzClg))!值:$(pobjXzClgEN.id_Uni)(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.modifyDate) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 学院(XzClg))!值:$(pobjXzClgEN.modifyDate)(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.modifyUserID) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 学院(XzClg))!值:$(pobjXzClgEN.modifyUserID)(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjXzClgEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 学院(XzClg))!值:$(pobjXzClgEN.memo)(clsXzClgBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.id_XzCollege) == false && undefined !== pobjXzClgEN.id_XzCollege && jsString_js_1.tzDataType.isString(pobjXzClgEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjXzClgEN.id_XzCollege)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeID) == false && undefined !== pobjXzClgEN.collegeID && jsString_js_1.tzDataType.isString(pobjXzClgEN.collegeID) === false) {
            throw new Error("(errid:Watl000063)字段[学院ID(collegeID)]的值:[$(pobjXzClgEN.collegeID)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeName) == false && undefined !== pobjXzClgEN.collegeName && jsString_js_1.tzDataType.isString(pobjXzClgEN.collegeName) === false) {
            throw new Error("(errid:Watl000063)字段[学院名称(collegeName)]的值:[$(pobjXzClgEN.collegeName)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeIdInGP) == false && undefined !== pobjXzClgEN.collegeIdInGP && jsString_js_1.tzDataType.isString(pobjXzClgEN.collegeIdInGP) === false) {
            throw new Error("(errid:Watl000063)字段[CollegeIdInGP(collegeIdInGP)]的值:[$(pobjXzClgEN.collegeIdInGP)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.clgEnglishName) == false && undefined !== pobjXzClgEN.clgEnglishName && jsString_js_1.tzDataType.isString(pobjXzClgEN.clgEnglishName) === false) {
            throw new Error("(errid:Watl000063)字段[ClgEnglishName(clgEnglishName)]的值:[$(pobjXzClgEN.clgEnglishName)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.collegeNameA) == false && undefined !== pobjXzClgEN.collegeNameA && jsString_js_1.tzDataType.isString(pobjXzClgEN.collegeNameA) === false) {
            throw new Error("(errid:Watl000063)字段[学院名称简写(collegeNameA)]的值:[$(pobjXzClgEN.collegeNameA)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.phoneNumber) == false && undefined !== pobjXzClgEN.phoneNumber && jsString_js_1.tzDataType.isString(pobjXzClgEN.phoneNumber) === false) {
            throw new Error("(errid:Watl000063)字段[PhoneNumber(phoneNumber)]的值:[$(pobjXzClgEN.phoneNumber)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.webSite) == false && undefined !== pobjXzClgEN.webSite && jsString_js_1.tzDataType.isString(pobjXzClgEN.webSite) === false) {
            throw new Error("(errid:Watl000063)字段[个人主页(webSite)]的值:[$(pobjXzClgEN.webSite)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.id_School) == false && undefined !== pobjXzClgEN.id_School && jsString_js_1.tzDataType.isString(pobjXzClgEN.id_School) === false) {
            throw new Error("(errid:Watl000063)字段[学校流水号(id_School)]的值:[$(pobjXzClgEN.id_School)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.id_Uni) == false && undefined !== pobjXzClgEN.id_Uni && jsString_js_1.tzDataType.isString(pobjXzClgEN.id_Uni) === false) {
            throw new Error("(errid:Watl000063)字段[id_Uni(id_Uni)]的值:[$(pobjXzClgEN.id_Uni)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckProperty4Update)");
        }
        if (null != pobjXzClgEN.isVisible4Tea && undefined !== pobjXzClgEN.isVisible4Tea && jsString_js_1.tzDataType.isBoolean(pobjXzClgEN.isVisible4Tea) === false) {
            throw new Error("(errid:Watl000063)字段[IsVisible4Tea(isVisible4Tea)]的值:[$(pobjXzClgEN.isVisible4Tea)], 非法，应该为布尔型(In 学院(XzClg))!(clsXzClgBL:CheckProperty4Update)");
        }
        if (null != pobjXzClgEN.isVisible && undefined !== pobjXzClgEN.isVisible && jsString_js_1.tzDataType.isBoolean(pobjXzClgEN.isVisible) === false) {
            throw new Error("(errid:Watl000063)字段[是否显示(isVisible)]的值:[$(pobjXzClgEN.isVisible)], 非法，应该为布尔型(In 学院(XzClg))!(clsXzClgBL:CheckProperty4Update)");
        }
        if (null != pobjXzClgEN.orderNum && undefined !== pobjXzClgEN.orderNum && jsString_js_1.tzDataType.isNumber(pobjXzClgEN.orderNum) === false) {
            throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjXzClgEN.orderNum)], 非法，应该为数值型(In 学院(XzClg))!(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.modifyDate) == false && undefined !== pobjXzClgEN.modifyDate && jsString_js_1.tzDataType.isString(pobjXzClgEN.modifyDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjXzClgEN.modifyDate)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.modifyUserID) == false && undefined !== pobjXzClgEN.modifyUserID && jsString_js_1.tzDataType.isString(pobjXzClgEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjXzClgEN.modifyUserID)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.memo) == false && undefined !== pobjXzClgEN.memo && jsString_js_1.tzDataType.isString(pobjXzClgEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjXzClgEN.memo)], 非法，应该为字符型(In 学院(XzClg))!(clsXzClgBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzClgEN.id_XzCollege) === true
            || pobjXzClgEN.id_XzCollege.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[学院流水号]不能为空(In 学院)!(clsXzClgBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjXzClgEN.SetIsCheckProperty(true);
    }
    exports.XzClg_CheckProperty4Update = XzClg_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzClg_GetJSONStrByObj(pobjXzClgEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjXzClgEN.sf_UpdFldSetStr = pobjXzClgEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjXzClgEN);
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
    exports.XzClg_GetJSONStrByObj = XzClg_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function XzClg_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrXzClgObjLst = new Array();
        if (strJSON === "") {
            return arrXzClgObjLst;
        }
        try {
            arrXzClgObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrXzClgObjLst;
        }
        return arrXzClgObjLst;
    }
    exports.XzClg_GetObjLstByJSONStr = XzClg_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrXzClgObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function XzClg_GetObjLstByJSONObjLst(arrXzClgObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrXzClgObjLst = new Array();
        for (const objInFor of arrXzClgObjLstS) {
            const obj1 = XzClg_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrXzClgObjLst.push(obj1);
        }
        return arrXzClgObjLst;
    }
    exports.XzClg_GetObjLstByJSONObjLst = XzClg_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzClg_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjXzClgEN = new clsXzClgEN_js_1.clsXzClgEN();
        if (strJSON === "") {
            return pobjXzClgEN;
        }
        try {
            pobjXzClgEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjXzClgEN;
        }
        return pobjXzClgEN;
    }
    exports.XzClg_GetObjByJSONStr = XzClg_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function XzClg_GetCombineCondition(objXzClg_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objXzClg_Cond.dicFldComparisonOp, clsXzClgEN_js_1.clsXzClgEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objXzClg_Cond.dicFldComparisonOp[clsXzClgEN_js_1.clsXzClgEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzClgEN_js_1.clsXzClgEN.con_id_XzCollege, objXzClg_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objXzClg_Cond.dicFldComparisonOp, clsXzClgEN_js_1.clsXzClgEN.con_CollegeID) == true) {
            const strComparisonOp_CollegeID = objXzClg_Cond.dicFldComparisonOp[clsXzClgEN_js_1.clsXzClgEN.con_CollegeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzClgEN_js_1.clsXzClgEN.con_CollegeID, objXzClg_Cond.collegeID, strComparisonOp_CollegeID);
        }
        if (Object.prototype.hasOwnProperty.call(objXzClg_Cond.dicFldComparisonOp, clsXzClgEN_js_1.clsXzClgEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objXzClg_Cond.dicFldComparisonOp[clsXzClgEN_js_1.clsXzClgEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzClgEN_js_1.clsXzClgEN.con_CollegeName, objXzClg_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objXzClg_Cond.dicFldComparisonOp, clsXzClgEN_js_1.clsXzClgEN.con_CollegeIdInGP) == true) {
            const strComparisonOp_CollegeIdInGP = objXzClg_Cond.dicFldComparisonOp[clsXzClgEN_js_1.clsXzClgEN.con_CollegeIdInGP];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzClgEN_js_1.clsXzClgEN.con_CollegeIdInGP, objXzClg_Cond.collegeIdInGP, strComparisonOp_CollegeIdInGP);
        }
        if (Object.prototype.hasOwnProperty.call(objXzClg_Cond.dicFldComparisonOp, clsXzClgEN_js_1.clsXzClgEN.con_ClgEnglishName) == true) {
            const strComparisonOp_ClgEnglishName = objXzClg_Cond.dicFldComparisonOp[clsXzClgEN_js_1.clsXzClgEN.con_ClgEnglishName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzClgEN_js_1.clsXzClgEN.con_ClgEnglishName, objXzClg_Cond.clgEnglishName, strComparisonOp_ClgEnglishName);
        }
        if (Object.prototype.hasOwnProperty.call(objXzClg_Cond.dicFldComparisonOp, clsXzClgEN_js_1.clsXzClgEN.con_CollegeNameA) == true) {
            const strComparisonOp_CollegeNameA = objXzClg_Cond.dicFldComparisonOp[clsXzClgEN_js_1.clsXzClgEN.con_CollegeNameA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzClgEN_js_1.clsXzClgEN.con_CollegeNameA, objXzClg_Cond.collegeNameA, strComparisonOp_CollegeNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objXzClg_Cond.dicFldComparisonOp, clsXzClgEN_js_1.clsXzClgEN.con_PhoneNumber) == true) {
            const strComparisonOp_PhoneNumber = objXzClg_Cond.dicFldComparisonOp[clsXzClgEN_js_1.clsXzClgEN.con_PhoneNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzClgEN_js_1.clsXzClgEN.con_PhoneNumber, objXzClg_Cond.phoneNumber, strComparisonOp_PhoneNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objXzClg_Cond.dicFldComparisonOp, clsXzClgEN_js_1.clsXzClgEN.con_WebSite) == true) {
            const strComparisonOp_WebSite = objXzClg_Cond.dicFldComparisonOp[clsXzClgEN_js_1.clsXzClgEN.con_WebSite];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzClgEN_js_1.clsXzClgEN.con_WebSite, objXzClg_Cond.webSite, strComparisonOp_WebSite);
        }
        if (Object.prototype.hasOwnProperty.call(objXzClg_Cond.dicFldComparisonOp, clsXzClgEN_js_1.clsXzClgEN.con_id_School) == true) {
            const strComparisonOp_id_School = objXzClg_Cond.dicFldComparisonOp[clsXzClgEN_js_1.clsXzClgEN.con_id_School];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzClgEN_js_1.clsXzClgEN.con_id_School, objXzClg_Cond.id_School, strComparisonOp_id_School);
        }
        if (Object.prototype.hasOwnProperty.call(objXzClg_Cond.dicFldComparisonOp, clsXzClgEN_js_1.clsXzClgEN.con_id_Uni) == true) {
            const strComparisonOp_id_Uni = objXzClg_Cond.dicFldComparisonOp[clsXzClgEN_js_1.clsXzClgEN.con_id_Uni];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzClgEN_js_1.clsXzClgEN.con_id_Uni, objXzClg_Cond.id_Uni, strComparisonOp_id_Uni);
        }
        if (Object.prototype.hasOwnProperty.call(objXzClg_Cond.dicFldComparisonOp, clsXzClgEN_js_1.clsXzClgEN.con_IsVisible4Tea) == true) {
            if (objXzClg_Cond.isVisible4Tea == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsXzClgEN_js_1.clsXzClgEN.con_IsVisible4Tea);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsXzClgEN_js_1.clsXzClgEN.con_IsVisible4Tea);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objXzClg_Cond.dicFldComparisonOp, clsXzClgEN_js_1.clsXzClgEN.con_IsVisible) == true) {
            if (objXzClg_Cond.isVisible == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsXzClgEN_js_1.clsXzClgEN.con_IsVisible);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsXzClgEN_js_1.clsXzClgEN.con_IsVisible);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objXzClg_Cond.dicFldComparisonOp, clsXzClgEN_js_1.clsXzClgEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objXzClg_Cond.dicFldComparisonOp[clsXzClgEN_js_1.clsXzClgEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsXzClgEN_js_1.clsXzClgEN.con_OrderNum, objXzClg_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objXzClg_Cond.dicFldComparisonOp, clsXzClgEN_js_1.clsXzClgEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objXzClg_Cond.dicFldComparisonOp[clsXzClgEN_js_1.clsXzClgEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzClgEN_js_1.clsXzClgEN.con_ModifyDate, objXzClg_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objXzClg_Cond.dicFldComparisonOp, clsXzClgEN_js_1.clsXzClgEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objXzClg_Cond.dicFldComparisonOp[clsXzClgEN_js_1.clsXzClgEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzClgEN_js_1.clsXzClgEN.con_ModifyUserID, objXzClg_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objXzClg_Cond.dicFldComparisonOp, clsXzClgEN_js_1.clsXzClgEN.con_Memo) == true) {
            const strComparisonOp_Memo = objXzClg_Cond.dicFldComparisonOp[clsXzClgEN_js_1.clsXzClgEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzClgEN_js_1.clsXzClgEN.con_Memo, objXzClg_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.XzClg_GetCombineCondition = XzClg_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objXzClgENS:源对象
     * @param objXzClgENT:目标对象
    */
    function XzClg_CopyObjTo(objXzClgENS, objXzClgENT) {
        objXzClgENT.id_XzCollege = objXzClgENS.id_XzCollege; //学院流水号
        objXzClgENT.collegeID = objXzClgENS.collegeID; //学院ID
        objXzClgENT.collegeName = objXzClgENS.collegeName; //学院名称
        objXzClgENT.collegeIdInGP = objXzClgENS.collegeIdInGP; //CollegeIdInGP
        objXzClgENT.clgEnglishName = objXzClgENS.clgEnglishName; //ClgEnglishName
        objXzClgENT.collegeNameA = objXzClgENS.collegeNameA; //学院名称简写
        objXzClgENT.phoneNumber = objXzClgENS.phoneNumber; //PhoneNumber
        objXzClgENT.webSite = objXzClgENS.webSite; //个人主页
        objXzClgENT.id_School = objXzClgENS.id_School; //学校流水号
        objXzClgENT.id_Uni = objXzClgENS.id_Uni; //id_Uni
        objXzClgENT.isVisible4Tea = objXzClgENS.isVisible4Tea; //IsVisible4Tea
        objXzClgENT.isVisible = objXzClgENS.isVisible; //是否显示
        objXzClgENT.orderNum = objXzClgENS.orderNum; //序号
        objXzClgENT.modifyDate = objXzClgENS.modifyDate; //修改日期
        objXzClgENT.modifyUserID = objXzClgENS.modifyUserID; //修改人
        objXzClgENT.memo = objXzClgENS.memo; //备注
        objXzClgENT.sf_UpdFldSetStr = objXzClgENS.updFldString; //sf_UpdFldSetStr
    }
    exports.XzClg_CopyObjTo = XzClg_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objXzClgENS:源对象
     * @param objXzClgENT:目标对象
    */
    function XzClg_GetObjFromJsonObj(objXzClgENS) {
        const objXzClgENT = new clsXzClgEN_js_1.clsXzClgEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzClgENT, objXzClgENS);
        return objXzClgENT;
    }
    exports.XzClg_GetObjFromJsonObj = XzClg_GetObjFromJsonObj;
});
