/**
* 类名:clsvke_SubWApi
* 表名:vke_Sub(01120659)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:47:07
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvke_SubEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vke_Sub_GetObjFromJsonObj = exports.vke_Sub_CopyObjTo = exports.vke_Sub_GetCombineCondition = exports.vke_Sub_GetObjByJSONStr = exports.vke_Sub_GetObjLstByJSONObjLst = exports.vke_Sub_GetObjLstByJSONStr = exports.vke_Sub_GetJSONStrByObj = exports.vke_Sub__Cache = exports.vke_Sub_ReFreshThisCache = exports.vke_Sub_GetWebApiUrl = exports.vke_Sub_GetRecCountByCond_Cache = exports.vke_Sub_GetRecCountByCondAsync = exports.vke_Sub_IsExistAsync = exports.vke_Sub_IsExist_Cache = exports.vke_Sub_IsExist = exports.vke_Sub_IsExistRecordAsync = exports.vke_Sub_IsExistRecord_Cache = exports.vke_Sub_GetObjLstByPagerAsync = exports.vke_Sub_GetObjLstByPager_Cache = exports.vke_Sub_GetObjLstByRange = exports.vke_Sub_GetObjLstByRangeAsync = exports.vke_Sub_GetTopObjLstAsync = exports.vke_Sub_GetObjLstByke_SubIdLst_Cache = exports.vke_Sub_GetObjLstByke_SubIdLstAsync = exports.vke_Sub_GetSubObjLst_Cache = exports.vke_Sub_GetObjLst_PureCache = exports.vke_Sub_GetObjLst_Cache = exports.vke_Sub_GetObjLst_sessionStorage_PureCache = exports.vke_Sub_GetObjLst_sessionStorage = exports.vke_Sub_GetObjLstAsync = exports.vke_Sub_GetObjLst_localStorage_PureCache = exports.vke_Sub_GetObjLst_localStorage = exports.vke_Sub_GetObjLst_ClientCache = exports.vke_Sub_GetFirstObjAsync = exports.vke_Sub_GetFirstID = exports.vke_Sub_GetFirstIDAsync = exports.vke_Sub_funcKey = exports.vke_Sub_FilterFunByKey = exports.vke_Sub_SortFunByKey = exports.vke_Sub_SortFun_Defa_2Fld = exports.vke_Sub_SortFun_Defa = exports.vke_Sub_func = exports.vke_Sub_GetNameByke_SubId_Cache = exports.vke_Sub_GetObjByke_SubId_localStorage = exports.vke_Sub_GetObjByke_SubId_Cache = exports.vke_Sub_GetObjByke_SubIdAsync = exports.vke_Sub_ConstructorName = exports.vke_Sub_Controller = void 0;
    /**
     * 知识经济子类视图(vke_Sub)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvke_SubEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvke_SubEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vke_Sub_Controller = "vke_SubApi";
    exports.vke_Sub_ConstructorName = "vke_Sub";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strke_SubId:关键字
    * @returns 对象
    **/
    async function vke_Sub_GetObjByke_SubIdAsync(strke_SubId) {
        const strThisFuncName = "GetObjByke_SubIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strke_SubId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strke_SubId]不能为空！(In clsvke_SubWApi.GetObjByke_SubIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strke_SubId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strke_SubId]的长度:[{0}]不正确！(clsvke_SubWApi.GetObjByke_SubIdAsync)", strke_SubId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByke_SubId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vke_Sub_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strke_SubId": strke_SubId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvke_Sub = vke_Sub_GetObjFromJsonObj(returnObj);
                return objvke_Sub;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vke_Sub_GetObjByke_SubIdAsync = vke_Sub_GetObjByke_SubIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strke_SubId:所给的关键字
     * @returns 对象
    */
    async function vke_Sub_GetObjByke_SubId_Cache(strke_SubId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByke_SubId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strke_SubId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strke_SubId]不能为空！(In clsvke_SubWApi.GetObjByke_SubId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strke_SubId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strke_SubId]的长度:[{0}]不正确！(clsvke_SubWApi.GetObjByke_SubId_Cache)", strke_SubId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_Cache();
        try {
            const arrvke_Sub_Sel = arrvke_SubObjLst_Cache.filter(x => x.ke_SubId == strke_SubId);
            let objvke_Sub;
            if (arrvke_Sub_Sel.length > 0) {
                objvke_Sub = arrvke_Sub_Sel[0];
                return objvke_Sub;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvke_Sub_Const = await vke_Sub_GetObjByke_SubIdAsync(strke_SubId);
                    if (objvke_Sub_Const != null) {
                        vke_Sub_ReFreshThisCache();
                        return objvke_Sub_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strke_SubId, exports.vke_Sub_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vke_Sub_GetObjByke_SubId_Cache = vke_Sub_GetObjByke_SubId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strke_SubId:所给的关键字
     * @returns 对象
    */
    async function vke_Sub_GetObjByke_SubId_localStorage(strke_SubId) {
        const strThisFuncName = "GetObjByke_SubId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strke_SubId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strke_SubId]不能为空！(In clsvke_SubWApi.GetObjByke_SubId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strke_SubId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strke_SubId]的长度:[{0}]不正确！(clsvke_SubWApi.GetObjByke_SubId_localStorage)", strke_SubId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvke_SubEN_js_1.clsvke_SubEN._CurrTabName, strke_SubId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvke_Sub_Cache = JSON.parse(strTempObj);
            return objvke_Sub_Cache;
        }
        try {
            const objvke_Sub = await vke_Sub_GetObjByke_SubIdAsync(strke_SubId);
            if (objvke_Sub != null) {
                localStorage.setItem(strKey, JSON.stringify(objvke_Sub));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvke_Sub;
            }
            return objvke_Sub;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strke_SubId, exports.vke_Sub_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vke_Sub_GetObjByke_SubId_localStorage = vke_Sub_GetObjByke_SubId_localStorage;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strke_SubId:所给的关键字
     * @returns 对象
    */
    async function vke_Sub_GetNameByke_SubId_Cache(strke_SubId) {
        const strThisFuncName = "GetNameByke_SubId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strke_SubId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strke_SubId]不能为空！(In clsvke_SubWApi.GetNameByke_SubId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strke_SubId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strke_SubId]的长度:[{0}]不正确！(clsvke_SubWApi.GetNameByke_SubId_Cache)", strke_SubId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_Cache();
        if (arrvke_SubObjLst_Cache == null)
            return "";
        try {
            const arrvke_Sub_Sel = arrvke_SubObjLst_Cache.filter(x => x.ke_SubId == strke_SubId);
            let objvke_Sub;
            if (arrvke_Sub_Sel.length > 0) {
                objvke_Sub = arrvke_Sub_Sel[0];
                return objvke_Sub.ke_SuperName_cn;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strke_SubId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.vke_Sub_GetNameByke_SubId_Cache = vke_Sub_GetNameByke_SubId_Cache;
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
    async function vke_Sub_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvke_SubEN_js_1.clsvke_SubEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvke_SubEN_js_1.clsvke_SubEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strke_SubId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvke_Sub = await vke_Sub_GetObjByke_SubId_Cache(strke_SubId);
        if (objvke_Sub == null)
            return "";
        if (objvke_Sub.GetFldValue(strOutFldName) == null)
            return "";
        return objvke_Sub.GetFldValue(strOutFldName).toString();
    }
    exports.vke_Sub_func = vke_Sub_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vke_Sub_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.ke_SubId.localeCompare(b.ke_SubId);
    }
    exports.vke_Sub_SortFun_Defa = vke_Sub_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vke_Sub_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.ke_SuperId == b.ke_SuperId)
            return a.ke_SuperName_cn.localeCompare(b.ke_SuperName_cn);
        else
            return a.ke_SuperId.localeCompare(b.ke_SuperId);
    }
    exports.vke_Sub_SortFun_Defa_2Fld = vke_Sub_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vke_Sub_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubId:
                    return (a, b) => {
                        return a.ke_SubId.localeCompare(b.ke_SubId);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperId:
                    return (a, b) => {
                        return a.ke_SuperId.localeCompare(b.ke_SuperId);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperName_cn:
                    return (a, b) => {
                        if (a.ke_SuperName_cn == null)
                            return -1;
                        if (b.ke_SuperName_cn == null)
                            return 1;
                        return a.ke_SuperName_cn.localeCompare(b.ke_SuperName_cn);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperName_en:
                    return (a, b) => {
                        if (a.ke_SuperName_en == null)
                            return -1;
                        if (b.ke_SuperName_en == null)
                            return 1;
                        return a.ke_SuperName_en.localeCompare(b.ke_SuperName_en);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubName_cn:
                    return (a, b) => {
                        return a.ke_SubName_cn.localeCompare(b.ke_SubName_cn);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubName_en:
                    return (a, b) => {
                        if (a.ke_SubName_en == null)
                            return -1;
                        if (b.ke_SubName_en == null)
                            return 1;
                        return a.ke_SubName_en.localeCompare(b.ke_SubName_en);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperDescribe_cn:
                    return (a, b) => {
                        if (a.ke_SuperDescribe_cn == null)
                            return -1;
                        if (b.ke_SuperDescribe_cn == null)
                            return 1;
                        return a.ke_SuperDescribe_cn.localeCompare(b.ke_SuperDescribe_cn);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubDescribe_cn:
                    return (a, b) => {
                        if (a.ke_SubDescribe_cn == null)
                            return -1;
                        if (b.ke_SubDescribe_cn == null)
                            return 1;
                        return a.ke_SubDescribe_cn.localeCompare(b.ke_SubDescribe_cn);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperDescribe_en:
                    return (a, b) => {
                        if (a.ke_SuperDescribe_en == null)
                            return -1;
                        if (b.ke_SuperDescribe_en == null)
                            return 1;
                        return a.ke_SuperDescribe_en.localeCompare(b.ke_SuperDescribe_en);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubDescribe_en:
                    return (a, b) => {
                        if (a.ke_SubDescribe_en == null)
                            return -1;
                        if (b.ke_SubDescribe_en == null)
                            return 1;
                        return a.ke_SubDescribe_en.localeCompare(b.ke_SubDescribe_en);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_Link:
                    return (a, b) => {
                        if (a.link == null)
                            return -1;
                        if (b.link == null)
                            return 1;
                        return a.link.localeCompare(b.link);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vke_Sub]中不存在！(in ${exports.vke_Sub_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubId:
                    return (a, b) => {
                        return b.ke_SubId.localeCompare(a.ke_SubId);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperId:
                    return (a, b) => {
                        return b.ke_SuperId.localeCompare(a.ke_SuperId);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperName_cn:
                    return (a, b) => {
                        if (b.ke_SuperName_cn == null)
                            return -1;
                        if (a.ke_SuperName_cn == null)
                            return 1;
                        return b.ke_SuperName_cn.localeCompare(a.ke_SuperName_cn);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperName_en:
                    return (a, b) => {
                        if (b.ke_SuperName_en == null)
                            return -1;
                        if (a.ke_SuperName_en == null)
                            return 1;
                        return b.ke_SuperName_en.localeCompare(a.ke_SuperName_en);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubName_cn:
                    return (a, b) => {
                        return b.ke_SubName_cn.localeCompare(a.ke_SubName_cn);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubName_en:
                    return (a, b) => {
                        if (b.ke_SubName_en == null)
                            return -1;
                        if (a.ke_SubName_en == null)
                            return 1;
                        return b.ke_SubName_en.localeCompare(a.ke_SubName_en);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperDescribe_cn:
                    return (a, b) => {
                        if (b.ke_SuperDescribe_cn == null)
                            return -1;
                        if (a.ke_SuperDescribe_cn == null)
                            return 1;
                        return b.ke_SuperDescribe_cn.localeCompare(a.ke_SuperDescribe_cn);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubDescribe_cn:
                    return (a, b) => {
                        if (b.ke_SubDescribe_cn == null)
                            return -1;
                        if (a.ke_SubDescribe_cn == null)
                            return 1;
                        return b.ke_SubDescribe_cn.localeCompare(a.ke_SubDescribe_cn);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperDescribe_en:
                    return (a, b) => {
                        if (b.ke_SuperDescribe_en == null)
                            return -1;
                        if (a.ke_SuperDescribe_en == null)
                            return 1;
                        return b.ke_SuperDescribe_en.localeCompare(a.ke_SuperDescribe_en);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubDescribe_en:
                    return (a, b) => {
                        if (b.ke_SubDescribe_en == null)
                            return -1;
                        if (a.ke_SubDescribe_en == null)
                            return 1;
                        return b.ke_SubDescribe_en.localeCompare(a.ke_SubDescribe_en);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvke_SubEN_js_1.clsvke_SubEN.con_Link:
                    return (a, b) => {
                        if (b.link == null)
                            return -1;
                        if (a.link == null)
                            return 1;
                        return b.link.localeCompare(a.link);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vke_Sub]中不存在！(in ${exports.vke_Sub_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vke_Sub_SortFunByKey = vke_Sub_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vke_Sub_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubId:
                return (obj) => {
                    return obj.ke_SubId === value;
                };
            case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperId:
                return (obj) => {
                    return obj.ke_SuperId === value;
                };
            case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperName_cn:
                return (obj) => {
                    return obj.ke_SuperName_cn === value;
                };
            case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperName_en:
                return (obj) => {
                    return obj.ke_SuperName_en === value;
                };
            case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubName_cn:
                return (obj) => {
                    return obj.ke_SubName_cn === value;
                };
            case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubName_en:
                return (obj) => {
                    return obj.ke_SubName_en === value;
                };
            case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperDescribe_cn:
                return (obj) => {
                    return obj.ke_SuperDescribe_cn === value;
                };
            case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubDescribe_cn:
                return (obj) => {
                    return obj.ke_SubDescribe_cn === value;
                };
            case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperDescribe_en:
                return (obj) => {
                    return obj.ke_SuperDescribe_en === value;
                };
            case clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubDescribe_en:
                return (obj) => {
                    return obj.ke_SubDescribe_en === value;
                };
            case clsvke_SubEN_js_1.clsvke_SubEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvke_SubEN_js_1.clsvke_SubEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvke_SubEN_js_1.clsvke_SubEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvke_SubEN_js_1.clsvke_SubEN.con_Link:
                return (obj) => {
                    return obj.link === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vke_Sub]中不存在！(in ${exports.vke_Sub_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vke_Sub_FilterFunByKey = vke_Sub_FilterFunByKey;
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
    async function vke_Sub_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvke_Sub = await vke_Sub_GetObjLst_Cache();
        if (arrvke_Sub == null)
            return [];
        let arrvke_Sub_Sel = arrvke_Sub;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvke_Sub_Sel.length == 0)
            return [];
        return arrvke_Sub_Sel.map(x => x.ke_SubId);
    }
    exports.vke_Sub_funcKey = vke_Sub_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vke_Sub_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vke_Sub_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vke_Sub_GetFirstIDAsync = vke_Sub_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vke_Sub_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vke_Sub_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vke_Sub_GetFirstID = vke_Sub_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vke_Sub_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vke_Sub_Controller, strAction);
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
                const objvke_Sub = vke_Sub_GetObjFromJsonObj(returnObj);
                return objvke_Sub;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vke_Sub_GetFirstObjAsync = vke_Sub_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vke_Sub_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvke_SubEN_js_1.clsvke_SubEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvke_SubEN_js_1.clsvke_SubEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvke_SubEN_js_1.clsvke_SubEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvke_SubExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvke_SubObjLst_T = vke_Sub_GetObjLstByJSONObjLst(arrvke_SubExObjLst_Cache);
            return arrvke_SubObjLst_T;
        }
        try {
            const arrvke_SubExObjLst = await vke_Sub_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvke_SubExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvke_SubExObjLst.length);
            console.log(strInfo);
            return arrvke_SubExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vke_Sub_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vke_Sub_GetObjLst_ClientCache = vke_Sub_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vke_Sub_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvke_SubEN_js_1.clsvke_SubEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvke_SubEN_js_1.clsvke_SubEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvke_SubEN_js_1.clsvke_SubEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvke_SubExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvke_SubObjLst_T = vke_Sub_GetObjLstByJSONObjLst(arrvke_SubExObjLst_Cache);
            return arrvke_SubObjLst_T;
        }
        try {
            const arrvke_SubExObjLst = await vke_Sub_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvke_SubExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvke_SubExObjLst.length);
            console.log(strInfo);
            return arrvke_SubExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vke_Sub_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vke_Sub_GetObjLst_localStorage = vke_Sub_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vke_Sub_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvke_SubEN_js_1.clsvke_SubEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvke_SubObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvke_SubObjLst_Cache;
        }
        else
            return null;
    }
    exports.vke_Sub_GetObjLst_localStorage_PureCache = vke_Sub_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vke_Sub_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vke_Sub_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vke_Sub_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vke_Sub_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vke_Sub_GetObjLstAsync = vke_Sub_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vke_Sub_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvke_SubEN_js_1.clsvke_SubEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvke_SubEN_js_1.clsvke_SubEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvke_SubEN_js_1.clsvke_SubEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvke_SubExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvke_SubObjLst_T = vke_Sub_GetObjLstByJSONObjLst(arrvke_SubExObjLst_Cache);
            return arrvke_SubObjLst_T;
        }
        try {
            const arrvke_SubExObjLst = await vke_Sub_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvke_SubExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvke_SubExObjLst.length);
            console.log(strInfo);
            return arrvke_SubExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vke_Sub_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vke_Sub_GetObjLst_sessionStorage = vke_Sub_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vke_Sub_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvke_SubEN_js_1.clsvke_SubEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvke_SubObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvke_SubObjLst_Cache;
        }
        else
            return null;
    }
    exports.vke_Sub_GetObjLst_sessionStorage_PureCache = vke_Sub_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vke_Sub_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvke_SubObjLst_Cache;
        switch (clsvke_SubEN_js_1.clsvke_SubEN.CacheModeId) {
            case "04": //sessionStorage
                arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_ClientCache();
                break;
            default:
                arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_ClientCache();
                break;
        }
        const arrvke_SubObjLst = vke_Sub_GetObjLstByJSONObjLst(arrvke_SubObjLst_Cache);
        return arrvke_SubObjLst_Cache;
    }
    exports.vke_Sub_GetObjLst_Cache = vke_Sub_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vke_Sub_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvke_SubObjLst_Cache;
        switch (clsvke_SubEN_js_1.clsvke_SubEN.CacheModeId) {
            case "04": //sessionStorage
                arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvke_SubObjLst_Cache = null;
                break;
            default:
                arrvke_SubObjLst_Cache = null;
                break;
        }
        return arrvke_SubObjLst_Cache;
    }
    exports.vke_Sub_GetObjLst_PureCache = vke_Sub_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrke_SubId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vke_Sub_GetSubObjLst_Cache(objvke_Sub_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_Cache();
        let arrvke_Sub_Sel = arrvke_SubObjLst_Cache;
        if (objvke_Sub_Cond.sf_FldComparisonOp == null || objvke_Sub_Cond.sf_FldComparisonOp == "")
            return arrvke_Sub_Sel;
        const dicFldComparisonOp = JSON.parse(objvke_Sub_Cond.sf_FldComparisonOp);
        //console.log("clsvke_SubWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvke_Sub_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvke_Sub_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvke_Sub_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvke_Sub_Cond), exports.vke_Sub_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vke_Sub_GetSubObjLst_Cache = vke_Sub_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrke_SubId:关键字列表
    * @returns 对象列表
    **/
    async function vke_Sub_GetObjLstByke_SubIdLstAsync(arrke_SubId) {
        const strThisFuncName = "GetObjLstByke_SubIdLstAsync";
        const strAction = "GetObjLstByke_SubIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vke_Sub_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrke_SubId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vke_Sub_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vke_Sub_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vke_Sub_GetObjLstByke_SubIdLstAsync = vke_Sub_GetObjLstByke_SubIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrke_SubIdLst:关键字列表
     * @returns 对象列表
    */
    async function vke_Sub_GetObjLstByke_SubIdLst_Cache(arrke_SubIdLst) {
        const strThisFuncName = "GetObjLstByke_SubIdLst_Cache";
        try {
            const arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_Cache();
            const arrvke_Sub_Sel = arrvke_SubObjLst_Cache.filter(x => arrke_SubIdLst.indexOf(x.ke_SubId) > -1);
            return arrvke_Sub_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrke_SubIdLst.join(","), exports.vke_Sub_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vke_Sub_GetObjLstByke_SubIdLst_Cache = vke_Sub_GetObjLstByke_SubIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vke_Sub_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vke_Sub_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vke_Sub_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vke_Sub_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vke_Sub_GetTopObjLstAsync = vke_Sub_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vke_Sub_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vke_Sub_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vke_Sub_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vke_Sub_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vke_Sub_GetObjLstByRangeAsync = vke_Sub_GetObjLstByRangeAsync;
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
    async function vke_Sub_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vke_Sub_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vke_Sub_GetObjLstByRange = vke_Sub_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vke_Sub_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_Cache();
        if (arrvke_SubObjLst_Cache.length == 0)
            return arrvke_SubObjLst_Cache;
        let arrvke_Sub_Sel = arrvke_SubObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvke_Sub_Cond = new clsvke_SubEN_js_1.clsvke_SubEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvke_Sub_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvke_SubWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvke_Sub_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvke_Sub_Sel.length == 0)
                return arrvke_Sub_Sel;
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
                arrvke_Sub_Sel = arrvke_Sub_Sel.sort(vke_Sub_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvke_Sub_Sel = arrvke_Sub_Sel.sort(objPagerPara.sortFun);
            }
            arrvke_Sub_Sel = arrvke_Sub_Sel.slice(intStart, intEnd);
            return arrvke_Sub_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vke_Sub_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vke_Sub_GetObjLstByPager_Cache = vke_Sub_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vke_Sub_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vke_Sub_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vke_Sub_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vke_Sub_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vke_Sub_GetObjLstByPagerAsync = vke_Sub_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrke_SubId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vke_Sub_IsExistRecord_Cache(objvke_Sub_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_Cache();
        if (arrvke_SubObjLst_Cache == null)
            return false;
        let arrvke_Sub_Sel = arrvke_SubObjLst_Cache;
        if (objvke_Sub_Cond.sf_FldComparisonOp == null || objvke_Sub_Cond.sf_FldComparisonOp == "")
            return arrvke_Sub_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvke_Sub_Cond.sf_FldComparisonOp);
        //console.log("clsvke_SubWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvke_Sub_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvke_Sub_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvke_Sub_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvke_Sub_Cond), exports.vke_Sub_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vke_Sub_IsExistRecord_Cache = vke_Sub_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vke_Sub_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vke_Sub_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vke_Sub_IsExistRecordAsync = vke_Sub_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strke_SubId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vke_Sub_IsExist(strke_SubId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vke_Sub_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ke_SubId": strke_SubId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vke_Sub_IsExist = vke_Sub_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strke_SubId:所给的关键字
     * @returns 对象
    */
    async function vke_Sub_IsExist_Cache(strke_SubId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_Cache();
        if (arrvke_SubObjLst_Cache == null)
            return false;
        try {
            const arrvke_Sub_Sel = arrvke_SubObjLst_Cache.filter(x => x.ke_SubId == strke_SubId);
            if (arrvke_Sub_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strke_SubId, exports.vke_Sub_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vke_Sub_IsExist_Cache = vke_Sub_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strke_SubId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vke_Sub_IsExistAsync(strke_SubId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vke_Sub_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strke_SubId": strke_SubId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vke_Sub_IsExistAsync = vke_Sub_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vke_Sub_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vke_Sub_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vke_Sub_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vke_Sub_GetRecCountByCondAsync = vke_Sub_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvke_Sub_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vke_Sub_GetRecCountByCond_Cache(objvke_Sub_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_Cache();
        if (arrvke_SubObjLst_Cache == null)
            return 0;
        let arrvke_Sub_Sel = arrvke_SubObjLst_Cache;
        if (objvke_Sub_Cond.sf_FldComparisonOp == null || objvke_Sub_Cond.sf_FldComparisonOp == "")
            return arrvke_Sub_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvke_Sub_Cond.sf_FldComparisonOp);
        //console.log("clsvke_SubWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvke_Sub_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvke_Sub_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvke_Sub_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvke_Sub_Cond), exports.vke_Sub_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vke_Sub_GetRecCountByCond_Cache = vke_Sub_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vke_Sub_GetWebApiUrl(strController, strAction) {
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
    exports.vke_Sub_GetWebApiUrl = vke_Sub_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vke_Sub_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvke_SubEN_js_1.clsvke_SubEN._CurrTabName;
            switch (clsvke_SubEN_js_1.clsvke_SubEN.CacheModeId) {
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
    exports.vke_Sub_ReFreshThisCache = vke_Sub_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function vke_Sub__Cache(strDivName, strDdlName) {
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
        const arrObjLst_Sel = await vke_Sub_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv_V)(strDivName, strDdlName, arrObjLst_Sel, clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperId, clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperName_cn, "知识经济子类视图");
    }
    exports.vke_Sub__Cache = vke_Sub__Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vke_Sub_GetJSONStrByObj(pobjvke_SubEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvke_SubEN);
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
    exports.vke_Sub_GetJSONStrByObj = vke_Sub_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vke_Sub_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvke_SubObjLst = new Array();
        if (strJSON === "") {
            return arrvke_SubObjLst;
        }
        try {
            arrvke_SubObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvke_SubObjLst;
        }
        return arrvke_SubObjLst;
    }
    exports.vke_Sub_GetObjLstByJSONStr = vke_Sub_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvke_SubObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vke_Sub_GetObjLstByJSONObjLst(arrvke_SubObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvke_SubObjLst = new Array();
        for (const objInFor of arrvke_SubObjLstS) {
            const obj1 = vke_Sub_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvke_SubObjLst.push(obj1);
        }
        return arrvke_SubObjLst;
    }
    exports.vke_Sub_GetObjLstByJSONObjLst = vke_Sub_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vke_Sub_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvke_SubEN = new clsvke_SubEN_js_1.clsvke_SubEN();
        if (strJSON === "") {
            return pobjvke_SubEN;
        }
        try {
            pobjvke_SubEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvke_SubEN;
        }
        return pobjvke_SubEN;
    }
    exports.vke_Sub_GetObjByJSONStr = vke_Sub_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vke_Sub_GetCombineCondition(objvke_Sub_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubId) == true) {
            const strComparisonOp_ke_SubId = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubId, objvke_Sub_Cond.ke_SubId, strComparisonOp_ke_SubId);
        }
        if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperId) == true) {
            const strComparisonOp_ke_SuperId = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperId, objvke_Sub_Cond.ke_SuperId, strComparisonOp_ke_SuperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperName_cn) == true) {
            const strComparisonOp_ke_SuperName_cn = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperName_cn];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperName_cn, objvke_Sub_Cond.ke_SuperName_cn, strComparisonOp_ke_SuperName_cn);
        }
        if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperName_en) == true) {
            const strComparisonOp_ke_SuperName_en = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperName_en];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperName_en, objvke_Sub_Cond.ke_SuperName_en, strComparisonOp_ke_SuperName_en);
        }
        if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubName_cn) == true) {
            const strComparisonOp_ke_SubName_cn = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubName_cn];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubName_cn, objvke_Sub_Cond.ke_SubName_cn, strComparisonOp_ke_SubName_cn);
        }
        if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubName_en) == true) {
            const strComparisonOp_ke_SubName_en = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubName_en];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubName_en, objvke_Sub_Cond.ke_SubName_en, strComparisonOp_ke_SubName_en);
        }
        if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperDescribe_cn) == true) {
            const strComparisonOp_ke_SuperDescribe_cn = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperDescribe_cn];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperDescribe_cn, objvke_Sub_Cond.ke_SuperDescribe_cn, strComparisonOp_ke_SuperDescribe_cn);
        }
        if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubDescribe_cn) == true) {
            const strComparisonOp_ke_SubDescribe_cn = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubDescribe_cn];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubDescribe_cn, objvke_Sub_Cond.ke_SubDescribe_cn, strComparisonOp_ke_SubDescribe_cn);
        }
        if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperDescribe_en) == true) {
            const strComparisonOp_ke_SuperDescribe_en = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperDescribe_en];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SuperDescribe_en, objvke_Sub_Cond.ke_SuperDescribe_en, strComparisonOp_ke_SuperDescribe_en);
        }
        if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubDescribe_en) == true) {
            const strComparisonOp_ke_SubDescribe_en = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubDescribe_en];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvke_SubEN_js_1.clsvke_SubEN.con_ke_SubDescribe_en, objvke_Sub_Cond.ke_SubDescribe_en, strComparisonOp_ke_SubDescribe_en);
        }
        if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN_js_1.clsvke_SubEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN_js_1.clsvke_SubEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvke_SubEN_js_1.clsvke_SubEN.con_UpdDate, objvke_Sub_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN_js_1.clsvke_SubEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN_js_1.clsvke_SubEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvke_SubEN_js_1.clsvke_SubEN.con_UpdUser, objvke_Sub_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN_js_1.clsvke_SubEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN_js_1.clsvke_SubEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvke_SubEN_js_1.clsvke_SubEN.con_Memo, objvke_Sub_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN_js_1.clsvke_SubEN.con_Link) == true) {
            const strComparisonOp_Link = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN_js_1.clsvke_SubEN.con_Link];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvke_SubEN_js_1.clsvke_SubEN.con_Link, objvke_Sub_Cond.link, strComparisonOp_Link);
        }
        return strWhereCond;
    }
    exports.vke_Sub_GetCombineCondition = vke_Sub_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvke_SubENS:源对象
     * @param objvke_SubENT:目标对象
    */
    function vke_Sub_CopyObjTo(objvke_SubENS, objvke_SubENT) {
        objvke_SubENT.ke_SubId = objvke_SubENS.ke_SubId; //知识子类Id
        objvke_SubENT.ke_SuperId = objvke_SubENS.ke_SuperId; //知识分类Id
        objvke_SubENT.ke_SuperName_cn = objvke_SubENS.ke_SuperName_cn; //知识分类名
        objvke_SubENT.ke_SuperName_en = objvke_SubENS.ke_SuperName_en; //知识分类英文名
        objvke_SubENT.ke_SubName_cn = objvke_SubENS.ke_SubName_cn; //知识子类名
        objvke_SubENT.ke_SubName_en = objvke_SubENS.ke_SubName_en; //知识子类英文名
        objvke_SubENT.ke_SuperDescribe_cn = objvke_SubENS.ke_SuperDescribe_cn; //知识分类描述
        objvke_SubENT.ke_SubDescribe_cn = objvke_SubENS.ke_SubDescribe_cn; //知识子类描述
        objvke_SubENT.ke_SuperDescribe_en = objvke_SubENS.ke_SuperDescribe_en; //知识分类英文描述
        objvke_SubENT.ke_SubDescribe_en = objvke_SubENS.ke_SubDescribe_en; //知识子类英文描述
        objvke_SubENT.updDate = objvke_SubENS.updDate; //修改日期
        objvke_SubENT.updUser = objvke_SubENS.updUser; //修改人
        objvke_SubENT.memo = objvke_SubENS.memo; //备注
        objvke_SubENT.link = objvke_SubENS.link; //相应链接
    }
    exports.vke_Sub_CopyObjTo = vke_Sub_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvke_SubENS:源对象
     * @param objvke_SubENT:目标对象
    */
    function vke_Sub_GetObjFromJsonObj(objvke_SubENS) {
        const objvke_SubENT = new clsvke_SubEN_js_1.clsvke_SubEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvke_SubENT, objvke_SubENS);
        return objvke_SubENT;
    }
    exports.vke_Sub_GetObjFromJsonObj = vke_Sub_GetObjFromJsonObj;
});
