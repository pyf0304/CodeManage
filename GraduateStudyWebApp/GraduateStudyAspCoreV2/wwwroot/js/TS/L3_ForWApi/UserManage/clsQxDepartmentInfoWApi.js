/**
* 类名:clsQxDepartmentInfoWApi
* 表名:QxDepartmentInfo(01120924)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:52:55
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:用户管理(UserManage)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/UserManage/clsQxDepartmentInfoEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.QxDepartmentInfo_GetObjFromJsonObj = exports.QxDepartmentInfo_CopyObjTo = exports.QxDepartmentInfo_GetCombineCondition = exports.QxDepartmentInfo_GetObjByJSONStr = exports.QxDepartmentInfo_GetObjLstByJSONObjLst = exports.QxDepartmentInfo_GetObjLstByJSONStr = exports.QxDepartmentInfo_GetJSONStrByObj = exports.QxDepartmentInfo_CheckProperty4Update = exports.QxDepartmentInfo_CheckPropertyNew = exports.QxDepartmentInfo_BindDdl_DepartmentIdInDiv_Cache = exports.QxDepartmentInfo_ReFreshThisCache = exports.QxDepartmentInfo_ReFreshCache = exports.QxDepartmentInfo_GetWebApiUrl = exports.QxDepartmentInfo_GetMaxStrIdByPrefix = exports.QxDepartmentInfo_GetRecCountByCond_Cache = exports.QxDepartmentInfo_GetRecCountByCondAsync = exports.QxDepartmentInfo_IsExistAsync = exports.QxDepartmentInfo_IsExist_Cache = exports.QxDepartmentInfo_IsExist = exports.QxDepartmentInfo_IsExistRecordAsync = exports.QxDepartmentInfo_IsExistRecord_Cache = exports.QxDepartmentInfo_UpdateWithConditionAsync = exports.QxDepartmentInfo_UpdateRecordAsync = exports.QxDepartmentInfo_AddNewRecordWithReturnKey = exports.QxDepartmentInfo_AddNewRecordWithReturnKeyAsync = exports.QxDepartmentInfo_AddNewRecordWithMaxIdAsync = exports.QxDepartmentInfo_AddNewRecordAsync = exports.QxDepartmentInfo_DelQxDepartmentInfosByCondAsync = exports.QxDepartmentInfo_DelQxDepartmentInfosAsync = exports.QxDepartmentInfo_DelRecordAsync = exports.QxDepartmentInfo_GetObjLstByPagerAsync = exports.QxDepartmentInfo_GetObjLstByPager_Cache = exports.QxDepartmentInfo_GetObjLstByRange = exports.QxDepartmentInfo_GetObjLstByRangeAsync = exports.QxDepartmentInfo_GetTopObjLstAsync = exports.QxDepartmentInfo_GetObjLstByDepartmentIdLst_Cache = exports.QxDepartmentInfo_GetObjLstByDepartmentIdLstAsync = exports.QxDepartmentInfo_GetSubObjLst_Cache = exports.QxDepartmentInfo_GetObjLst_PureCache = exports.QxDepartmentInfo_GetObjLst_Cache = exports.QxDepartmentInfo_GetObjLst_sessionStorage_PureCache = exports.QxDepartmentInfo_GetObjLst_sessionStorage = exports.QxDepartmentInfo_GetObjLstAsync = exports.QxDepartmentInfo_GetObjLst_localStorage_PureCache = exports.QxDepartmentInfo_GetObjLst_localStorage = exports.QxDepartmentInfo_GetObjLst_ClientCache = exports.QxDepartmentInfo_GetFirstObjAsync = exports.QxDepartmentInfo_GetFirstID = exports.QxDepartmentInfo_GetFirstIDAsync = exports.QxDepartmentInfo_funcKey = exports.QxDepartmentInfo_FilterFunByKey = exports.QxDepartmentInfo_SortFunByKey = exports.QxDepartmentInfo_SortFun_Defa_2Fld = exports.QxDepartmentInfo_SortFun_Defa = exports.QxDepartmentInfo_func = exports.QxDepartmentInfo_GetNameByDepartmentId_Cache = exports.QxDepartmentInfo_UpdateObjInLst_Cache = exports.QxDepartmentInfo_GetObjByDepartmentId_localStorage = exports.QxDepartmentInfo_GetObjByDepartmentId_Cache = exports.QxDepartmentInfo_GetObjByDepartmentIdAsync = exports.qxDepartmentInfo_ConstructorName = exports.qxDepartmentInfo_Controller = void 0;
    /**
     * 部门(QxDepartmentInfo)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsQxDepartmentInfoEN_js_1 = require("../../L0_Entity/UserManage/clsQxDepartmentInfoEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.qxDepartmentInfo_Controller = "QxDepartmentInfoApi";
    exports.qxDepartmentInfo_ConstructorName = "qxDepartmentInfo";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strDepartmentId:关键字
    * @returns 对象
    **/
    async function QxDepartmentInfo_GetObjByDepartmentIdAsync(strDepartmentId) {
        const strThisFuncName = "GetObjByDepartmentIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strDepartmentId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strDepartmentId]不能为空！(In clsQxDepartmentInfoWApi.GetObjByDepartmentIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByDepartmentId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strDepartmentId": strDepartmentId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objQxDepartmentInfo = QxDepartmentInfo_GetObjFromJsonObj(returnObj);
                return objQxDepartmentInfo;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_GetObjByDepartmentIdAsync = QxDepartmentInfo_GetObjByDepartmentIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strDepartmentId:所给的关键字
     * @returns 对象
    */
    async function QxDepartmentInfo_GetObjByDepartmentId_Cache(strDepartmentId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByDepartmentId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strDepartmentId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strDepartmentId]不能为空！(In clsQxDepartmentInfoWApi.GetObjByDepartmentId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrQxDepartmentInfoObjLst_Cache = await QxDepartmentInfo_GetObjLst_Cache();
        try {
            const arrQxDepartmentInfo_Sel = arrQxDepartmentInfoObjLst_Cache.filter(x => x.departmentId == strDepartmentId);
            let objQxDepartmentInfo;
            if (arrQxDepartmentInfo_Sel.length > 0) {
                objQxDepartmentInfo = arrQxDepartmentInfo_Sel[0];
                return objQxDepartmentInfo;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objQxDepartmentInfo_Const = await QxDepartmentInfo_GetObjByDepartmentIdAsync(strDepartmentId);
                    if (objQxDepartmentInfo_Const != null) {
                        QxDepartmentInfo_ReFreshThisCache();
                        return objQxDepartmentInfo_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strDepartmentId, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.QxDepartmentInfo_GetObjByDepartmentId_Cache = QxDepartmentInfo_GetObjByDepartmentId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strDepartmentId:所给的关键字
     * @returns 对象
    */
    async function QxDepartmentInfo_GetObjByDepartmentId_localStorage(strDepartmentId) {
        const strThisFuncName = "GetObjByDepartmentId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strDepartmentId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strDepartmentId]不能为空！(In clsQxDepartmentInfoWApi.GetObjByDepartmentId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN._CurrTabName, strDepartmentId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objQxDepartmentInfo_Cache = JSON.parse(strTempObj);
            return objQxDepartmentInfo_Cache;
        }
        try {
            const objQxDepartmentInfo = await QxDepartmentInfo_GetObjByDepartmentIdAsync(strDepartmentId);
            if (objQxDepartmentInfo != null) {
                localStorage.setItem(strKey, JSON.stringify(objQxDepartmentInfo));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objQxDepartmentInfo;
            }
            return objQxDepartmentInfo;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strDepartmentId, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.QxDepartmentInfo_GetObjByDepartmentId_localStorage = QxDepartmentInfo_GetObjByDepartmentId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objQxDepartmentInfo:所给的对象
     * @returns 对象
    */
    async function QxDepartmentInfo_UpdateObjInLst_Cache(objQxDepartmentInfo) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrQxDepartmentInfoObjLst_Cache = await QxDepartmentInfo_GetObjLst_Cache();
            const obj = arrQxDepartmentInfoObjLst_Cache.find(x => x.departmentId == objQxDepartmentInfo.departmentId);
            if (obj != null) {
                objQxDepartmentInfo.departmentId = obj.departmentId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objQxDepartmentInfo);
            }
            else {
                arrQxDepartmentInfoObjLst_Cache.push(objQxDepartmentInfo);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.QxDepartmentInfo_UpdateObjInLst_Cache = QxDepartmentInfo_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strDepartmentId:所给的关键字
     * @returns 对象
    */
    async function QxDepartmentInfo_GetNameByDepartmentId_Cache(strDepartmentId) {
        const strThisFuncName = "GetNameByDepartmentId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strDepartmentId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strDepartmentId]不能为空！(In clsQxDepartmentInfoWApi.GetNameByDepartmentId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrQxDepartmentInfoObjLst_Cache = await QxDepartmentInfo_GetObjLst_Cache();
        if (arrQxDepartmentInfoObjLst_Cache == null)
            return "";
        try {
            const arrQxDepartmentInfo_Sel = arrQxDepartmentInfoObjLst_Cache.filter(x => x.departmentId == strDepartmentId);
            let objQxDepartmentInfo;
            if (arrQxDepartmentInfo_Sel.length > 0) {
                objQxDepartmentInfo = arrQxDepartmentInfo_Sel[0];
                return objQxDepartmentInfo.departmentName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strDepartmentId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.QxDepartmentInfo_GetNameByDepartmentId_Cache = QxDepartmentInfo_GetNameByDepartmentId_Cache;
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
    async function QxDepartmentInfo_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strDepartmentId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objQxDepartmentInfo = await QxDepartmentInfo_GetObjByDepartmentId_Cache(strDepartmentId);
        if (objQxDepartmentInfo == null)
            return "";
        if (objQxDepartmentInfo.GetFldValue(strOutFldName) == null)
            return "";
        return objQxDepartmentInfo.GetFldValue(strOutFldName).toString();
    }
    exports.QxDepartmentInfo_func = QxDepartmentInfo_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function QxDepartmentInfo_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.departmentId.localeCompare(b.departmentId);
    }
    exports.QxDepartmentInfo_SortFun_Defa = QxDepartmentInfo_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function QxDepartmentInfo_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.departmentName == b.departmentName)
            return a.departmentAbbrName.localeCompare(b.departmentAbbrName);
        else
            return a.departmentName.localeCompare(b.departmentName);
    }
    exports.QxDepartmentInfo_SortFun_Defa_2Fld = QxDepartmentInfo_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function QxDepartmentInfo_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentId:
                    return (a, b) => {
                        return a.departmentId.localeCompare(b.departmentId);
                    };
                case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentName:
                    return (a, b) => {
                        return a.departmentName.localeCompare(b.departmentName);
                    };
                case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentAbbrName:
                    return (a, b) => {
                        if (a.departmentAbbrName == null)
                            return -1;
                        if (b.departmentAbbrName == null)
                            return 1;
                        return a.departmentAbbrName.localeCompare(b.departmentAbbrName);
                    };
                case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentTypeId:
                    return (a, b) => {
                        if (a.departmentTypeId == null)
                            return -1;
                        if (b.departmentTypeId == null)
                            return 1;
                        return a.departmentTypeId.localeCompare(b.departmentTypeId);
                    };
                case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_UpDepartmentId:
                    return (a, b) => {
                        if (a.upDepartmentId == null)
                            return -1;
                        if (b.upDepartmentId == null)
                            return 1;
                        return a.upDepartmentId.localeCompare(b.upDepartmentId);
                    };
                case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_InUse:
                    return (a, b) => {
                        if (a.inUse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[QxDepartmentInfo]中不存在！(in ${exports.qxDepartmentInfo_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentId:
                    return (a, b) => {
                        return b.departmentId.localeCompare(a.departmentId);
                    };
                case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentName:
                    return (a, b) => {
                        return b.departmentName.localeCompare(a.departmentName);
                    };
                case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentAbbrName:
                    return (a, b) => {
                        if (b.departmentAbbrName == null)
                            return -1;
                        if (a.departmentAbbrName == null)
                            return 1;
                        return b.departmentAbbrName.localeCompare(a.departmentAbbrName);
                    };
                case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentTypeId:
                    return (a, b) => {
                        if (b.departmentTypeId == null)
                            return -1;
                        if (a.departmentTypeId == null)
                            return 1;
                        return b.departmentTypeId.localeCompare(a.departmentTypeId);
                    };
                case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_UpDepartmentId:
                    return (a, b) => {
                        if (b.upDepartmentId == null)
                            return -1;
                        if (a.upDepartmentId == null)
                            return 1;
                        return b.upDepartmentId.localeCompare(a.upDepartmentId);
                    };
                case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_InUse:
                    return (a, b) => {
                        if (b.inUse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[QxDepartmentInfo]中不存在！(in ${exports.qxDepartmentInfo_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.QxDepartmentInfo_SortFunByKey = QxDepartmentInfo_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function QxDepartmentInfo_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentId:
                return (obj) => {
                    return obj.departmentId === value;
                };
            case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentName:
                return (obj) => {
                    return obj.departmentName === value;
                };
            case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentAbbrName:
                return (obj) => {
                    return obj.departmentAbbrName === value;
                };
            case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentTypeId:
                return (obj) => {
                    return obj.departmentTypeId === value;
                };
            case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_UpDepartmentId:
                return (obj) => {
                    return obj.upDepartmentId === value;
                };
            case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_InUse:
                return (obj) => {
                    return obj.inUse === value;
                };
            case clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[QxDepartmentInfo]中不存在！(in ${exports.qxDepartmentInfo_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.QxDepartmentInfo_FilterFunByKey = QxDepartmentInfo_FilterFunByKey;
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
    async function QxDepartmentInfo_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrQxDepartmentInfo = await QxDepartmentInfo_GetObjLst_Cache();
        if (arrQxDepartmentInfo == null)
            return [];
        let arrQxDepartmentInfo_Sel = arrQxDepartmentInfo;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrQxDepartmentInfo_Sel.length == 0)
            return [];
        return arrQxDepartmentInfo_Sel.map(x => x.departmentId);
    }
    exports.QxDepartmentInfo_funcKey = QxDepartmentInfo_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function QxDepartmentInfo_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_GetFirstIDAsync = QxDepartmentInfo_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function QxDepartmentInfo_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_GetFirstID = QxDepartmentInfo_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function QxDepartmentInfo_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
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
                const objQxDepartmentInfo = QxDepartmentInfo_GetObjFromJsonObj(returnObj);
                return objQxDepartmentInfo;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_GetFirstObjAsync = QxDepartmentInfo_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QxDepartmentInfo_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrQxDepartmentInfoExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrQxDepartmentInfoObjLst_T = QxDepartmentInfo_GetObjLstByJSONObjLst(arrQxDepartmentInfoExObjLst_Cache);
            return arrQxDepartmentInfoObjLst_T;
        }
        try {
            const arrQxDepartmentInfoExObjLst = await QxDepartmentInfo_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrQxDepartmentInfoExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQxDepartmentInfoExObjLst.length);
            console.log(strInfo);
            return arrQxDepartmentInfoExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.QxDepartmentInfo_GetObjLst_ClientCache = QxDepartmentInfo_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QxDepartmentInfo_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrQxDepartmentInfoExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrQxDepartmentInfoObjLst_T = QxDepartmentInfo_GetObjLstByJSONObjLst(arrQxDepartmentInfoExObjLst_Cache);
            return arrQxDepartmentInfoObjLst_T;
        }
        try {
            const arrQxDepartmentInfoExObjLst = await QxDepartmentInfo_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrQxDepartmentInfoExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQxDepartmentInfoExObjLst.length);
            console.log(strInfo);
            return arrQxDepartmentInfoExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.QxDepartmentInfo_GetObjLst_localStorage = QxDepartmentInfo_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QxDepartmentInfo_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrQxDepartmentInfoObjLst_Cache = JSON.parse(strTempObjLst);
            return arrQxDepartmentInfoObjLst_Cache;
        }
        else
            return null;
    }
    exports.QxDepartmentInfo_GetObjLst_localStorage_PureCache = QxDepartmentInfo_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function QxDepartmentInfo_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = QxDepartmentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_GetObjLstAsync = QxDepartmentInfo_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QxDepartmentInfo_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrQxDepartmentInfoExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrQxDepartmentInfoObjLst_T = QxDepartmentInfo_GetObjLstByJSONObjLst(arrQxDepartmentInfoExObjLst_Cache);
            return arrQxDepartmentInfoObjLst_T;
        }
        try {
            const arrQxDepartmentInfoExObjLst = await QxDepartmentInfo_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrQxDepartmentInfoExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQxDepartmentInfoExObjLst.length);
            console.log(strInfo);
            return arrQxDepartmentInfoExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.QxDepartmentInfo_GetObjLst_sessionStorage = QxDepartmentInfo_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QxDepartmentInfo_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrQxDepartmentInfoObjLst_Cache = JSON.parse(strTempObjLst);
            return arrQxDepartmentInfoObjLst_Cache;
        }
        else
            return null;
    }
    exports.QxDepartmentInfo_GetObjLst_sessionStorage_PureCache = QxDepartmentInfo_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QxDepartmentInfo_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrQxDepartmentInfoObjLst_Cache;
        switch (clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.CacheModeId) {
            case "04": //sessionStorage
                arrQxDepartmentInfoObjLst_Cache = await QxDepartmentInfo_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrQxDepartmentInfoObjLst_Cache = await QxDepartmentInfo_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrQxDepartmentInfoObjLst_Cache = await QxDepartmentInfo_GetObjLst_ClientCache();
                break;
            default:
                arrQxDepartmentInfoObjLst_Cache = await QxDepartmentInfo_GetObjLst_ClientCache();
                break;
        }
        const arrQxDepartmentInfoObjLst = QxDepartmentInfo_GetObjLstByJSONObjLst(arrQxDepartmentInfoObjLst_Cache);
        return arrQxDepartmentInfoObjLst_Cache;
    }
    exports.QxDepartmentInfo_GetObjLst_Cache = QxDepartmentInfo_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QxDepartmentInfo_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrQxDepartmentInfoObjLst_Cache;
        switch (clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.CacheModeId) {
            case "04": //sessionStorage
                arrQxDepartmentInfoObjLst_Cache = await QxDepartmentInfo_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrQxDepartmentInfoObjLst_Cache = await QxDepartmentInfo_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrQxDepartmentInfoObjLst_Cache = null;
                break;
            default:
                arrQxDepartmentInfoObjLst_Cache = null;
                break;
        }
        return arrQxDepartmentInfoObjLst_Cache;
    }
    exports.QxDepartmentInfo_GetObjLst_PureCache = QxDepartmentInfo_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrDepartmentId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function QxDepartmentInfo_GetSubObjLst_Cache(objQxDepartmentInfo_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrQxDepartmentInfoObjLst_Cache = await QxDepartmentInfo_GetObjLst_Cache();
        let arrQxDepartmentInfo_Sel = arrQxDepartmentInfoObjLst_Cache;
        if (objQxDepartmentInfo_Cond.sf_FldComparisonOp == null || objQxDepartmentInfo_Cond.sf_FldComparisonOp == "")
            return arrQxDepartmentInfo_Sel;
        const dicFldComparisonOp = JSON.parse(objQxDepartmentInfo_Cond.sf_FldComparisonOp);
        //console.log("clsQxDepartmentInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objQxDepartmentInfo_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQxDepartmentInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrQxDepartmentInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objQxDepartmentInfo_Cond), exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.QxDepartmentInfo_GetSubObjLst_Cache = QxDepartmentInfo_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrDepartmentId:关键字列表
    * @returns 对象列表
    **/
    async function QxDepartmentInfo_GetObjLstByDepartmentIdLstAsync(arrDepartmentId) {
        const strThisFuncName = "GetObjLstByDepartmentIdLstAsync";
        const strAction = "GetObjLstByDepartmentIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrDepartmentId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = QxDepartmentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_GetObjLstByDepartmentIdLstAsync = QxDepartmentInfo_GetObjLstByDepartmentIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrDepartmentIdLst:关键字列表
     * @returns 对象列表
    */
    async function QxDepartmentInfo_GetObjLstByDepartmentIdLst_Cache(arrDepartmentIdLst) {
        const strThisFuncName = "GetObjLstByDepartmentIdLst_Cache";
        try {
            const arrQxDepartmentInfoObjLst_Cache = await QxDepartmentInfo_GetObjLst_Cache();
            const arrQxDepartmentInfo_Sel = arrQxDepartmentInfoObjLst_Cache.filter(x => arrDepartmentIdLst.indexOf(x.departmentId) > -1);
            return arrQxDepartmentInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrDepartmentIdLst.join(","), exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.QxDepartmentInfo_GetObjLstByDepartmentIdLst_Cache = QxDepartmentInfo_GetObjLstByDepartmentIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function QxDepartmentInfo_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = QxDepartmentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_GetTopObjLstAsync = QxDepartmentInfo_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function QxDepartmentInfo_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = QxDepartmentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_GetObjLstByRangeAsync = QxDepartmentInfo_GetObjLstByRangeAsync;
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
    async function QxDepartmentInfo_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_GetObjLstByRange = QxDepartmentInfo_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function QxDepartmentInfo_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrQxDepartmentInfoObjLst_Cache = await QxDepartmentInfo_GetObjLst_Cache();
        if (arrQxDepartmentInfoObjLst_Cache.length == 0)
            return arrQxDepartmentInfoObjLst_Cache;
        let arrQxDepartmentInfo_Sel = arrQxDepartmentInfoObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objQxDepartmentInfo_Cond = new clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objQxDepartmentInfo_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsQxDepartmentInfoWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQxDepartmentInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrQxDepartmentInfo_Sel.length == 0)
                return arrQxDepartmentInfo_Sel;
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
                arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.sort(QxDepartmentInfo_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.sort(objPagerPara.sortFun);
            }
            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.slice(intStart, intEnd);
            return arrQxDepartmentInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.QxDepartmentInfo_GetObjLstByPager_Cache = QxDepartmentInfo_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function QxDepartmentInfo_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = QxDepartmentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_GetObjLstByPagerAsync = QxDepartmentInfo_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strDepartmentId:关键字
    * @returns 获取删除的结果
    **/
    async function QxDepartmentInfo_DelRecordAsync(strDepartmentId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strDepartmentId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_DelRecordAsync = QxDepartmentInfo_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrDepartmentId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function QxDepartmentInfo_DelQxDepartmentInfosAsync(arrDepartmentId) {
        const strThisFuncName = "DelQxDepartmentInfosAsync";
        const strAction = "DelQxDepartmentInfos";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrDepartmentId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_DelQxDepartmentInfosAsync = QxDepartmentInfo_DelQxDepartmentInfosAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function QxDepartmentInfo_DelQxDepartmentInfosByCondAsync(strWhereCond) {
        const strThisFuncName = "DelQxDepartmentInfosByCondAsync";
        const strAction = "DelQxDepartmentInfosByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_DelQxDepartmentInfosByCondAsync = QxDepartmentInfo_DelQxDepartmentInfosByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objQxDepartmentInfoEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function QxDepartmentInfo_AddNewRecordAsync(objQxDepartmentInfoEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objQxDepartmentInfoEN.departmentId === null || objQxDepartmentInfoEN.departmentId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objQxDepartmentInfoEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQxDepartmentInfoEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_AddNewRecordAsync = QxDepartmentInfo_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objQxDepartmentInfoEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function QxDepartmentInfo_AddNewRecordWithMaxIdAsync(objQxDepartmentInfoEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQxDepartmentInfoEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_AddNewRecordWithMaxIdAsync = QxDepartmentInfo_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objQxDepartmentInfoEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function QxDepartmentInfo_AddNewRecordWithReturnKeyAsync(objQxDepartmentInfoEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQxDepartmentInfoEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_AddNewRecordWithReturnKeyAsync = QxDepartmentInfo_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objQxDepartmentInfoEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function QxDepartmentInfo_AddNewRecordWithReturnKey(objQxDepartmentInfoEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objQxDepartmentInfoEN.departmentId === null || objQxDepartmentInfoEN.departmentId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQxDepartmentInfoEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_AddNewRecordWithReturnKey = QxDepartmentInfo_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objQxDepartmentInfoEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function QxDepartmentInfo_UpdateRecordAsync(objQxDepartmentInfoEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objQxDepartmentInfoEN.sf_UpdFldSetStr === undefined || objQxDepartmentInfoEN.sf_UpdFldSetStr === null || objQxDepartmentInfoEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objQxDepartmentInfoEN.departmentId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQxDepartmentInfoEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_UpdateRecordAsync = QxDepartmentInfo_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objQxDepartmentInfoEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function QxDepartmentInfo_UpdateWithConditionAsync(objQxDepartmentInfoEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objQxDepartmentInfoEN.sf_UpdFldSetStr === undefined || objQxDepartmentInfoEN.sf_UpdFldSetStr === null || objQxDepartmentInfoEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objQxDepartmentInfoEN.departmentId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
        objQxDepartmentInfoEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objQxDepartmentInfoEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_UpdateWithConditionAsync = QxDepartmentInfo_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrDepartmentId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function QxDepartmentInfo_IsExistRecord_Cache(objQxDepartmentInfo_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrQxDepartmentInfoObjLst_Cache = await QxDepartmentInfo_GetObjLst_Cache();
        if (arrQxDepartmentInfoObjLst_Cache == null)
            return false;
        let arrQxDepartmentInfo_Sel = arrQxDepartmentInfoObjLst_Cache;
        if (objQxDepartmentInfo_Cond.sf_FldComparisonOp == null || objQxDepartmentInfo_Cond.sf_FldComparisonOp == "")
            return arrQxDepartmentInfo_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objQxDepartmentInfo_Cond.sf_FldComparisonOp);
        //console.log("clsQxDepartmentInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objQxDepartmentInfo_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQxDepartmentInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrQxDepartmentInfo_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objQxDepartmentInfo_Cond), exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.QxDepartmentInfo_IsExistRecord_Cache = QxDepartmentInfo_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function QxDepartmentInfo_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_IsExistRecordAsync = QxDepartmentInfo_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strDepartmentId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function QxDepartmentInfo_IsExist(strDepartmentId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "DepartmentId": strDepartmentId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_IsExist = QxDepartmentInfo_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strDepartmentId:所给的关键字
     * @returns 对象
    */
    async function QxDepartmentInfo_IsExist_Cache(strDepartmentId) {
        const strThisFuncName = "IsExist_Cache";
        const arrQxDepartmentInfoObjLst_Cache = await QxDepartmentInfo_GetObjLst_Cache();
        if (arrQxDepartmentInfoObjLst_Cache == null)
            return false;
        try {
            const arrQxDepartmentInfo_Sel = arrQxDepartmentInfoObjLst_Cache.filter(x => x.departmentId == strDepartmentId);
            if (arrQxDepartmentInfo_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strDepartmentId, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.QxDepartmentInfo_IsExist_Cache = QxDepartmentInfo_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strDepartmentId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function QxDepartmentInfo_IsExistAsync(strDepartmentId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strDepartmentId": strDepartmentId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_IsExistAsync = QxDepartmentInfo_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function QxDepartmentInfo_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_GetRecCountByCondAsync = QxDepartmentInfo_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objQxDepartmentInfo_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function QxDepartmentInfo_GetRecCountByCond_Cache(objQxDepartmentInfo_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrQxDepartmentInfoObjLst_Cache = await QxDepartmentInfo_GetObjLst_Cache();
        if (arrQxDepartmentInfoObjLst_Cache == null)
            return 0;
        let arrQxDepartmentInfo_Sel = arrQxDepartmentInfoObjLst_Cache;
        if (objQxDepartmentInfo_Cond.sf_FldComparisonOp == null || objQxDepartmentInfo_Cond.sf_FldComparisonOp == "")
            return arrQxDepartmentInfo_Sel.length;
        const dicFldComparisonOp = JSON.parse(objQxDepartmentInfo_Cond.sf_FldComparisonOp);
        //console.log("clsQxDepartmentInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objQxDepartmentInfo_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQxDepartmentInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQxDepartmentInfo_Sel = arrQxDepartmentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrQxDepartmentInfo_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objQxDepartmentInfo_Cond), exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.QxDepartmentInfo_GetRecCountByCond_Cache = QxDepartmentInfo_GetRecCountByCond_Cache;
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
    async function QxDepartmentInfo_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxDepartmentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxDepartmentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxDepartmentInfo_GetMaxStrIdByPrefix = QxDepartmentInfo_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function QxDepartmentInfo_GetWebApiUrl(strController, strAction) {
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
    exports.QxDepartmentInfo_GetWebApiUrl = QxDepartmentInfo_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function QxDepartmentInfo_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN._CurrTabName;
        switch (clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.CacheModeId) {
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
    exports.QxDepartmentInfo_ReFreshCache = QxDepartmentInfo_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function QxDepartmentInfo_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN._CurrTabName;
            switch (clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.CacheModeId) {
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
    exports.QxDepartmentInfo_ReFreshThisCache = QxDepartmentInfo_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function QxDepartmentInfo_BindDdl_DepartmentIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_DepartmentIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_DepartmentIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_DepartmentIdInDiv_Cache");
        const arrObjLst_Sel = await QxDepartmentInfo_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentId, clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentName, "部门");
    }
    exports.QxDepartmentInfo_BindDdl_DepartmentIdInDiv_Cache = QxDepartmentInfo_BindDdl_DepartmentIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function QxDepartmentInfo_CheckPropertyNew(pobjQxDepartmentInfoEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentName) === true) {
            throw new Error("(errid:Watl000058)字段[部门名称]不能为空(In 部门)!(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentId) == false && (0, clsString_js_2.GetStrLen)(pobjQxDepartmentInfoEN.departmentId) > 8) {
            throw new Error("(errid:Watl000059)字段[部门Id(departmentId)]的长度不能超过8(In 部门(QxDepartmentInfo))!值:$(pobjQxDepartmentInfoEN.departmentId)(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentName) == false && (0, clsString_js_2.GetStrLen)(pobjQxDepartmentInfoEN.departmentName) > 100) {
            throw new Error("(errid:Watl000059)字段[部门名称(departmentName)]的长度不能超过100(In 部门(QxDepartmentInfo))!值:$(pobjQxDepartmentInfoEN.departmentName)(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentAbbrName) == false && (0, clsString_js_2.GetStrLen)(pobjQxDepartmentInfoEN.departmentAbbrName) > 12) {
            throw new Error("(errid:Watl000059)字段[DepartmentAbbrName(departmentAbbrName)]的长度不能超过12(In 部门(QxDepartmentInfo))!值:$(pobjQxDepartmentInfoEN.departmentAbbrName)(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQxDepartmentInfoEN.departmentTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[DepartmentTypeId(departmentTypeId)]的长度不能超过2(In 部门(QxDepartmentInfo))!值:$(pobjQxDepartmentInfoEN.departmentTypeId)(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.upDepartmentId) == false && (0, clsString_js_2.GetStrLen)(pobjQxDepartmentInfoEN.upDepartmentId) > 6) {
            throw new Error("(errid:Watl000059)字段[UpDepartmentId(upDepartmentId)]的长度不能超过6(In 部门(QxDepartmentInfo))!值:$(pobjQxDepartmentInfoEN.upDepartmentId)(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjQxDepartmentInfoEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 部门(QxDepartmentInfo))!值:$(pobjQxDepartmentInfoEN.memo)(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentId) == false && undefined !== pobjQxDepartmentInfoEN.departmentId && clsString_js_1.tzDataType.isString(pobjQxDepartmentInfoEN.departmentId) === false) {
            throw new Error("(errid:Watl000060)字段[部门Id(departmentId)]的值:[$(pobjQxDepartmentInfoEN.departmentId)], 非法，应该为字符型(In 部门(QxDepartmentInfo))!(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentName) == false && undefined !== pobjQxDepartmentInfoEN.departmentName && clsString_js_1.tzDataType.isString(pobjQxDepartmentInfoEN.departmentName) === false) {
            throw new Error("(errid:Watl000060)字段[部门名称(departmentName)]的值:[$(pobjQxDepartmentInfoEN.departmentName)], 非法，应该为字符型(In 部门(QxDepartmentInfo))!(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentAbbrName) == false && undefined !== pobjQxDepartmentInfoEN.departmentAbbrName && clsString_js_1.tzDataType.isString(pobjQxDepartmentInfoEN.departmentAbbrName) === false) {
            throw new Error("(errid:Watl000060)字段[DepartmentAbbrName(departmentAbbrName)]的值:[$(pobjQxDepartmentInfoEN.departmentAbbrName)], 非法，应该为字符型(In 部门(QxDepartmentInfo))!(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentTypeId) == false && undefined !== pobjQxDepartmentInfoEN.departmentTypeId && clsString_js_1.tzDataType.isString(pobjQxDepartmentInfoEN.departmentTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[DepartmentTypeId(departmentTypeId)]的值:[$(pobjQxDepartmentInfoEN.departmentTypeId)], 非法，应该为字符型(In 部门(QxDepartmentInfo))!(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.upDepartmentId) == false && undefined !== pobjQxDepartmentInfoEN.upDepartmentId && clsString_js_1.tzDataType.isString(pobjQxDepartmentInfoEN.upDepartmentId) === false) {
            throw new Error("(errid:Watl000060)字段[UpDepartmentId(upDepartmentId)]的值:[$(pobjQxDepartmentInfoEN.upDepartmentId)], 非法，应该为字符型(In 部门(QxDepartmentInfo))!(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        if (null != pobjQxDepartmentInfoEN.orderNum && undefined !== pobjQxDepartmentInfoEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjQxDepartmentInfoEN.orderNum) === false) {
            throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjQxDepartmentInfoEN.orderNum)], 非法，应该为数值型(In 部门(QxDepartmentInfo))!(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        if (null != pobjQxDepartmentInfoEN.inUse && undefined !== pobjQxDepartmentInfoEN.inUse && clsString_js_1.tzDataType.isBoolean(pobjQxDepartmentInfoEN.inUse) === false) {
            throw new Error("(errid:Watl000060)字段[是否在用(inUse)]的值:[$(pobjQxDepartmentInfoEN.inUse)], 非法，应该为布尔型(In 部门(QxDepartmentInfo))!(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.memo) == false && undefined !== pobjQxDepartmentInfoEN.memo && clsString_js_1.tzDataType.isString(pobjQxDepartmentInfoEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjQxDepartmentInfoEN.memo)], 非法，应该为字符型(In 部门(QxDepartmentInfo))!(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQxDepartmentInfoEN.departmentTypeId) != 2) {
            throw ("(errid:Watl000061)字段[DepartmentTypeId]作为外键字段,长度应该为2(In 部门)!(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjQxDepartmentInfoEN.SetIsCheckProperty(true);
    }
    exports.QxDepartmentInfo_CheckPropertyNew = QxDepartmentInfo_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function QxDepartmentInfo_CheckProperty4Update(pobjQxDepartmentInfoEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentId) == false && (0, clsString_js_2.GetStrLen)(pobjQxDepartmentInfoEN.departmentId) > 8) {
            throw new Error("(errid:Watl000062)字段[部门Id(departmentId)]的长度不能超过8(In 部门(QxDepartmentInfo))!值:$(pobjQxDepartmentInfoEN.departmentId)(clsQxDepartmentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentName) == false && (0, clsString_js_2.GetStrLen)(pobjQxDepartmentInfoEN.departmentName) > 100) {
            throw new Error("(errid:Watl000062)字段[部门名称(departmentName)]的长度不能超过100(In 部门(QxDepartmentInfo))!值:$(pobjQxDepartmentInfoEN.departmentName)(clsQxDepartmentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentAbbrName) == false && (0, clsString_js_2.GetStrLen)(pobjQxDepartmentInfoEN.departmentAbbrName) > 12) {
            throw new Error("(errid:Watl000062)字段[DepartmentAbbrName(departmentAbbrName)]的长度不能超过12(In 部门(QxDepartmentInfo))!值:$(pobjQxDepartmentInfoEN.departmentAbbrName)(clsQxDepartmentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQxDepartmentInfoEN.departmentTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[DepartmentTypeId(departmentTypeId)]的长度不能超过2(In 部门(QxDepartmentInfo))!值:$(pobjQxDepartmentInfoEN.departmentTypeId)(clsQxDepartmentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.upDepartmentId) == false && (0, clsString_js_2.GetStrLen)(pobjQxDepartmentInfoEN.upDepartmentId) > 6) {
            throw new Error("(errid:Watl000062)字段[UpDepartmentId(upDepartmentId)]的长度不能超过6(In 部门(QxDepartmentInfo))!值:$(pobjQxDepartmentInfoEN.upDepartmentId)(clsQxDepartmentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjQxDepartmentInfoEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 部门(QxDepartmentInfo))!值:$(pobjQxDepartmentInfoEN.memo)(clsQxDepartmentInfoBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentId) == false && undefined !== pobjQxDepartmentInfoEN.departmentId && clsString_js_1.tzDataType.isString(pobjQxDepartmentInfoEN.departmentId) === false) {
            throw new Error("(errid:Watl000063)字段[部门Id(departmentId)]的值:[$(pobjQxDepartmentInfoEN.departmentId)], 非法，应该为字符型(In 部门(QxDepartmentInfo))!(clsQxDepartmentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentName) == false && undefined !== pobjQxDepartmentInfoEN.departmentName && clsString_js_1.tzDataType.isString(pobjQxDepartmentInfoEN.departmentName) === false) {
            throw new Error("(errid:Watl000063)字段[部门名称(departmentName)]的值:[$(pobjQxDepartmentInfoEN.departmentName)], 非法，应该为字符型(In 部门(QxDepartmentInfo))!(clsQxDepartmentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentAbbrName) == false && undefined !== pobjQxDepartmentInfoEN.departmentAbbrName && clsString_js_1.tzDataType.isString(pobjQxDepartmentInfoEN.departmentAbbrName) === false) {
            throw new Error("(errid:Watl000063)字段[DepartmentAbbrName(departmentAbbrName)]的值:[$(pobjQxDepartmentInfoEN.departmentAbbrName)], 非法，应该为字符型(In 部门(QxDepartmentInfo))!(clsQxDepartmentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentTypeId) == false && undefined !== pobjQxDepartmentInfoEN.departmentTypeId && clsString_js_1.tzDataType.isString(pobjQxDepartmentInfoEN.departmentTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[DepartmentTypeId(departmentTypeId)]的值:[$(pobjQxDepartmentInfoEN.departmentTypeId)], 非法，应该为字符型(In 部门(QxDepartmentInfo))!(clsQxDepartmentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.upDepartmentId) == false && undefined !== pobjQxDepartmentInfoEN.upDepartmentId && clsString_js_1.tzDataType.isString(pobjQxDepartmentInfoEN.upDepartmentId) === false) {
            throw new Error("(errid:Watl000063)字段[UpDepartmentId(upDepartmentId)]的值:[$(pobjQxDepartmentInfoEN.upDepartmentId)], 非法，应该为字符型(In 部门(QxDepartmentInfo))!(clsQxDepartmentInfoBL:CheckProperty4Update)");
        }
        if (null != pobjQxDepartmentInfoEN.orderNum && undefined !== pobjQxDepartmentInfoEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjQxDepartmentInfoEN.orderNum) === false) {
            throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjQxDepartmentInfoEN.orderNum)], 非法，应该为数值型(In 部门(QxDepartmentInfo))!(clsQxDepartmentInfoBL:CheckProperty4Update)");
        }
        if (null != pobjQxDepartmentInfoEN.inUse && undefined !== pobjQxDepartmentInfoEN.inUse && clsString_js_1.tzDataType.isBoolean(pobjQxDepartmentInfoEN.inUse) === false) {
            throw new Error("(errid:Watl000063)字段[是否在用(inUse)]的值:[$(pobjQxDepartmentInfoEN.inUse)], 非法，应该为布尔型(In 部门(QxDepartmentInfo))!(clsQxDepartmentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.memo) == false && undefined !== pobjQxDepartmentInfoEN.memo && clsString_js_1.tzDataType.isString(pobjQxDepartmentInfoEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjQxDepartmentInfoEN.memo)], 非法，应该为字符型(In 部门(QxDepartmentInfo))!(clsQxDepartmentInfoBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentId) === true
            || pobjQxDepartmentInfoEN.departmentId.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[部门Id]不能为空(In 部门)!(clsQxDepartmentInfoBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxDepartmentInfoEN.departmentTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQxDepartmentInfoEN.departmentTypeId) != 2) {
            throw ("(errid:Watl000065)字段[DepartmentTypeId]作为外键字段,长度应该为2(In 部门)!(clsQxDepartmentInfoBL:CheckPropertyNew)");
        }
        pobjQxDepartmentInfoEN.SetIsCheckProperty(true);
    }
    exports.QxDepartmentInfo_CheckProperty4Update = QxDepartmentInfo_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function QxDepartmentInfo_GetJSONStrByObj(pobjQxDepartmentInfoEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjQxDepartmentInfoEN.sf_UpdFldSetStr = pobjQxDepartmentInfoEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjQxDepartmentInfoEN);
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
    exports.QxDepartmentInfo_GetJSONStrByObj = QxDepartmentInfo_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function QxDepartmentInfo_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrQxDepartmentInfoObjLst = new Array();
        if (strJSON === "") {
            return arrQxDepartmentInfoObjLst;
        }
        try {
            arrQxDepartmentInfoObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrQxDepartmentInfoObjLst;
        }
        return arrQxDepartmentInfoObjLst;
    }
    exports.QxDepartmentInfo_GetObjLstByJSONStr = QxDepartmentInfo_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrQxDepartmentInfoObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function QxDepartmentInfo_GetObjLstByJSONObjLst(arrQxDepartmentInfoObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrQxDepartmentInfoObjLst = new Array();
        for (const objInFor of arrQxDepartmentInfoObjLstS) {
            const obj1 = QxDepartmentInfo_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrQxDepartmentInfoObjLst.push(obj1);
        }
        return arrQxDepartmentInfoObjLst;
    }
    exports.QxDepartmentInfo_GetObjLstByJSONObjLst = QxDepartmentInfo_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function QxDepartmentInfo_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjQxDepartmentInfoEN = new clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN();
        if (strJSON === "") {
            return pobjQxDepartmentInfoEN;
        }
        try {
            pobjQxDepartmentInfoEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjQxDepartmentInfoEN;
        }
        return pobjQxDepartmentInfoEN;
    }
    exports.QxDepartmentInfo_GetObjByJSONStr = QxDepartmentInfo_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function QxDepartmentInfo_GetCombineCondition(objQxDepartmentInfo_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objQxDepartmentInfo_Cond.dicFldComparisonOp, clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentId) == true) {
            const strComparisonOp_DepartmentId = objQxDepartmentInfo_Cond.dicFldComparisonOp[clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentId, objQxDepartmentInfo_Cond.departmentId, strComparisonOp_DepartmentId);
        }
        if (Object.prototype.hasOwnProperty.call(objQxDepartmentInfo_Cond.dicFldComparisonOp, clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentName) == true) {
            const strComparisonOp_DepartmentName = objQxDepartmentInfo_Cond.dicFldComparisonOp[clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentName, objQxDepartmentInfo_Cond.departmentName, strComparisonOp_DepartmentName);
        }
        if (Object.prototype.hasOwnProperty.call(objQxDepartmentInfo_Cond.dicFldComparisonOp, clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentAbbrName) == true) {
            const strComparisonOp_DepartmentAbbrName = objQxDepartmentInfo_Cond.dicFldComparisonOp[clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentAbbrName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentAbbrName, objQxDepartmentInfo_Cond.departmentAbbrName, strComparisonOp_DepartmentAbbrName);
        }
        if (Object.prototype.hasOwnProperty.call(objQxDepartmentInfo_Cond.dicFldComparisonOp, clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentTypeId) == true) {
            const strComparisonOp_DepartmentTypeId = objQxDepartmentInfo_Cond.dicFldComparisonOp[clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_DepartmentTypeId, objQxDepartmentInfo_Cond.departmentTypeId, strComparisonOp_DepartmentTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objQxDepartmentInfo_Cond.dicFldComparisonOp, clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_UpDepartmentId) == true) {
            const strComparisonOp_UpDepartmentId = objQxDepartmentInfo_Cond.dicFldComparisonOp[clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_UpDepartmentId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_UpDepartmentId, objQxDepartmentInfo_Cond.upDepartmentId, strComparisonOp_UpDepartmentId);
        }
        if (Object.prototype.hasOwnProperty.call(objQxDepartmentInfo_Cond.dicFldComparisonOp, clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objQxDepartmentInfo_Cond.dicFldComparisonOp[clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_OrderNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_OrderNum, objQxDepartmentInfo_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objQxDepartmentInfo_Cond.dicFldComparisonOp, clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_InUse) == true) {
            if (objQxDepartmentInfo_Cond.inUse == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_InUse);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_InUse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objQxDepartmentInfo_Cond.dicFldComparisonOp, clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_Memo) == true) {
            const strComparisonOp_Memo = objQxDepartmentInfo_Cond.dicFldComparisonOp[clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN.con_Memo, objQxDepartmentInfo_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.QxDepartmentInfo_GetCombineCondition = QxDepartmentInfo_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objQxDepartmentInfoENS:源对象
     * @param objQxDepartmentInfoENT:目标对象
    */
    function QxDepartmentInfo_CopyObjTo(objQxDepartmentInfoENS, objQxDepartmentInfoENT) {
        objQxDepartmentInfoENT.departmentId = objQxDepartmentInfoENS.departmentId; //部门Id
        objQxDepartmentInfoENT.departmentName = objQxDepartmentInfoENS.departmentName; //部门名称
        objQxDepartmentInfoENT.departmentAbbrName = objQxDepartmentInfoENS.departmentAbbrName; //DepartmentAbbrName
        objQxDepartmentInfoENT.departmentTypeId = objQxDepartmentInfoENS.departmentTypeId; //DepartmentTypeId
        objQxDepartmentInfoENT.upDepartmentId = objQxDepartmentInfoENS.upDepartmentId; //UpDepartmentId
        objQxDepartmentInfoENT.orderNum = objQxDepartmentInfoENS.orderNum; //序号
        objQxDepartmentInfoENT.inUse = objQxDepartmentInfoENS.inUse; //是否在用
        objQxDepartmentInfoENT.memo = objQxDepartmentInfoENS.memo; //备注
        objQxDepartmentInfoENT.sf_UpdFldSetStr = objQxDepartmentInfoENS.updFldString; //sf_UpdFldSetStr
    }
    exports.QxDepartmentInfo_CopyObjTo = QxDepartmentInfo_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objQxDepartmentInfoENS:源对象
     * @param objQxDepartmentInfoENT:目标对象
    */
    function QxDepartmentInfo_GetObjFromJsonObj(objQxDepartmentInfoENS) {
        const objQxDepartmentInfoENT = new clsQxDepartmentInfoEN_js_1.clsQxDepartmentInfoEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objQxDepartmentInfoENT, objQxDepartmentInfoENS);
        return objQxDepartmentInfoENT;
    }
    exports.QxDepartmentInfo_GetObjFromJsonObj = QxDepartmentInfo_GetObjFromJsonObj;
});
