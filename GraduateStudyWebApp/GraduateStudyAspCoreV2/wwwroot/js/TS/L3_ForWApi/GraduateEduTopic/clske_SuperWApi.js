/**
* 类名:clske_SuperWApi
* 表名:ke_Super(01120661)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:49:35
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clske_SuperEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ke_Super_GetObjFromJsonObj = exports.ke_Super_CopyObjTo = exports.ke_Super_GetCombineCondition = exports.ke_Super_GetObjByJSONStr = exports.ke_Super_GetObjLstByJSONObjLst = exports.ke_Super_GetObjLstByJSONStr = exports.ke_Super_GetJSONStrByObj = exports.ke_Super_CheckProperty4Update = exports.ke_Super_CheckPropertyNew = exports.ke_Super_BindDdl_ke_SuperIdInDiv_Cache = exports.ke_Super_ReFreshThisCache = exports.ke_Super_ReFreshCache = exports.ke_Super_GetWebApiUrl = exports.ke_Super_GetMaxStrIdByPrefix = exports.ke_Super_GetRecCountByCond_Cache = exports.ke_Super_GetRecCountByCondAsync = exports.ke_Super_IsExistAsync = exports.ke_Super_IsExist_Cache = exports.ke_Super_IsExist = exports.ke_Super_IsExistRecordAsync = exports.ke_Super_IsExistRecord_Cache = exports.ke_Super_UpdateWithConditionAsync = exports.ke_Super_UpdateRecordAsync = exports.ke_Super_AddNewRecordWithReturnKey = exports.ke_Super_AddNewRecordWithReturnKeyAsync = exports.ke_Super_AddNewRecordWithMaxIdAsync = exports.ke_Super_AddNewRecordAsync = exports.ke_Super_Delke_SupersByCondAsync = exports.ke_Super_Delke_SupersAsync = exports.ke_Super_DelRecordAsync = exports.ke_Super_GetObjLstByPagerAsync = exports.ke_Super_GetObjLstByPager_Cache = exports.ke_Super_GetObjLstByRange = exports.ke_Super_GetObjLstByRangeAsync = exports.ke_Super_GetTopObjLstAsync = exports.ke_Super_GetObjLstByke_SuperIdLst_Cache = exports.ke_Super_GetObjLstByke_SuperIdLstAsync = exports.ke_Super_GetSubObjLst_Cache = exports.ke_Super_GetObjLst_PureCache = exports.ke_Super_GetObjLst_Cache = exports.ke_Super_GetObjLst_sessionStorage_PureCache = exports.ke_Super_GetObjLst_sessionStorage = exports.ke_Super_GetObjLstAsync = exports.ke_Super_GetObjLst_localStorage_PureCache = exports.ke_Super_GetObjLst_localStorage = exports.ke_Super_GetObjLst_ClientCache = exports.ke_Super_GetFirstObjAsync = exports.ke_Super_GetFirstID = exports.ke_Super_GetFirstIDAsync = exports.ke_Super_funcKey = exports.ke_Super_FilterFunByKey = exports.ke_Super_SortFunByKey = exports.ke_Super_SortFun_Defa_2Fld = exports.ke_Super_SortFun_Defa = exports.ke_Super_func = exports.ke_Super_GetNameByke_SuperId_Cache = exports.ke_Super_UpdateObjInLst_Cache = exports.ke_Super_GetObjByke_SuperId_localStorage = exports.ke_Super_GetObjByke_SuperId_Cache = exports.ke_Super_GetObjByke_SuperIdAsync = exports.ke_Super_ConstructorName = exports.ke_Super_Controller = void 0;
    /**
     * 知识经济父类(ke_Super)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clske_SuperEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clske_SuperEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.ke_Super_Controller = "ke_SuperApi";
    exports.ke_Super_ConstructorName = "ke_Super";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strke_SuperId:关键字
    * @returns 对象
    **/
    async function ke_Super_GetObjByke_SuperIdAsync(strke_SuperId) {
        const strThisFuncName = "GetObjByke_SuperIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strke_SuperId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strke_SuperId]不能为空！(In clske_SuperWApi.GetObjByke_SuperIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strke_SuperId.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strke_SuperId]的长度:[{0}]不正确！(clske_SuperWApi.GetObjByke_SuperIdAsync)", strke_SuperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByke_SuperId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strke_SuperId": strke_SuperId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objke_Super = ke_Super_GetObjFromJsonObj(returnObj);
                return objke_Super;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_GetObjByke_SuperIdAsync = ke_Super_GetObjByke_SuperIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strke_SuperId:所给的关键字
     * @returns 对象
    */
    async function ke_Super_GetObjByke_SuperId_Cache(strke_SuperId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByke_SuperId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strke_SuperId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strke_SuperId]不能为空！(In clske_SuperWApi.GetObjByke_SuperId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strke_SuperId.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strke_SuperId]的长度:[{0}]不正确！(clske_SuperWApi.GetObjByke_SuperId_Cache)", strke_SuperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrke_SuperObjLst_Cache = await ke_Super_GetObjLst_Cache();
        try {
            const arrke_Super_Sel = arrke_SuperObjLst_Cache.filter(x => x.ke_SuperId == strke_SuperId);
            let objke_Super;
            if (arrke_Super_Sel.length > 0) {
                objke_Super = arrke_Super_Sel[0];
                return objke_Super;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objke_Super_Const = await ke_Super_GetObjByke_SuperIdAsync(strke_SuperId);
                    if (objke_Super_Const != null) {
                        ke_Super_ReFreshThisCache();
                        return objke_Super_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strke_SuperId, exports.ke_Super_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.ke_Super_GetObjByke_SuperId_Cache = ke_Super_GetObjByke_SuperId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strke_SuperId:所给的关键字
     * @returns 对象
    */
    async function ke_Super_GetObjByke_SuperId_localStorage(strke_SuperId) {
        const strThisFuncName = "GetObjByke_SuperId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strke_SuperId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strke_SuperId]不能为空！(In clske_SuperWApi.GetObjByke_SuperId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strke_SuperId.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strke_SuperId]的长度:[{0}]不正确！(clske_SuperWApi.GetObjByke_SuperId_localStorage)", strke_SuperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clske_SuperEN_js_1.clske_SuperEN._CurrTabName, strke_SuperId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objke_Super_Cache = JSON.parse(strTempObj);
            return objke_Super_Cache;
        }
        try {
            const objke_Super = await ke_Super_GetObjByke_SuperIdAsync(strke_SuperId);
            if (objke_Super != null) {
                localStorage.setItem(strKey, JSON.stringify(objke_Super));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objke_Super;
            }
            return objke_Super;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strke_SuperId, exports.ke_Super_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.ke_Super_GetObjByke_SuperId_localStorage = ke_Super_GetObjByke_SuperId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objke_Super:所给的对象
     * @returns 对象
    */
    async function ke_Super_UpdateObjInLst_Cache(objke_Super) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrke_SuperObjLst_Cache = await ke_Super_GetObjLst_Cache();
            const obj = arrke_SuperObjLst_Cache.find(x => x.ke_SuperId == objke_Super.ke_SuperId);
            if (obj != null) {
                objke_Super.ke_SuperId = obj.ke_SuperId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objke_Super);
            }
            else {
                arrke_SuperObjLst_Cache.push(objke_Super);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.ke_Super_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.ke_Super_UpdateObjInLst_Cache = ke_Super_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strke_SuperId:所给的关键字
     * @returns 对象
    */
    async function ke_Super_GetNameByke_SuperId_Cache(strke_SuperId) {
        const strThisFuncName = "GetNameByke_SuperId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strke_SuperId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strke_SuperId]不能为空！(In clske_SuperWApi.GetNameByke_SuperId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strke_SuperId.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strke_SuperId]的长度:[{0}]不正确！(clske_SuperWApi.GetNameByke_SuperId_Cache)", strke_SuperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrke_SuperObjLst_Cache = await ke_Super_GetObjLst_Cache();
        if (arrke_SuperObjLst_Cache == null)
            return "";
        try {
            const arrke_Super_Sel = arrke_SuperObjLst_Cache.filter(x => x.ke_SuperId == strke_SuperId);
            let objke_Super;
            if (arrke_Super_Sel.length > 0) {
                objke_Super = arrke_Super_Sel[0];
                return objke_Super.ke_SuperName_cn;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strke_SuperId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.ke_Super_GetNameByke_SuperId_Cache = ke_Super_GetNameByke_SuperId_Cache;
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
    async function ke_Super_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clske_SuperEN_js_1.clske_SuperEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clske_SuperEN_js_1.clske_SuperEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strke_SuperId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objke_Super = await ke_Super_GetObjByke_SuperId_Cache(strke_SuperId);
        if (objke_Super == null)
            return "";
        if (objke_Super.GetFldValue(strOutFldName) == null)
            return "";
        return objke_Super.GetFldValue(strOutFldName).toString();
    }
    exports.ke_Super_func = ke_Super_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ke_Super_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.ke_SuperId.localeCompare(b.ke_SuperId);
    }
    exports.ke_Super_SortFun_Defa = ke_Super_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ke_Super_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.ke_SuperName_cn == b.ke_SuperName_cn)
            return a.ke_SuperName_en.localeCompare(b.ke_SuperName_en);
        else
            return a.ke_SuperName_cn.localeCompare(b.ke_SuperName_cn);
    }
    exports.ke_Super_SortFun_Defa_2Fld = ke_Super_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ke_Super_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperId:
                    return (a, b) => {
                        return a.ke_SuperId.localeCompare(b.ke_SuperId);
                    };
                case clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperName_cn:
                    return (a, b) => {
                        return a.ke_SuperName_cn.localeCompare(b.ke_SuperName_cn);
                    };
                case clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperName_en:
                    return (a, b) => {
                        if (a.ke_SuperName_en == null)
                            return -1;
                        if (b.ke_SuperName_en == null)
                            return 1;
                        return a.ke_SuperName_en.localeCompare(b.ke_SuperName_en);
                    };
                case clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperDescribe_cn:
                    return (a, b) => {
                        if (a.ke_SuperDescribe_cn == null)
                            return -1;
                        if (b.ke_SuperDescribe_cn == null)
                            return 1;
                        return a.ke_SuperDescribe_cn.localeCompare(b.ke_SuperDescribe_cn);
                    };
                case clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperDescribe_en:
                    return (a, b) => {
                        if (a.ke_SuperDescribe_en == null)
                            return -1;
                        if (b.ke_SuperDescribe_en == null)
                            return 1;
                        return a.ke_SuperDescribe_en.localeCompare(b.ke_SuperDescribe_en);
                    };
                case clske_SuperEN_js_1.clske_SuperEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clske_SuperEN_js_1.clske_SuperEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clske_SuperEN_js_1.clske_SuperEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ke_Super]中不存在！(in ${exports.ke_Super_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperId:
                    return (a, b) => {
                        return b.ke_SuperId.localeCompare(a.ke_SuperId);
                    };
                case clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperName_cn:
                    return (a, b) => {
                        return b.ke_SuperName_cn.localeCompare(a.ke_SuperName_cn);
                    };
                case clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperName_en:
                    return (a, b) => {
                        if (b.ke_SuperName_en == null)
                            return -1;
                        if (a.ke_SuperName_en == null)
                            return 1;
                        return b.ke_SuperName_en.localeCompare(a.ke_SuperName_en);
                    };
                case clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperDescribe_cn:
                    return (a, b) => {
                        if (b.ke_SuperDescribe_cn == null)
                            return -1;
                        if (a.ke_SuperDescribe_cn == null)
                            return 1;
                        return b.ke_SuperDescribe_cn.localeCompare(a.ke_SuperDescribe_cn);
                    };
                case clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperDescribe_en:
                    return (a, b) => {
                        if (b.ke_SuperDescribe_en == null)
                            return -1;
                        if (a.ke_SuperDescribe_en == null)
                            return 1;
                        return b.ke_SuperDescribe_en.localeCompare(a.ke_SuperDescribe_en);
                    };
                case clske_SuperEN_js_1.clske_SuperEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clske_SuperEN_js_1.clske_SuperEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clske_SuperEN_js_1.clske_SuperEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ke_Super]中不存在！(in ${exports.ke_Super_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ke_Super_SortFunByKey = ke_Super_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ke_Super_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperId:
                return (obj) => {
                    return obj.ke_SuperId === value;
                };
            case clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperName_cn:
                return (obj) => {
                    return obj.ke_SuperName_cn === value;
                };
            case clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperName_en:
                return (obj) => {
                    return obj.ke_SuperName_en === value;
                };
            case clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperDescribe_cn:
                return (obj) => {
                    return obj.ke_SuperDescribe_cn === value;
                };
            case clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperDescribe_en:
                return (obj) => {
                    return obj.ke_SuperDescribe_en === value;
                };
            case clske_SuperEN_js_1.clske_SuperEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clske_SuperEN_js_1.clske_SuperEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clske_SuperEN_js_1.clske_SuperEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ke_Super]中不存在！(in ${exports.ke_Super_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ke_Super_FilterFunByKey = ke_Super_FilterFunByKey;
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
    async function ke_Super_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrke_Super = await ke_Super_GetObjLst_Cache();
        if (arrke_Super == null)
            return [];
        let arrke_Super_Sel = arrke_Super;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrke_Super_Sel = arrke_Super_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrke_Super_Sel.length == 0)
            return [];
        return arrke_Super_Sel.map(x => x.ke_SuperId);
    }
    exports.ke_Super_funcKey = ke_Super_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ke_Super_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_GetFirstIDAsync = ke_Super_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ke_Super_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_GetFirstID = ke_Super_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ke_Super_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
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
                const objke_Super = ke_Super_GetObjFromJsonObj(returnObj);
                return objke_Super;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_GetFirstObjAsync = ke_Super_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ke_Super_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clske_SuperEN_js_1.clske_SuperEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clske_SuperEN_js_1.clske_SuperEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clske_SuperEN_js_1.clske_SuperEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrke_SuperExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrke_SuperObjLst_T = ke_Super_GetObjLstByJSONObjLst(arrke_SuperExObjLst_Cache);
            return arrke_SuperObjLst_T;
        }
        try {
            const arrke_SuperExObjLst = await ke_Super_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrke_SuperExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrke_SuperExObjLst.length);
            console.log(strInfo);
            return arrke_SuperExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.ke_Super_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ke_Super_GetObjLst_ClientCache = ke_Super_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ke_Super_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clske_SuperEN_js_1.clske_SuperEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clske_SuperEN_js_1.clske_SuperEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clske_SuperEN_js_1.clske_SuperEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrke_SuperExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrke_SuperObjLst_T = ke_Super_GetObjLstByJSONObjLst(arrke_SuperExObjLst_Cache);
            return arrke_SuperObjLst_T;
        }
        try {
            const arrke_SuperExObjLst = await ke_Super_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrke_SuperExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrke_SuperExObjLst.length);
            console.log(strInfo);
            return arrke_SuperExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.ke_Super_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ke_Super_GetObjLst_localStorage = ke_Super_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ke_Super_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clske_SuperEN_js_1.clske_SuperEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrke_SuperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrke_SuperObjLst_Cache;
        }
        else
            return null;
    }
    exports.ke_Super_GetObjLst_localStorage_PureCache = ke_Super_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ke_Super_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.ke_Super_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ke_Super_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_GetObjLstAsync = ke_Super_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ke_Super_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clske_SuperEN_js_1.clske_SuperEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clske_SuperEN_js_1.clske_SuperEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clske_SuperEN_js_1.clske_SuperEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrke_SuperExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrke_SuperObjLst_T = ke_Super_GetObjLstByJSONObjLst(arrke_SuperExObjLst_Cache);
            return arrke_SuperObjLst_T;
        }
        try {
            const arrke_SuperExObjLst = await ke_Super_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrke_SuperExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrke_SuperExObjLst.length);
            console.log(strInfo);
            return arrke_SuperExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.ke_Super_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ke_Super_GetObjLst_sessionStorage = ke_Super_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ke_Super_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clske_SuperEN_js_1.clske_SuperEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrke_SuperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrke_SuperObjLst_Cache;
        }
        else
            return null;
    }
    exports.ke_Super_GetObjLst_sessionStorage_PureCache = ke_Super_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ke_Super_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrke_SuperObjLst_Cache;
        switch (clske_SuperEN_js_1.clske_SuperEN.CacheModeId) {
            case "04": //sessionStorage
                arrke_SuperObjLst_Cache = await ke_Super_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrke_SuperObjLst_Cache = await ke_Super_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrke_SuperObjLst_Cache = await ke_Super_GetObjLst_ClientCache();
                break;
            default:
                arrke_SuperObjLst_Cache = await ke_Super_GetObjLst_ClientCache();
                break;
        }
        const arrke_SuperObjLst = ke_Super_GetObjLstByJSONObjLst(arrke_SuperObjLst_Cache);
        return arrke_SuperObjLst_Cache;
    }
    exports.ke_Super_GetObjLst_Cache = ke_Super_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ke_Super_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrke_SuperObjLst_Cache;
        switch (clske_SuperEN_js_1.clske_SuperEN.CacheModeId) {
            case "04": //sessionStorage
                arrke_SuperObjLst_Cache = await ke_Super_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrke_SuperObjLst_Cache = await ke_Super_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrke_SuperObjLst_Cache = null;
                break;
            default:
                arrke_SuperObjLst_Cache = null;
                break;
        }
        return arrke_SuperObjLst_Cache;
    }
    exports.ke_Super_GetObjLst_PureCache = ke_Super_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrke_SuperId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ke_Super_GetSubObjLst_Cache(objke_Super_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrke_SuperObjLst_Cache = await ke_Super_GetObjLst_Cache();
        let arrke_Super_Sel = arrke_SuperObjLst_Cache;
        if (objke_Super_Cond.sf_FldComparisonOp == null || objke_Super_Cond.sf_FldComparisonOp == "")
            return arrke_Super_Sel;
        const dicFldComparisonOp = JSON.parse(objke_Super_Cond.sf_FldComparisonOp);
        //console.log("clske_SuperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objke_Super_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objke_Super_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrke_Super_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objke_Super_Cond), exports.ke_Super_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ke_Super_GetSubObjLst_Cache = ke_Super_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrke_SuperId:关键字列表
    * @returns 对象列表
    **/
    async function ke_Super_GetObjLstByke_SuperIdLstAsync(arrke_SuperId) {
        const strThisFuncName = "GetObjLstByke_SuperIdLstAsync";
        const strAction = "GetObjLstByke_SuperIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrke_SuperId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.ke_Super_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ke_Super_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_GetObjLstByke_SuperIdLstAsync = ke_Super_GetObjLstByke_SuperIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrke_SuperIdLst:关键字列表
     * @returns 对象列表
    */
    async function ke_Super_GetObjLstByke_SuperIdLst_Cache(arrke_SuperIdLst) {
        const strThisFuncName = "GetObjLstByke_SuperIdLst_Cache";
        try {
            const arrke_SuperObjLst_Cache = await ke_Super_GetObjLst_Cache();
            const arrke_Super_Sel = arrke_SuperObjLst_Cache.filter(x => arrke_SuperIdLst.indexOf(x.ke_SuperId) > -1);
            return arrke_Super_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrke_SuperIdLst.join(","), exports.ke_Super_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.ke_Super_GetObjLstByke_SuperIdLst_Cache = ke_Super_GetObjLstByke_SuperIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ke_Super_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.ke_Super_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ke_Super_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_GetTopObjLstAsync = ke_Super_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ke_Super_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.ke_Super_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ke_Super_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_GetObjLstByRangeAsync = ke_Super_GetObjLstByRangeAsync;
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
    async function ke_Super_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_GetObjLstByRange = ke_Super_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function ke_Super_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrke_SuperObjLst_Cache = await ke_Super_GetObjLst_Cache();
        if (arrke_SuperObjLst_Cache.length == 0)
            return arrke_SuperObjLst_Cache;
        let arrke_Super_Sel = arrke_SuperObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objke_Super_Cond = new clske_SuperEN_js_1.clske_SuperEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objke_Super_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clske_SuperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objke_Super_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrke_Super_Sel.length == 0)
                return arrke_Super_Sel;
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
                arrke_Super_Sel = arrke_Super_Sel.sort(ke_Super_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrke_Super_Sel = arrke_Super_Sel.sort(objPagerPara.sortFun);
            }
            arrke_Super_Sel = arrke_Super_Sel.slice(intStart, intEnd);
            return arrke_Super_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.ke_Super_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ke_Super_GetObjLstByPager_Cache = ke_Super_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ke_Super_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.ke_Super_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ke_Super_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_GetObjLstByPagerAsync = ke_Super_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strke_SuperId:关键字
    * @returns 获取删除的结果
    **/
    async function ke_Super_DelRecordAsync(strke_SuperId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strke_SuperId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_DelRecordAsync = ke_Super_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrke_SuperId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ke_Super_Delke_SupersAsync(arrke_SuperId) {
        const strThisFuncName = "Delke_SupersAsync";
        const strAction = "Delke_Supers";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrke_SuperId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_Delke_SupersAsync = ke_Super_Delke_SupersAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ke_Super_Delke_SupersByCondAsync(strWhereCond) {
        const strThisFuncName = "Delke_SupersByCondAsync";
        const strAction = "Delke_SupersByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_Delke_SupersByCondAsync = ke_Super_Delke_SupersByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objke_SuperEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ke_Super_AddNewRecordAsync(objke_SuperEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objke_SuperEN.ke_SuperId === null || objke_SuperEN.ke_SuperId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objke_SuperEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objke_SuperEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_AddNewRecordAsync = ke_Super_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objke_SuperEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ke_Super_AddNewRecordWithMaxIdAsync(objke_SuperEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objke_SuperEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_AddNewRecordWithMaxIdAsync = ke_Super_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objke_SuperEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ke_Super_AddNewRecordWithReturnKeyAsync(objke_SuperEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objke_SuperEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_AddNewRecordWithReturnKeyAsync = ke_Super_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objke_SuperEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ke_Super_AddNewRecordWithReturnKey(objke_SuperEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objke_SuperEN.ke_SuperId === null || objke_SuperEN.ke_SuperId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objke_SuperEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_AddNewRecordWithReturnKey = ke_Super_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objke_SuperEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ke_Super_UpdateRecordAsync(objke_SuperEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objke_SuperEN.sf_UpdFldSetStr === undefined || objke_SuperEN.sf_UpdFldSetStr === null || objke_SuperEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objke_SuperEN.ke_SuperId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objke_SuperEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_UpdateRecordAsync = ke_Super_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objke_SuperEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ke_Super_UpdateWithConditionAsync(objke_SuperEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objke_SuperEN.sf_UpdFldSetStr === undefined || objke_SuperEN.sf_UpdFldSetStr === null || objke_SuperEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objke_SuperEN.ke_SuperId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
        objke_SuperEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objke_SuperEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_UpdateWithConditionAsync = ke_Super_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrke_SuperId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ke_Super_IsExistRecord_Cache(objke_Super_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrke_SuperObjLst_Cache = await ke_Super_GetObjLst_Cache();
        if (arrke_SuperObjLst_Cache == null)
            return false;
        let arrke_Super_Sel = arrke_SuperObjLst_Cache;
        if (objke_Super_Cond.sf_FldComparisonOp == null || objke_Super_Cond.sf_FldComparisonOp == "")
            return arrke_Super_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objke_Super_Cond.sf_FldComparisonOp);
        //console.log("clske_SuperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objke_Super_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objke_Super_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrke_Super_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objke_Super_Cond), exports.ke_Super_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.ke_Super_IsExistRecord_Cache = ke_Super_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ke_Super_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_IsExistRecordAsync = ke_Super_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strke_SuperId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ke_Super_IsExist(strke_SuperId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ke_SuperId": strke_SuperId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_IsExist = ke_Super_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strke_SuperId:所给的关键字
     * @returns 对象
    */
    async function ke_Super_IsExist_Cache(strke_SuperId) {
        const strThisFuncName = "IsExist_Cache";
        const arrke_SuperObjLst_Cache = await ke_Super_GetObjLst_Cache();
        if (arrke_SuperObjLst_Cache == null)
            return false;
        try {
            const arrke_Super_Sel = arrke_SuperObjLst_Cache.filter(x => x.ke_SuperId == strke_SuperId);
            if (arrke_Super_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strke_SuperId, exports.ke_Super_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.ke_Super_IsExist_Cache = ke_Super_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strke_SuperId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ke_Super_IsExistAsync(strke_SuperId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strke_SuperId": strke_SuperId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_IsExistAsync = ke_Super_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ke_Super_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_GetRecCountByCondAsync = ke_Super_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objke_Super_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function ke_Super_GetRecCountByCond_Cache(objke_Super_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrke_SuperObjLst_Cache = await ke_Super_GetObjLst_Cache();
        if (arrke_SuperObjLst_Cache == null)
            return 0;
        let arrke_Super_Sel = arrke_SuperObjLst_Cache;
        if (objke_Super_Cond.sf_FldComparisonOp == null || objke_Super_Cond.sf_FldComparisonOp == "")
            return arrke_Super_Sel.length;
        const dicFldComparisonOp = JSON.parse(objke_Super_Cond.sf_FldComparisonOp);
        //console.log("clske_SuperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objke_Super_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objke_Super_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrke_Super_Sel = arrke_Super_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrke_Super_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objke_Super_Cond), exports.ke_Super_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.ke_Super_GetRecCountByCond_Cache = ke_Super_GetRecCountByCond_Cache;
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
    async function ke_Super_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.ke_Super_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.ke_Super_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ke_Super_GetMaxStrIdByPrefix = ke_Super_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ke_Super_GetWebApiUrl(strController, strAction) {
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
    exports.ke_Super_GetWebApiUrl = ke_Super_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function ke_Super_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clske_SuperEN_js_1.clske_SuperEN._CurrTabName;
        switch (clske_SuperEN_js_1.clske_SuperEN.CacheModeId) {
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
    exports.ke_Super_ReFreshCache = ke_Super_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function ke_Super_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clske_SuperEN_js_1.clske_SuperEN._CurrTabName;
            switch (clske_SuperEN_js_1.clske_SuperEN.CacheModeId) {
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
    exports.ke_Super_ReFreshThisCache = ke_Super_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function ke_Super_BindDdl_ke_SuperIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_ke_SuperIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_ke_SuperIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_ke_SuperIdInDiv_Cache");
        const arrObjLst_Sel = await ke_Super_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperId, clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperName_cn, "知识经济父类");
    }
    exports.ke_Super_BindDdl_ke_SuperIdInDiv_Cache = ke_Super_BindDdl_ke_SuperIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ke_Super_CheckPropertyNew(pobjke_SuperEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperName_cn) === true) {
            throw new Error("(errid:Watl000058)字段[知识分类名]不能为空(In 知识经济父类)!(clske_SuperBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperId) == false && (0, clsString_js_2.GetStrLen)(pobjke_SuperEN.ke_SuperId) > 4) {
            throw new Error("(errid:Watl000059)字段[知识分类Id(ke_SuperId)]的长度不能超过4(In 知识经济父类(ke_Super))!值:$(pobjke_SuperEN.ke_SuperId)(clske_SuperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperName_cn) == false && (0, clsString_js_2.GetStrLen)(pobjke_SuperEN.ke_SuperName_cn) > 200) {
            throw new Error("(errid:Watl000059)字段[知识分类名(ke_SuperName_cn)]的长度不能超过200(In 知识经济父类(ke_Super))!值:$(pobjke_SuperEN.ke_SuperName_cn)(clske_SuperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperName_en) == false && (0, clsString_js_2.GetStrLen)(pobjke_SuperEN.ke_SuperName_en) > 200) {
            throw new Error("(errid:Watl000059)字段[知识分类英文名(ke_SuperName_en)]的长度不能超过200(In 知识经济父类(ke_Super))!值:$(pobjke_SuperEN.ke_SuperName_en)(clske_SuperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperDescribe_cn) == false && (0, clsString_js_2.GetStrLen)(pobjke_SuperEN.ke_SuperDescribe_cn) > 500) {
            throw new Error("(errid:Watl000059)字段[知识分类描述(ke_SuperDescribe_cn)]的长度不能超过500(In 知识经济父类(ke_Super))!值:$(pobjke_SuperEN.ke_SuperDescribe_cn)(clske_SuperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperDescribe_en) == false && (0, clsString_js_2.GetStrLen)(pobjke_SuperEN.ke_SuperDescribe_en) > 500) {
            throw new Error("(errid:Watl000059)字段[知识分类英文描述(ke_SuperDescribe_en)]的长度不能超过500(In 知识经济父类(ke_Super))!值:$(pobjke_SuperEN.ke_SuperDescribe_en)(clske_SuperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjke_SuperEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 知识经济父类(ke_Super))!值:$(pobjke_SuperEN.updDate)(clske_SuperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjke_SuperEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 知识经济父类(ke_Super))!值:$(pobjke_SuperEN.updUser)(clske_SuperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjke_SuperEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 知识经济父类(ke_Super))!值:$(pobjke_SuperEN.memo)(clske_SuperBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperId) == false && undefined !== pobjke_SuperEN.ke_SuperId && clsString_js_1.tzDataType.isString(pobjke_SuperEN.ke_SuperId) === false) {
            throw new Error("(errid:Watl000060)字段[知识分类Id(ke_SuperId)]的值:[$(pobjke_SuperEN.ke_SuperId)], 非法，应该为字符型(In 知识经济父类(ke_Super))!(clske_SuperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperName_cn) == false && undefined !== pobjke_SuperEN.ke_SuperName_cn && clsString_js_1.tzDataType.isString(pobjke_SuperEN.ke_SuperName_cn) === false) {
            throw new Error("(errid:Watl000060)字段[知识分类名(ke_SuperName_cn)]的值:[$(pobjke_SuperEN.ke_SuperName_cn)], 非法，应该为字符型(In 知识经济父类(ke_Super))!(clske_SuperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperName_en) == false && undefined !== pobjke_SuperEN.ke_SuperName_en && clsString_js_1.tzDataType.isString(pobjke_SuperEN.ke_SuperName_en) === false) {
            throw new Error("(errid:Watl000060)字段[知识分类英文名(ke_SuperName_en)]的值:[$(pobjke_SuperEN.ke_SuperName_en)], 非法，应该为字符型(In 知识经济父类(ke_Super))!(clske_SuperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperDescribe_cn) == false && undefined !== pobjke_SuperEN.ke_SuperDescribe_cn && clsString_js_1.tzDataType.isString(pobjke_SuperEN.ke_SuperDescribe_cn) === false) {
            throw new Error("(errid:Watl000060)字段[知识分类描述(ke_SuperDescribe_cn)]的值:[$(pobjke_SuperEN.ke_SuperDescribe_cn)], 非法，应该为字符型(In 知识经济父类(ke_Super))!(clske_SuperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperDescribe_en) == false && undefined !== pobjke_SuperEN.ke_SuperDescribe_en && clsString_js_1.tzDataType.isString(pobjke_SuperEN.ke_SuperDescribe_en) === false) {
            throw new Error("(errid:Watl000060)字段[知识分类英文描述(ke_SuperDescribe_en)]的值:[$(pobjke_SuperEN.ke_SuperDescribe_en)], 非法，应该为字符型(In 知识经济父类(ke_Super))!(clske_SuperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.updDate) == false && undefined !== pobjke_SuperEN.updDate && clsString_js_1.tzDataType.isString(pobjke_SuperEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjke_SuperEN.updDate)], 非法，应该为字符型(In 知识经济父类(ke_Super))!(clske_SuperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.updUser) == false && undefined !== pobjke_SuperEN.updUser && clsString_js_1.tzDataType.isString(pobjke_SuperEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjke_SuperEN.updUser)], 非法，应该为字符型(In 知识经济父类(ke_Super))!(clske_SuperBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.memo) == false && undefined !== pobjke_SuperEN.memo && clsString_js_1.tzDataType.isString(pobjke_SuperEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjke_SuperEN.memo)], 非法，应该为字符型(In 知识经济父类(ke_Super))!(clske_SuperBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjke_SuperEN.SetIsCheckProperty(true);
    }
    exports.ke_Super_CheckPropertyNew = ke_Super_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ke_Super_CheckProperty4Update(pobjke_SuperEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperId) == false && (0, clsString_js_2.GetStrLen)(pobjke_SuperEN.ke_SuperId) > 4) {
            throw new Error("(errid:Watl000062)字段[知识分类Id(ke_SuperId)]的长度不能超过4(In 知识经济父类(ke_Super))!值:$(pobjke_SuperEN.ke_SuperId)(clske_SuperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperName_cn) == false && (0, clsString_js_2.GetStrLen)(pobjke_SuperEN.ke_SuperName_cn) > 200) {
            throw new Error("(errid:Watl000062)字段[知识分类名(ke_SuperName_cn)]的长度不能超过200(In 知识经济父类(ke_Super))!值:$(pobjke_SuperEN.ke_SuperName_cn)(clske_SuperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperName_en) == false && (0, clsString_js_2.GetStrLen)(pobjke_SuperEN.ke_SuperName_en) > 200) {
            throw new Error("(errid:Watl000062)字段[知识分类英文名(ke_SuperName_en)]的长度不能超过200(In 知识经济父类(ke_Super))!值:$(pobjke_SuperEN.ke_SuperName_en)(clske_SuperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperDescribe_cn) == false && (0, clsString_js_2.GetStrLen)(pobjke_SuperEN.ke_SuperDescribe_cn) > 500) {
            throw new Error("(errid:Watl000062)字段[知识分类描述(ke_SuperDescribe_cn)]的长度不能超过500(In 知识经济父类(ke_Super))!值:$(pobjke_SuperEN.ke_SuperDescribe_cn)(clske_SuperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperDescribe_en) == false && (0, clsString_js_2.GetStrLen)(pobjke_SuperEN.ke_SuperDescribe_en) > 500) {
            throw new Error("(errid:Watl000062)字段[知识分类英文描述(ke_SuperDescribe_en)]的长度不能超过500(In 知识经济父类(ke_Super))!值:$(pobjke_SuperEN.ke_SuperDescribe_en)(clske_SuperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjke_SuperEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 知识经济父类(ke_Super))!值:$(pobjke_SuperEN.updDate)(clske_SuperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjke_SuperEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 知识经济父类(ke_Super))!值:$(pobjke_SuperEN.updUser)(clske_SuperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjke_SuperEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 知识经济父类(ke_Super))!值:$(pobjke_SuperEN.memo)(clske_SuperBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperId) == false && undefined !== pobjke_SuperEN.ke_SuperId && clsString_js_1.tzDataType.isString(pobjke_SuperEN.ke_SuperId) === false) {
            throw new Error("(errid:Watl000063)字段[知识分类Id(ke_SuperId)]的值:[$(pobjke_SuperEN.ke_SuperId)], 非法，应该为字符型(In 知识经济父类(ke_Super))!(clske_SuperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperName_cn) == false && undefined !== pobjke_SuperEN.ke_SuperName_cn && clsString_js_1.tzDataType.isString(pobjke_SuperEN.ke_SuperName_cn) === false) {
            throw new Error("(errid:Watl000063)字段[知识分类名(ke_SuperName_cn)]的值:[$(pobjke_SuperEN.ke_SuperName_cn)], 非法，应该为字符型(In 知识经济父类(ke_Super))!(clske_SuperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperName_en) == false && undefined !== pobjke_SuperEN.ke_SuperName_en && clsString_js_1.tzDataType.isString(pobjke_SuperEN.ke_SuperName_en) === false) {
            throw new Error("(errid:Watl000063)字段[知识分类英文名(ke_SuperName_en)]的值:[$(pobjke_SuperEN.ke_SuperName_en)], 非法，应该为字符型(In 知识经济父类(ke_Super))!(clske_SuperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperDescribe_cn) == false && undefined !== pobjke_SuperEN.ke_SuperDescribe_cn && clsString_js_1.tzDataType.isString(pobjke_SuperEN.ke_SuperDescribe_cn) === false) {
            throw new Error("(errid:Watl000063)字段[知识分类描述(ke_SuperDescribe_cn)]的值:[$(pobjke_SuperEN.ke_SuperDescribe_cn)], 非法，应该为字符型(In 知识经济父类(ke_Super))!(clske_SuperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperDescribe_en) == false && undefined !== pobjke_SuperEN.ke_SuperDescribe_en && clsString_js_1.tzDataType.isString(pobjke_SuperEN.ke_SuperDescribe_en) === false) {
            throw new Error("(errid:Watl000063)字段[知识分类英文描述(ke_SuperDescribe_en)]的值:[$(pobjke_SuperEN.ke_SuperDescribe_en)], 非法，应该为字符型(In 知识经济父类(ke_Super))!(clske_SuperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.updDate) == false && undefined !== pobjke_SuperEN.updDate && clsString_js_1.tzDataType.isString(pobjke_SuperEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjke_SuperEN.updDate)], 非法，应该为字符型(In 知识经济父类(ke_Super))!(clske_SuperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.updUser) == false && undefined !== pobjke_SuperEN.updUser && clsString_js_1.tzDataType.isString(pobjke_SuperEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjke_SuperEN.updUser)], 非法，应该为字符型(In 知识经济父类(ke_Super))!(clske_SuperBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.memo) == false && undefined !== pobjke_SuperEN.memo && clsString_js_1.tzDataType.isString(pobjke_SuperEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjke_SuperEN.memo)], 非法，应该为字符型(In 知识经济父类(ke_Super))!(clske_SuperBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjke_SuperEN.ke_SuperId) === true) {
            throw new Error("(errid:Watl000064)字段[知识分类Id]不能为空(In 知识经济父类)!(clske_SuperBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjke_SuperEN.SetIsCheckProperty(true);
    }
    exports.ke_Super_CheckProperty4Update = ke_Super_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ke_Super_GetJSONStrByObj(pobjke_SuperEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjke_SuperEN.sf_UpdFldSetStr = pobjke_SuperEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjke_SuperEN);
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
    exports.ke_Super_GetJSONStrByObj = ke_Super_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ke_Super_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrke_SuperObjLst = new Array();
        if (strJSON === "") {
            return arrke_SuperObjLst;
        }
        try {
            arrke_SuperObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrke_SuperObjLst;
        }
        return arrke_SuperObjLst;
    }
    exports.ke_Super_GetObjLstByJSONStr = ke_Super_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrke_SuperObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ke_Super_GetObjLstByJSONObjLst(arrke_SuperObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrke_SuperObjLst = new Array();
        for (const objInFor of arrke_SuperObjLstS) {
            const obj1 = ke_Super_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrke_SuperObjLst.push(obj1);
        }
        return arrke_SuperObjLst;
    }
    exports.ke_Super_GetObjLstByJSONObjLst = ke_Super_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ke_Super_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjke_SuperEN = new clske_SuperEN_js_1.clske_SuperEN();
        if (strJSON === "") {
            return pobjke_SuperEN;
        }
        try {
            pobjke_SuperEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjke_SuperEN;
        }
        return pobjke_SuperEN;
    }
    exports.ke_Super_GetObjByJSONStr = ke_Super_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ke_Super_GetCombineCondition(objke_Super_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objke_Super_Cond.dicFldComparisonOp, clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperId) == true) {
            const strComparisonOp_ke_SuperId = objke_Super_Cond.dicFldComparisonOp[clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperId, objke_Super_Cond.ke_SuperId, strComparisonOp_ke_SuperId);
        }
        if (Object.prototype.hasOwnProperty.call(objke_Super_Cond.dicFldComparisonOp, clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperName_cn) == true) {
            const strComparisonOp_ke_SuperName_cn = objke_Super_Cond.dicFldComparisonOp[clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperName_cn];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperName_cn, objke_Super_Cond.ke_SuperName_cn, strComparisonOp_ke_SuperName_cn);
        }
        if (Object.prototype.hasOwnProperty.call(objke_Super_Cond.dicFldComparisonOp, clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperName_en) == true) {
            const strComparisonOp_ke_SuperName_en = objke_Super_Cond.dicFldComparisonOp[clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperName_en];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperName_en, objke_Super_Cond.ke_SuperName_en, strComparisonOp_ke_SuperName_en);
        }
        if (Object.prototype.hasOwnProperty.call(objke_Super_Cond.dicFldComparisonOp, clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperDescribe_cn) == true) {
            const strComparisonOp_ke_SuperDescribe_cn = objke_Super_Cond.dicFldComparisonOp[clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperDescribe_cn];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperDescribe_cn, objke_Super_Cond.ke_SuperDescribe_cn, strComparisonOp_ke_SuperDescribe_cn);
        }
        if (Object.prototype.hasOwnProperty.call(objke_Super_Cond.dicFldComparisonOp, clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperDescribe_en) == true) {
            const strComparisonOp_ke_SuperDescribe_en = objke_Super_Cond.dicFldComparisonOp[clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperDescribe_en];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clske_SuperEN_js_1.clske_SuperEN.con_ke_SuperDescribe_en, objke_Super_Cond.ke_SuperDescribe_en, strComparisonOp_ke_SuperDescribe_en);
        }
        if (Object.prototype.hasOwnProperty.call(objke_Super_Cond.dicFldComparisonOp, clske_SuperEN_js_1.clske_SuperEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objke_Super_Cond.dicFldComparisonOp[clske_SuperEN_js_1.clske_SuperEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clske_SuperEN_js_1.clske_SuperEN.con_UpdDate, objke_Super_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objke_Super_Cond.dicFldComparisonOp, clske_SuperEN_js_1.clske_SuperEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objke_Super_Cond.dicFldComparisonOp[clske_SuperEN_js_1.clske_SuperEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clske_SuperEN_js_1.clske_SuperEN.con_UpdUser, objke_Super_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objke_Super_Cond.dicFldComparisonOp, clske_SuperEN_js_1.clske_SuperEN.con_Memo) == true) {
            const strComparisonOp_Memo = objke_Super_Cond.dicFldComparisonOp[clske_SuperEN_js_1.clske_SuperEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clske_SuperEN_js_1.clske_SuperEN.con_Memo, objke_Super_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.ke_Super_GetCombineCondition = ke_Super_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objke_SuperENS:源对象
     * @param objke_SuperENT:目标对象
    */
    function ke_Super_CopyObjTo(objke_SuperENS, objke_SuperENT) {
        objke_SuperENT.ke_SuperId = objke_SuperENS.ke_SuperId; //知识分类Id
        objke_SuperENT.ke_SuperName_cn = objke_SuperENS.ke_SuperName_cn; //知识分类名
        objke_SuperENT.ke_SuperName_en = objke_SuperENS.ke_SuperName_en; //知识分类英文名
        objke_SuperENT.ke_SuperDescribe_cn = objke_SuperENS.ke_SuperDescribe_cn; //知识分类描述
        objke_SuperENT.ke_SuperDescribe_en = objke_SuperENS.ke_SuperDescribe_en; //知识分类英文描述
        objke_SuperENT.updDate = objke_SuperENS.updDate; //修改日期
        objke_SuperENT.updUser = objke_SuperENS.updUser; //修改人
        objke_SuperENT.memo = objke_SuperENS.memo; //备注
        objke_SuperENT.sf_UpdFldSetStr = objke_SuperENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ke_Super_CopyObjTo = ke_Super_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objke_SuperENS:源对象
     * @param objke_SuperENT:目标对象
    */
    function ke_Super_GetObjFromJsonObj(objke_SuperENS) {
        const objke_SuperENT = new clske_SuperEN_js_1.clske_SuperEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objke_SuperENT, objke_SuperENS);
        return objke_SuperENT;
    }
    exports.ke_Super_GetObjFromJsonObj = ke_Super_GetObjFromJsonObj;
});
