/**
* 类名:clsgs_TopicRoleWApi
* 表名:gs_TopicRole(01120869)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:49:44
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsgs_TopicRoleEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_TopicRole_GetObjFromJsonObj = exports.gs_TopicRole_CopyObjTo = exports.gs_TopicRole_GetUniCondStr4Update_TopicRoleId = exports.gs_TopicRole_GetUniCondStr_TopicRoleId = exports.gs_TopicRole_GetCombineCondition = exports.gs_TopicRole_GetObjByJSONStr = exports.gs_TopicRole_GetObjLstByJSONObjLst = exports.gs_TopicRole_GetObjLstByJSONStr = exports.gs_TopicRole_GetJSONStrByObj = exports.gs_TopicRole_CheckProperty4Update = exports.gs_TopicRole_CheckPropertyNew = exports.gs_TopicRole_ReFreshThisCache = exports.gs_TopicRole_ReFreshCache = exports.gs_TopicRole_GetWebApiUrl = exports.gs_TopicRole_GetMaxStrIdByPrefix = exports.gs_TopicRole_GetMaxStrIdAsync = exports.gs_TopicRole_GetRecCountByCond_Cache = exports.gs_TopicRole_GetRecCountByCondAsync = exports.gs_TopicRole_IsExistAsync = exports.gs_TopicRole_IsExist_Cache = exports.gs_TopicRole_IsExist = exports.gs_TopicRole_IsExistRecordAsync = exports.gs_TopicRole_IsExistRecord_Cache = exports.gs_TopicRole_UpdateWithConditionAsync = exports.gs_TopicRole_UpdateRecordAsync = exports.gs_TopicRole_AddNewRecordWithReturnKey = exports.gs_TopicRole_AddNewRecordWithReturnKeyAsync = exports.gs_TopicRole_AddNewRecordWithMaxIdAsync = exports.gs_TopicRole_AddNewRecordAsync = exports.gs_TopicRole_Delgs_TopicRolesByCondAsync = exports.gs_TopicRole_Delgs_TopicRolesAsync = exports.gs_TopicRole_DelRecordAsync = exports.gs_TopicRole_GetObjLstByPagerAsync = exports.gs_TopicRole_GetObjLstByPager_Cache = exports.gs_TopicRole_GetObjLstByRange = exports.gs_TopicRole_GetObjLstByRangeAsync = exports.gs_TopicRole_GetTopObjLstAsync = exports.gs_TopicRole_GetObjLstByTopicRoleIdLst_Cache = exports.gs_TopicRole_GetObjLstByTopicRoleIdLstAsync = exports.gs_TopicRole_GetSubObjLst_Cache = exports.gs_TopicRole_GetObjLst_PureCache = exports.gs_TopicRole_GetObjLst_Cache = exports.gs_TopicRole_GetObjLst_sessionStorage_PureCache = exports.gs_TopicRole_GetObjLst_sessionStorage = exports.gs_TopicRole_GetObjLstAsync = exports.gs_TopicRole_GetObjLst_localStorage_PureCache = exports.gs_TopicRole_GetObjLst_localStorage = exports.gs_TopicRole_GetObjLst_ClientCache = exports.gs_TopicRole_GetFirstObjAsync = exports.gs_TopicRole_GetFirstID = exports.gs_TopicRole_GetFirstIDAsync = exports.gs_TopicRole_funcKey = exports.gs_TopicRole_FilterFunByKey = exports.gs_TopicRole_SortFunByKey = exports.gs_TopicRole_SortFun_Defa_2Fld = exports.gs_TopicRole_SortFun_Defa = exports.gs_TopicRole_func = exports.gs_TopicRole_UpdateObjInLst_Cache = exports.gs_TopicRole_GetObjByTopicRoleId_localStorage = exports.gs_TopicRole_GetObjByTopicRoleId_Cache = exports.gs_TopicRole_GetObjByTopicRoleIdAsync = exports.gs_TopicRole_ConstructorName = exports.gs_TopicRole_Controller = void 0;
    /**
     * 主题权限表(gs_TopicRole)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_TopicRoleEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_TopicRoleEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.gs_TopicRole_Controller = "gs_TopicRoleApi";
    exports.gs_TopicRole_ConstructorName = "gs_TopicRole";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strTopicRoleId:关键字
    * @returns 对象
    **/
    async function gs_TopicRole_GetObjByTopicRoleIdAsync(strTopicRoleId) {
        const strThisFuncName = "GetObjByTopicRoleIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTopicRoleId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTopicRoleId]不能为空！(In clsgs_TopicRoleWApi.GetObjByTopicRoleIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicRoleId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTopicRoleId]的长度:[{0}]不正确！(clsgs_TopicRoleWApi.GetObjByTopicRoleIdAsync)", strTopicRoleId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByTopicRoleId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strTopicRoleId": strTopicRoleId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objgs_TopicRole = gs_TopicRole_GetObjFromJsonObj(returnObj);
                return objgs_TopicRole;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_GetObjByTopicRoleIdAsync = gs_TopicRole_GetObjByTopicRoleIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strTopicRoleId:所给的关键字
     * @returns 对象
    */
    async function gs_TopicRole_GetObjByTopicRoleId_Cache(strTopicRoleId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByTopicRoleId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTopicRoleId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTopicRoleId]不能为空！(In clsgs_TopicRoleWApi.GetObjByTopicRoleId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicRoleId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTopicRoleId]的长度:[{0}]不正确！(clsgs_TopicRoleWApi.GetObjByTopicRoleId_Cache)", strTopicRoleId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_Cache();
        try {
            const arrgs_TopicRole_Sel = arrgs_TopicRoleObjLst_Cache.filter(x => x.topicRoleId == strTopicRoleId);
            let objgs_TopicRole;
            if (arrgs_TopicRole_Sel.length > 0) {
                objgs_TopicRole = arrgs_TopicRole_Sel[0];
                return objgs_TopicRole;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objgs_TopicRole_Const = await gs_TopicRole_GetObjByTopicRoleIdAsync(strTopicRoleId);
                    if (objgs_TopicRole_Const != null) {
                        gs_TopicRole_ReFreshThisCache();
                        return objgs_TopicRole_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicRoleId, exports.gs_TopicRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_TopicRole_GetObjByTopicRoleId_Cache = gs_TopicRole_GetObjByTopicRoleId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strTopicRoleId:所给的关键字
     * @returns 对象
    */
    async function gs_TopicRole_GetObjByTopicRoleId_localStorage(strTopicRoleId) {
        const strThisFuncName = "GetObjByTopicRoleId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTopicRoleId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTopicRoleId]不能为空！(In clsgs_TopicRoleWApi.GetObjByTopicRoleId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicRoleId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTopicRoleId]的长度:[{0}]不正确！(clsgs_TopicRoleWApi.GetObjByTopicRoleId_localStorage)", strTopicRoleId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN._CurrTabName, strTopicRoleId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_TopicRole_Cache = JSON.parse(strTempObj);
            return objgs_TopicRole_Cache;
        }
        try {
            const objgs_TopicRole = await gs_TopicRole_GetObjByTopicRoleIdAsync(strTopicRoleId);
            if (objgs_TopicRole != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_TopicRole));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_TopicRole;
            }
            return objgs_TopicRole;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicRoleId, exports.gs_TopicRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_TopicRole_GetObjByTopicRoleId_localStorage = gs_TopicRole_GetObjByTopicRoleId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_TopicRole:所给的对象
     * @returns 对象
    */
    async function gs_TopicRole_UpdateObjInLst_Cache(objgs_TopicRole) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_Cache();
            const obj = arrgs_TopicRoleObjLst_Cache.find(x => x.topicRoleId == objgs_TopicRole.topicRoleId);
            if (obj != null) {
                objgs_TopicRole.topicRoleId = obj.topicRoleId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_TopicRole);
            }
            else {
                arrgs_TopicRoleObjLst_Cache.push(objgs_TopicRole);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_TopicRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_TopicRole_UpdateObjInLst_Cache = gs_TopicRole_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
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
    async function gs_TopicRole_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_TopicRoleId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strTopicRoleId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objgs_TopicRole = await gs_TopicRole_GetObjByTopicRoleId_Cache(strTopicRoleId);
        if (objgs_TopicRole == null)
            return "";
        if (objgs_TopicRole.GetFldValue(strOutFldName) == null)
            return "";
        return objgs_TopicRole.GetFldValue(strOutFldName).toString();
    }
    exports.gs_TopicRole_func = gs_TopicRole_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TopicRole_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.topicRoleId.localeCompare(b.topicRoleId);
    }
    exports.gs_TopicRole_SortFun_Defa = gs_TopicRole_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TopicRole_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.menuNum.localeCompare(b.menuNum);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.gs_TopicRole_SortFun_Defa_2Fld = gs_TopicRole_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TopicRole_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_TopicRoleId:
                    return (a, b) => {
                        return a.topicRoleId.localeCompare(b.topicRoleId);
                    };
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_TopicId:
                    return (a, b) => {
                        if (a.topicId == null)
                            return -1;
                        if (b.topicId == null)
                            return 1;
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuNum:
                    return (a, b) => {
                        if (a.menuNum == null)
                            return -1;
                        if (b.menuNum == null)
                            return 1;
                        return a.menuNum.localeCompare(b.menuNum);
                    };
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuName:
                    return (a, b) => {
                        if (a.menuName == null)
                            return -1;
                        if (b.menuName == null)
                            return 1;
                        return a.menuName.localeCompare(b.menuName);
                    };
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuIsHide:
                    return (a, b) => {
                        if (a.menuIsHide == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_IsDefault:
                    return (a, b) => {
                        if (a.isDefault == true)
                            return 1;
                        else
                            return -1;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_TopicRole]中不存在！(in ${exports.gs_TopicRole_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_TopicRoleId:
                    return (a, b) => {
                        return b.topicRoleId.localeCompare(a.topicRoleId);
                    };
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_TopicId:
                    return (a, b) => {
                        if (b.topicId == null)
                            return -1;
                        if (a.topicId == null)
                            return 1;
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuNum:
                    return (a, b) => {
                        if (b.menuNum == null)
                            return -1;
                        if (a.menuNum == null)
                            return 1;
                        return b.menuNum.localeCompare(a.menuNum);
                    };
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuName:
                    return (a, b) => {
                        if (b.menuName == null)
                            return -1;
                        if (a.menuName == null)
                            return 1;
                        return b.menuName.localeCompare(a.menuName);
                    };
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuIsHide:
                    return (a, b) => {
                        if (b.menuIsHide == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_IsDefault:
                    return (a, b) => {
                        if (b.isDefault == true)
                            return 1;
                        else
                            return -1;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_TopicRole]中不存在！(in ${exports.gs_TopicRole_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_TopicRole_SortFunByKey = gs_TopicRole_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_TopicRole_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_TopicRoleId:
                return (obj) => {
                    return obj.topicRoleId === value;
                };
            case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuNum:
                return (obj) => {
                    return obj.menuNum === value;
                };
            case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuName:
                return (obj) => {
                    return obj.menuName === value;
                };
            case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuIsHide:
                return (obj) => {
                    return obj.menuIsHide === value;
                };
            case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_IsDefault:
                return (obj) => {
                    return obj.isDefault === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_TopicRole]中不存在！(in ${exports.gs_TopicRole_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_TopicRole_FilterFunByKey = gs_TopicRole_FilterFunByKey;
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
    async function gs_TopicRole_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_TopicRoleId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrgs_TopicRole = await gs_TopicRole_GetObjLst_Cache();
        if (arrgs_TopicRole == null)
            return [];
        let arrgs_TopicRole_Sel = arrgs_TopicRole;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrgs_TopicRole_Sel.length == 0)
            return [];
        return arrgs_TopicRole_Sel.map(x => x.topicRoleId);
    }
    exports.gs_TopicRole_funcKey = gs_TopicRole_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_TopicRole_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_GetFirstIDAsync = gs_TopicRole_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_TopicRole_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_GetFirstID = gs_TopicRole_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_TopicRole_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
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
                const objgs_TopicRole = gs_TopicRole_GetObjFromJsonObj(returnObj);
                return objgs_TopicRole;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_GetFirstObjAsync = gs_TopicRole_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TopicRole_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_TopicRoleExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrgs_TopicRoleObjLst_T = gs_TopicRole_GetObjLstByJSONObjLst(arrgs_TopicRoleExObjLst_Cache);
            return arrgs_TopicRoleObjLst_T;
        }
        try {
            const arrgs_TopicRoleExObjLst = await gs_TopicRole_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrgs_TopicRoleExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TopicRoleExObjLst.length);
            console.log(strInfo);
            return arrgs_TopicRoleExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_TopicRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_TopicRole_GetObjLst_ClientCache = gs_TopicRole_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TopicRole_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_TopicRoleExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_TopicRoleObjLst_T = gs_TopicRole_GetObjLstByJSONObjLst(arrgs_TopicRoleExObjLst_Cache);
            return arrgs_TopicRoleObjLst_T;
        }
        try {
            const arrgs_TopicRoleExObjLst = await gs_TopicRole_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_TopicRoleExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TopicRoleExObjLst.length);
            console.log(strInfo);
            return arrgs_TopicRoleExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_TopicRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_TopicRole_GetObjLst_localStorage = gs_TopicRole_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TopicRole_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_TopicRoleObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_TopicRoleObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_TopicRole_GetObjLst_localStorage_PureCache = gs_TopicRole_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_TopicRole_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TopicRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TopicRole_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_GetObjLstAsync = gs_TopicRole_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TopicRole_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_TopicRoleExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_TopicRoleObjLst_T = gs_TopicRole_GetObjLstByJSONObjLst(arrgs_TopicRoleExObjLst_Cache);
            return arrgs_TopicRoleObjLst_T;
        }
        try {
            const arrgs_TopicRoleExObjLst = await gs_TopicRole_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_TopicRoleExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TopicRoleExObjLst.length);
            console.log(strInfo);
            return arrgs_TopicRoleExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_TopicRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_TopicRole_GetObjLst_sessionStorage = gs_TopicRole_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TopicRole_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_TopicRoleObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_TopicRoleObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_TopicRole_GetObjLst_sessionStorage_PureCache = gs_TopicRole_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TopicRole_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrgs_TopicRoleObjLst_Cache;
        switch (clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_ClientCache();
                break;
            default:
                arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_ClientCache();
                break;
        }
        const arrgs_TopicRoleObjLst = gs_TopicRole_GetObjLstByJSONObjLst(arrgs_TopicRoleObjLst_Cache);
        return arrgs_TopicRoleObjLst_Cache;
    }
    exports.gs_TopicRole_GetObjLst_Cache = gs_TopicRole_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TopicRole_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_TopicRoleObjLst_Cache;
        switch (clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrgs_TopicRoleObjLst_Cache = null;
                break;
            default:
                arrgs_TopicRoleObjLst_Cache = null;
                break;
        }
        return arrgs_TopicRoleObjLst_Cache;
    }
    exports.gs_TopicRole_GetObjLst_PureCache = gs_TopicRole_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrTopicRoleId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_TopicRole_GetSubObjLst_Cache(objgs_TopicRole_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_Cache();
        let arrgs_TopicRole_Sel = arrgs_TopicRoleObjLst_Cache;
        if (objgs_TopicRole_Cond.sf_FldComparisonOp == null || objgs_TopicRole_Cond.sf_FldComparisonOp == "")
            return arrgs_TopicRole_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_TopicRole_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TopicRoleWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_TopicRole_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TopicRole_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_TopicRole_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_TopicRole_Cond), exports.gs_TopicRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TopicRole_GetSubObjLst_Cache = gs_TopicRole_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrTopicRoleId:关键字列表
    * @returns 对象列表
    **/
    async function gs_TopicRole_GetObjLstByTopicRoleIdLstAsync(arrTopicRoleId) {
        const strThisFuncName = "GetObjLstByTopicRoleIdLstAsync";
        const strAction = "GetObjLstByTopicRoleIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTopicRoleId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TopicRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TopicRole_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_GetObjLstByTopicRoleIdLstAsync = gs_TopicRole_GetObjLstByTopicRoleIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrTopicRoleIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_TopicRole_GetObjLstByTopicRoleIdLst_Cache(arrTopicRoleIdLst) {
        const strThisFuncName = "GetObjLstByTopicRoleIdLst_Cache";
        try {
            const arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_Cache();
            const arrgs_TopicRole_Sel = arrgs_TopicRoleObjLst_Cache.filter(x => arrTopicRoleIdLst.indexOf(x.topicRoleId) > -1);
            return arrgs_TopicRole_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTopicRoleIdLst.join(","), exports.gs_TopicRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.gs_TopicRole_GetObjLstByTopicRoleIdLst_Cache = gs_TopicRole_GetObjLstByTopicRoleIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_TopicRole_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TopicRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TopicRole_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_GetTopObjLstAsync = gs_TopicRole_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_TopicRole_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TopicRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TopicRole_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_GetObjLstByRangeAsync = gs_TopicRole_GetObjLstByRangeAsync;
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
    async function gs_TopicRole_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_GetObjLstByRange = gs_TopicRole_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_TopicRole_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_Cache();
        if (arrgs_TopicRoleObjLst_Cache.length == 0)
            return arrgs_TopicRoleObjLst_Cache;
        let arrgs_TopicRole_Sel = arrgs_TopicRoleObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_TopicRole_Cond = new clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TopicRole_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_TopicRoleWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TopicRole_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_TopicRole_Sel.length == 0)
                return arrgs_TopicRole_Sel;
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
                arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.sort(gs_TopicRole_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.slice(intStart, intEnd);
            return arrgs_TopicRole_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_TopicRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TopicRole_GetObjLstByPager_Cache = gs_TopicRole_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_TopicRole_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TopicRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TopicRole_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_GetObjLstByPagerAsync = gs_TopicRole_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strTopicRoleId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_TopicRole_DelRecordAsync(strTopicRoleId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strTopicRoleId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_DelRecordAsync = gs_TopicRole_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrTopicRoleId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_TopicRole_Delgs_TopicRolesAsync(arrTopicRoleId) {
        const strThisFuncName = "Delgs_TopicRolesAsync";
        const strAction = "Delgs_TopicRoles";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTopicRoleId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_Delgs_TopicRolesAsync = gs_TopicRole_Delgs_TopicRolesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_TopicRole_Delgs_TopicRolesByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_TopicRolesByCondAsync";
        const strAction = "Delgs_TopicRolesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_Delgs_TopicRolesByCondAsync = gs_TopicRole_Delgs_TopicRolesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_TopicRoleEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_TopicRole_AddNewRecordAsync(objgs_TopicRoleEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_TopicRoleEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TopicRoleEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_AddNewRecordAsync = gs_TopicRole_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_TopicRoleEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_TopicRole_AddNewRecordWithMaxIdAsync(objgs_TopicRoleEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TopicRoleEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_AddNewRecordWithMaxIdAsync = gs_TopicRole_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_TopicRoleEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_TopicRole_AddNewRecordWithReturnKeyAsync(objgs_TopicRoleEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TopicRoleEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_AddNewRecordWithReturnKeyAsync = gs_TopicRole_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_TopicRoleEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_TopicRole_AddNewRecordWithReturnKey(objgs_TopicRoleEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_TopicRoleEN.topicRoleId === null || objgs_TopicRoleEN.topicRoleId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TopicRoleEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_AddNewRecordWithReturnKey = gs_TopicRole_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_TopicRoleEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_TopicRole_UpdateRecordAsync(objgs_TopicRoleEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_TopicRoleEN.sf_UpdFldSetStr === undefined || objgs_TopicRoleEN.sf_UpdFldSetStr === null || objgs_TopicRoleEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TopicRoleEN.topicRoleId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TopicRoleEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_UpdateRecordAsync = gs_TopicRole_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_TopicRoleEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_TopicRole_UpdateWithConditionAsync(objgs_TopicRoleEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_TopicRoleEN.sf_UpdFldSetStr === undefined || objgs_TopicRoleEN.sf_UpdFldSetStr === null || objgs_TopicRoleEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TopicRoleEN.topicRoleId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
        objgs_TopicRoleEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_TopicRoleEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_UpdateWithConditionAsync = gs_TopicRole_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrTopicRoleId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_TopicRole_IsExistRecord_Cache(objgs_TopicRole_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_Cache();
        if (arrgs_TopicRoleObjLst_Cache == null)
            return false;
        let arrgs_TopicRole_Sel = arrgs_TopicRoleObjLst_Cache;
        if (objgs_TopicRole_Cond.sf_FldComparisonOp == null || objgs_TopicRole_Cond.sf_FldComparisonOp == "")
            return arrgs_TopicRole_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_TopicRole_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TopicRoleWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_TopicRole_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TopicRole_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_TopicRole_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_TopicRole_Cond), exports.gs_TopicRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_TopicRole_IsExistRecord_Cache = gs_TopicRole_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_TopicRole_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_IsExistRecordAsync = gs_TopicRole_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strTopicRoleId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_TopicRole_IsExist(strTopicRoleId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "TopicRoleId": strTopicRoleId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_IsExist = gs_TopicRole_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strTopicRoleId:所给的关键字
     * @returns 对象
    */
    async function gs_TopicRole_IsExist_Cache(strTopicRoleId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_Cache();
        if (arrgs_TopicRoleObjLst_Cache == null)
            return false;
        try {
            const arrgs_TopicRole_Sel = arrgs_TopicRoleObjLst_Cache.filter(x => x.topicRoleId == strTopicRoleId);
            if (arrgs_TopicRole_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTopicRoleId, exports.gs_TopicRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_TopicRole_IsExist_Cache = gs_TopicRole_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strTopicRoleId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_TopicRole_IsExistAsync(strTopicRoleId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strTopicRoleId": strTopicRoleId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_IsExistAsync = gs_TopicRole_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_TopicRole_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_GetRecCountByCondAsync = gs_TopicRole_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_TopicRole_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_TopicRole_GetRecCountByCond_Cache(objgs_TopicRole_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_Cache();
        if (arrgs_TopicRoleObjLst_Cache == null)
            return 0;
        let arrgs_TopicRole_Sel = arrgs_TopicRoleObjLst_Cache;
        if (objgs_TopicRole_Cond.sf_FldComparisonOp == null || objgs_TopicRole_Cond.sf_FldComparisonOp == "")
            return arrgs_TopicRole_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_TopicRole_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TopicRoleWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_TopicRole_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TopicRole_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_TopicRole_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_TopicRole_Cond), exports.gs_TopicRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_TopicRole_GetRecCountByCond_Cache = gs_TopicRole_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function gs_TopicRole_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_GetMaxStrIdAsync = gs_TopicRole_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_TopicRole_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicRole_GetMaxStrIdByPrefix = gs_TopicRole_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_TopicRole_GetWebApiUrl(strController, strAction) {
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
    exports.gs_TopicRole_GetWebApiUrl = gs_TopicRole_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_TopicRole_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN._CurrTabName;
        switch (clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.CacheModeId) {
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
    exports.gs_TopicRole_ReFreshCache = gs_TopicRole_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_TopicRole_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN._CurrTabName;
            switch (clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.CacheModeId) {
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
    exports.gs_TopicRole_ReFreshThisCache = gs_TopicRole_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_TopicRole_CheckPropertyNew(pobjgs_TopicRoleEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.topicRoleId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TopicRoleEN.topicRoleId) > 10) {
            throw new Error("(errid:Watl000059)字段[主题权限Id(topicRoleId)]的长度不能超过10(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.topicRoleId)(clsgs_TopicRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TopicRoleEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.topicId)(clsgs_TopicRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.menuNum) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TopicRoleEN.menuNum) > 10) {
            throw new Error("(errid:Watl000059)字段[菜单编号(menuNum)]的长度不能超过10(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.menuNum)(clsgs_TopicRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.menuName) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TopicRoleEN.menuName) > 100) {
            throw new Error("(errid:Watl000059)字段[菜单名称(menuName)]的长度不能超过100(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.menuName)(clsgs_TopicRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TopicRoleEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.updDate)(clsgs_TopicRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TopicRoleEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.updUser)(clsgs_TopicRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TopicRoleEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.memo)(clsgs_TopicRoleBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.topicRoleId) == false && undefined !== pobjgs_TopicRoleEN.topicRoleId && clsString_js_1.tzDataType.isString(pobjgs_TopicRoleEN.topicRoleId) === false) {
            throw new Error("(errid:Watl000060)字段[主题权限Id(topicRoleId)]的值:[$(pobjgs_TopicRoleEN.topicRoleId)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.topicId) == false && undefined !== pobjgs_TopicRoleEN.topicId && clsString_js_1.tzDataType.isString(pobjgs_TopicRoleEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_TopicRoleEN.topicId)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.menuNum) == false && undefined !== pobjgs_TopicRoleEN.menuNum && clsString_js_1.tzDataType.isString(pobjgs_TopicRoleEN.menuNum) === false) {
            throw new Error("(errid:Watl000060)字段[菜单编号(menuNum)]的值:[$(pobjgs_TopicRoleEN.menuNum)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.menuName) == false && undefined !== pobjgs_TopicRoleEN.menuName && clsString_js_1.tzDataType.isString(pobjgs_TopicRoleEN.menuName) === false) {
            throw new Error("(errid:Watl000060)字段[菜单名称(menuName)]的值:[$(pobjgs_TopicRoleEN.menuName)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
        }
        if (null != pobjgs_TopicRoleEN.menuIsHide && undefined !== pobjgs_TopicRoleEN.menuIsHide && clsString_js_1.tzDataType.isBoolean(pobjgs_TopicRoleEN.menuIsHide) === false) {
            throw new Error("(errid:Watl000060)字段[菜单是否隐藏(menuIsHide)]的值:[$(pobjgs_TopicRoleEN.menuIsHide)], 非法，应该为布尔型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.updDate) == false && undefined !== pobjgs_TopicRoleEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_TopicRoleEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TopicRoleEN.updDate)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.updUser) == false && undefined !== pobjgs_TopicRoleEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_TopicRoleEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TopicRoleEN.updUser)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.memo) == false && undefined !== pobjgs_TopicRoleEN.memo && clsString_js_1.tzDataType.isString(pobjgs_TopicRoleEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TopicRoleEN.memo)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
        }
        if (null != pobjgs_TopicRoleEN.isDefault && undefined !== pobjgs_TopicRoleEN.isDefault && clsString_js_1.tzDataType.isBoolean(pobjgs_TopicRoleEN.isDefault) === false) {
            throw new Error("(errid:Watl000060)字段[是否默认(isDefault)]的值:[$(pobjgs_TopicRoleEN.isDefault)], 非法，应该为布尔型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_TopicRoleEN.SetIsCheckProperty(true);
    }
    exports.gs_TopicRole_CheckPropertyNew = gs_TopicRole_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_TopicRole_CheckProperty4Update(pobjgs_TopicRoleEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.topicRoleId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TopicRoleEN.topicRoleId) > 10) {
            throw new Error("(errid:Watl000062)字段[主题权限Id(topicRoleId)]的长度不能超过10(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.topicRoleId)(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TopicRoleEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.topicId)(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.menuNum) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TopicRoleEN.menuNum) > 10) {
            throw new Error("(errid:Watl000062)字段[菜单编号(menuNum)]的长度不能超过10(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.menuNum)(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.menuName) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TopicRoleEN.menuName) > 100) {
            throw new Error("(errid:Watl000062)字段[菜单名称(menuName)]的长度不能超过100(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.menuName)(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TopicRoleEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.updDate)(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TopicRoleEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.updUser)(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TopicRoleEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.memo)(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.topicRoleId) == false && undefined !== pobjgs_TopicRoleEN.topicRoleId && clsString_js_1.tzDataType.isString(pobjgs_TopicRoleEN.topicRoleId) === false) {
            throw new Error("(errid:Watl000063)字段[主题权限Id(topicRoleId)]的值:[$(pobjgs_TopicRoleEN.topicRoleId)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.topicId) == false && undefined !== pobjgs_TopicRoleEN.topicId && clsString_js_1.tzDataType.isString(pobjgs_TopicRoleEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_TopicRoleEN.topicId)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.menuNum) == false && undefined !== pobjgs_TopicRoleEN.menuNum && clsString_js_1.tzDataType.isString(pobjgs_TopicRoleEN.menuNum) === false) {
            throw new Error("(errid:Watl000063)字段[菜单编号(menuNum)]的值:[$(pobjgs_TopicRoleEN.menuNum)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.menuName) == false && undefined !== pobjgs_TopicRoleEN.menuName && clsString_js_1.tzDataType.isString(pobjgs_TopicRoleEN.menuName) === false) {
            throw new Error("(errid:Watl000063)字段[菜单名称(menuName)]的值:[$(pobjgs_TopicRoleEN.menuName)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        if (null != pobjgs_TopicRoleEN.menuIsHide && undefined !== pobjgs_TopicRoleEN.menuIsHide && clsString_js_1.tzDataType.isBoolean(pobjgs_TopicRoleEN.menuIsHide) === false) {
            throw new Error("(errid:Watl000063)字段[菜单是否隐藏(menuIsHide)]的值:[$(pobjgs_TopicRoleEN.menuIsHide)], 非法，应该为布尔型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.updDate) == false && undefined !== pobjgs_TopicRoleEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_TopicRoleEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TopicRoleEN.updDate)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.updUser) == false && undefined !== pobjgs_TopicRoleEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_TopicRoleEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TopicRoleEN.updUser)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.memo) == false && undefined !== pobjgs_TopicRoleEN.memo && clsString_js_1.tzDataType.isString(pobjgs_TopicRoleEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TopicRoleEN.memo)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        if (null != pobjgs_TopicRoleEN.isDefault && undefined !== pobjgs_TopicRoleEN.isDefault && clsString_js_1.tzDataType.isBoolean(pobjgs_TopicRoleEN.isDefault) === false) {
            throw new Error("(errid:Watl000063)字段[是否默认(isDefault)]的值:[$(pobjgs_TopicRoleEN.isDefault)], 非法，应该为布尔型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TopicRoleEN.topicRoleId) === true) {
            throw new Error("(errid:Watl000064)字段[主题权限Id]不能为空(In 主题权限表)!(clsgs_TopicRoleBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_TopicRoleEN.SetIsCheckProperty(true);
    }
    exports.gs_TopicRole_CheckProperty4Update = gs_TopicRole_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_TopicRole_GetJSONStrByObj(pobjgs_TopicRoleEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_TopicRoleEN.sf_UpdFldSetStr = pobjgs_TopicRoleEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_TopicRoleEN);
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
    exports.gs_TopicRole_GetJSONStrByObj = gs_TopicRole_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_TopicRole_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_TopicRoleObjLst = new Array();
        if (strJSON === "") {
            return arrgs_TopicRoleObjLst;
        }
        try {
            arrgs_TopicRoleObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_TopicRoleObjLst;
        }
        return arrgs_TopicRoleObjLst;
    }
    exports.gs_TopicRole_GetObjLstByJSONStr = gs_TopicRole_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_TopicRoleObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_TopicRole_GetObjLstByJSONObjLst(arrgs_TopicRoleObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_TopicRoleObjLst = new Array();
        for (const objInFor of arrgs_TopicRoleObjLstS) {
            const obj1 = gs_TopicRole_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_TopicRoleObjLst.push(obj1);
        }
        return arrgs_TopicRoleObjLst;
    }
    exports.gs_TopicRole_GetObjLstByJSONObjLst = gs_TopicRole_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_TopicRole_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_TopicRoleEN = new clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN();
        if (strJSON === "") {
            return pobjgs_TopicRoleEN;
        }
        try {
            pobjgs_TopicRoleEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_TopicRoleEN;
        }
        return pobjgs_TopicRoleEN;
    }
    exports.gs_TopicRole_GetObjByJSONStr = gs_TopicRole_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_TopicRole_GetCombineCondition(objgs_TopicRole_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_TopicRoleId) == true) {
            const strComparisonOp_TopicRoleId = objgs_TopicRole_Cond.dicFldComparisonOp[clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_TopicRoleId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_TopicRoleId, objgs_TopicRole_Cond.topicRoleId, strComparisonOp_TopicRoleId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objgs_TopicRole_Cond.dicFldComparisonOp[clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_TopicId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_TopicId, objgs_TopicRole_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuNum) == true) {
            const strComparisonOp_MenuNum = objgs_TopicRole_Cond.dicFldComparisonOp[clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuNum, objgs_TopicRole_Cond.menuNum, strComparisonOp_MenuNum);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuName) == true) {
            const strComparisonOp_MenuName = objgs_TopicRole_Cond.dicFldComparisonOp[clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuName, objgs_TopicRole_Cond.menuName, strComparisonOp_MenuName);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuIsHide) == true) {
            if (objgs_TopicRole_Cond.menuIsHide == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuIsHide);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_MenuIsHide);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_TopicRole_Cond.dicFldComparisonOp[clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_UpdDate, objgs_TopicRole_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_TopicRole_Cond.dicFldComparisonOp[clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_UpdUser, objgs_TopicRole_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_TopicRole_Cond.dicFldComparisonOp[clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_Memo, objgs_TopicRole_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_IsDefault) == true) {
            if (objgs_TopicRole_Cond.isDefault == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_IsDefault);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN.con_IsDefault);
            }
        }
        return strWhereCond;
    }
    exports.gs_TopicRole_GetCombineCondition = gs_TopicRole_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_TopicRole(主题权限表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strTopicRoleId: 主题权限Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_TopicRole_GetUniCondStr_TopicRoleId(objgs_TopicRoleEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and TopicRoleId = '{0}'", objgs_TopicRoleEN.topicRoleId);
        return strWhereCond;
    }
    exports.gs_TopicRole_GetUniCondStr_TopicRoleId = gs_TopicRole_GetUniCondStr_TopicRoleId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_TopicRole(主题权限表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strTopicRoleId: 主题权限Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_TopicRole_GetUniCondStr4Update_TopicRoleId(objgs_TopicRoleEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and TopicRoleId <> '{0}'", objgs_TopicRoleEN.topicRoleId);
        strWhereCond += (0, clsString_js_2.Format)(" and TopicRoleId = '{0}'", objgs_TopicRoleEN.topicRoleId);
        return strWhereCond;
    }
    exports.gs_TopicRole_GetUniCondStr4Update_TopicRoleId = gs_TopicRole_GetUniCondStr4Update_TopicRoleId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_TopicRoleENS:源对象
     * @param objgs_TopicRoleENT:目标对象
    */
    function gs_TopicRole_CopyObjTo(objgs_TopicRoleENS, objgs_TopicRoleENT) {
        objgs_TopicRoleENT.topicRoleId = objgs_TopicRoleENS.topicRoleId; //主题权限Id
        objgs_TopicRoleENT.topicId = objgs_TopicRoleENS.topicId; //主题Id
        objgs_TopicRoleENT.menuNum = objgs_TopicRoleENS.menuNum; //菜单编号
        objgs_TopicRoleENT.menuName = objgs_TopicRoleENS.menuName; //菜单名称
        objgs_TopicRoleENT.menuIsHide = objgs_TopicRoleENS.menuIsHide; //菜单是否隐藏
        objgs_TopicRoleENT.updDate = objgs_TopicRoleENS.updDate; //修改日期
        objgs_TopicRoleENT.updUser = objgs_TopicRoleENS.updUser; //修改人
        objgs_TopicRoleENT.memo = objgs_TopicRoleENS.memo; //备注
        objgs_TopicRoleENT.isDefault = objgs_TopicRoleENS.isDefault; //是否默认
        objgs_TopicRoleENT.sf_UpdFldSetStr = objgs_TopicRoleENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_TopicRole_CopyObjTo = gs_TopicRole_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_TopicRoleENS:源对象
     * @param objgs_TopicRoleENT:目标对象
    */
    function gs_TopicRole_GetObjFromJsonObj(objgs_TopicRoleENS) {
        const objgs_TopicRoleENT = new clsgs_TopicRoleEN_js_1.clsgs_TopicRoleEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TopicRoleENT, objgs_TopicRoleENS);
        return objgs_TopicRoleENT;
    }
    exports.gs_TopicRole_GetObjFromJsonObj = gs_TopicRole_GetObjFromJsonObj;
});