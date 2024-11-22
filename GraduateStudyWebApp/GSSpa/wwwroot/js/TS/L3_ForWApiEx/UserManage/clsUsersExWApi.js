/*-- -- -- -- -- -- -- -- -- -- --
类名:clsUsersExWApi
表名:Users(01120034)
生成代码版本:2019.12.06.1
生成日期:2019/12/19 01:38:30
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:用户管理
模块英文名:UserManage
框架-层名:WA_访问层(WA_Access)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == ==
*/
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    var desc = Object.getOwnPropertyDescriptor(m, k);
    if (!desc || ("get" in desc ? !m.__esModule : desc.writable || desc.configurable)) {
      desc = { enumerable: true, get: function() { return m[k]; } };
    }
    Object.defineProperty(o, k2, desc);
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "jquery", "../../L0_Entity/UserManage/clsUsersEN.js", "../../PubFun/stuPagerPara.js", "../../PubFun/stuRangePara.js", "../../PubFun/stuTopPara.js", "../../PubFun/tzDictionary.js", "../../L0_Entity/UserManage/clsUsersENEx.js", "../../L3_ForWApi/UserManage/clsUsersWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.UsersEx_GetMaxStrIdByPrefix = exports.UsersEx_GetMaxStrIdByPrefixAsync = exports.UsersEx_GetMaxStrId = exports.UsersEx_GetMaxStrIdAsync = exports.UsersEx_GetRecCountByCond = exports.UsersEx_GetRecCountByCondAsync = exports.UsersEx_IsExist = exports.UsersEx_IsExistAsync = exports.UsersEx_IsExistRecord = exports.UsersEx_IsExistRecordAsync = exports.UsersEx_UpdateRecordWithCondition = exports.UsersEx_UpdateRecordWithConditionAsync = exports.UsersEx_UpdateRecord = exports.UsersEx_UpdateRecordAsync = exports.UsersEx_AddNewRecordWithReturnKey = exports.UsersEx_AddNewRecordWithReturnKeyAsync = exports.UsersEx_AddNewRecord = exports.UsersEx_AddNewRecordAsync = exports.UsersEx_DelUserssByCond = exports.UsersEx_DelUserssByCondAsync = exports.UsersEx_DelUserss = exports.UsersEx_DelUserssAsync = exports.UsersEx_DelRecord = exports.UsersEx_DelRecordAsync = exports.UsersEx_GetObjLstByPager = exports.UsersEx_GetObjLstByPagerAsync = exports.UsersEx_GetObjLstByRange = exports.UsersEx_GetObjLstByRangeAsync = exports.UsersEx_GetTopObjLst = exports.UsersEx_GetTopObjLstAsync = exports.UsersEx_GetObjLst = exports.UsersEx_GetObjLstByUserIdLstAsync = exports.UsersEx_GetObjLstAsync = exports.UsersEx_GetFirstObj = exports.UsersEx_GetFirstObjAsync = exports.UsersEx_GetFirstID = exports.UsersEx_GetFirstIDAsync = exports.UsersEx_GetObjByUserId = exports.UsersEx_GetObjByUserIdAsync = exports.UsersEx_FilterFunByKey = exports.UsersEx_FuncMapByFldName = exports.UsersEx_SortFunByKey = exports.UsersEx_GetObjExLstByPagerAsync = exports.UsersEx_GetObjExLstByPager_Cache = exports.UsersEx_CopyToEx = exports.UsersEx_GetWebApiUrl = exports.usersEx_ConstructorName = exports.usersEx_Controller = void 0;
    /// <summary>
    /// 用户(Users)
    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by  on 2019年12月19日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    const $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    const clsUsersEN_js_1 = require("../../L0_Entity/UserManage/clsUsersEN.js");
    const stuPagerPara_js_1 = require("../../PubFun/stuPagerPara.js");
    const stuRangePara_js_1 = require("../../PubFun/stuRangePara.js");
    const stuTopPara_js_1 = require("../../PubFun/stuTopPara.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsUsersENEx_js_1 = require("../../L0_Entity/UserManage/clsUsersENEx.js");
    const clsUsersWApi_js_1 = require("../../L3_ForWApi/UserManage/clsUsersWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    exports.usersEx_Controller = "UsersExApi";
    exports.usersEx_ConstructorName = "usersEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function UsersEx_GetWebApiUrl(strController, strAction) {
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
    exports.UsersEx_GetWebApiUrl = UsersEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objUsersENS:源对象
    * @returns 目标对象=>clsUsersEN:objUsersENT
    **/
    function UsersEx_CopyToEx(objUsersENS) {
        const strThisFuncName = UsersEx_CopyToEx.name;
        const objUsersENT = new clsUsersENEx_js_1.clsUsersENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objUsersENT, objUsersENS);
            return objUsersENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.usersEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objUsersENT;
        }
    }
    exports.UsersEx_CopyToEx = UsersEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function UsersEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrUsersObjLst = await (0, clsUsersWApi_js_1.Users_GetObjLst_Cache)();
        const arrUsersExObjLst = arrUsersObjLst.map(UsersEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrUsersExObjLst) {
                const conFuncMap = await UsersEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrUsersExObjLst.length == 0)
            return arrUsersExObjLst;
        let arrUsers_Sel = arrUsersExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objUsers_Cond = new clsUsersENEx_js_1.clsUsersENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objUsers_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsUsersWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrUsers_Sel = arrUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrUsers_Sel.length == 0)
                return arrUsers_Sel;
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
                arrUsers_Sel = arrUsers_Sel.sort(UsersEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrUsers_Sel = arrUsers_Sel.sort(objPagerPara.sortFun);
            }
            arrUsers_Sel = arrUsers_Sel.slice(intStart, intEnd);
            return arrUsers_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.usersEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.UsersEx_GetObjExLstByPager_Cache = UsersEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function UsersEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrUsersExObjLst = await (0, clsUsersWApi_js_1.Users_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrUsersExObjLst) {
                const conFuncMap = await UsersEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrUsersExObjLst.length == 0)
            return arrUsersExObjLst;
        let arrUsers_Sel = arrUsersExObjLst;
        try {
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
                arrUsers_Sel = arrUsers_Sel.sort(UsersEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrUsers_Sel = arrUsers_Sel.sort(objPagerPara.sortFun);
            }
            arrUsers_Sel = arrUsers_Sel.slice(intStart, intEnd);
            return arrUsers_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.usersEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.UsersEx_GetObjExLstByPagerAsync = UsersEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function UsersEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsUsersWApi_js_1.Users_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsUsersWApi_js_1.Users_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.UsersEx_SortFunByKey = UsersEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function UsersEx_FuncMapByFldName(strFldName, objUsersEx) {
        const strThisFuncName = UsersEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsUsersEN_js_1.clsUsersEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.UsersEx_FuncMapByFldName = UsersEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function UsersEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsUsersWApi_js_1.Users_FilterFunByKey)(strKey, value);
        }
    }
    exports.UsersEx_FilterFunByKey = UsersEx_FilterFunByKey;
    /// <summary>
    /// 根据关键字获取相应的记录的对象
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    /// </summary>
    /// <param name = "strUserId">关键字</param>
    /// <returns>获取相应对象</returns>
    async function UsersEx_GetObjByUserIdAsync(strUserId) {
        var strAction = "GetObjByUserId";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("userId", strUserId);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_GetObjByUserIdAsync = UsersEx_GetObjByUserIdAsync;
    ;
    /// <summary>
    /// 根据关键字获取相应的记录的对象
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId)
    /// </summary>
    /// <param name = "strUserId">关键字</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取相应对象</returns>
    async function UsersEx_GetObjByUserId(strUserId, cb, errorCb) {
        var strAction = "GetObjByUserId";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("userId", strUserId);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_GetObjByUserId = UsersEx_GetObjByUserId;
    ;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>返回的第一条记录的关键字值</returns>
    async function UsersEx_GetFirstIDAsync(strWhereCond) {
        var strAction = "GetFirstID";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_GetFirstIDAsync = UsersEx_GetFirstIDAsync;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>返回的第一条记录的关键字值</returns>
    async function UsersEx_GetFirstID(strWhereCond, cb, errorCb) {
        var strAction = "GetFirstID";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_GetFirstID = UsersEx_GetFirstID;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象</returns>
    async function UsersEx_GetFirstObjAsync(strWhereCond) {
        var strAction = "GetFirstObj";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_GetFirstObjAsync = UsersEx_GetFirstObjAsync;
    ;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObj)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取的相应对象</returns>
    async function UsersEx_GetFirstObj(strWhereCond, cb, errorCb) {
        var strAction = "GetFirstObj";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_GetFirstObj = UsersEx_GetFirstObj;
    ;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function UsersEx_GetObjLstAsync(strWhereCond) {
        var strAction = "GetObjLst";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_GetObjLstAsync = UsersEx_GetObjLstAsync;
    ;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function UsersEx_GetObjLstByUserIdLstAsync(arrUserId) {
        var strAction = "GetObjLstByUserIdLst";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: { "": arrUserId },
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_GetObjLstByUserIdLstAsync = UsersEx_GetObjLstByUserIdLstAsync;
    ;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取的相应对象列表</returns>
    async function UsersEx_GetObjLst(strWhereCond, cb, errorCb) {
        var strAction = "GetObjLst";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_GetObjLst = UsersEx_GetObjLst;
    ;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    /// </summary>
    /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
    /// <returns>获取的相应对象列表</returns>
    async function UsersEx_GetTopObjLstAsync(objTopPara) {
        var strAction = "GetTopObjLst";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = stuTopPara_js_1.stuTopPara.GetMapParam(objTopPara);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objTopPara,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_GetTopObjLstAsync = UsersEx_GetTopObjLstAsync;
    ;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLst)
    /// </summary>
    /// <param name = "strWhereCond">给定条件</param>
    /// <param name = "intTopSize">顶部记录数</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取的相应对象列表</returns>
    async function UsersEx_GetTopObjLst(strWhereCond, intTopSize, cb, errorCb) {
        var strAction = "GetTopObjLst";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        mapParam.add("intTopSize", intTopSize);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_GetTopObjLst = UsersEx_GetTopObjLst;
    ;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    /// </summary>
    /// <param name = "objRangePara">根据范围获取对象列表的参数对象</param>
    /// <returns>获取的相应记录对象列表</returns>
    async function UsersEx_GetObjLstByRangeAsync(objRangePara) {
        var strAction = "GetObjLstByRange";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = stuRangePara_js_1.stuRangePara.GetMapParam(objRangePara);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objRangePara,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_GetObjLstByRangeAsync = UsersEx_GetObjLstByRangeAsync;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRange)
    /// </summary>
    /// <param name = "intMinNum">最小记录号</param>
    /// <param name = "intMaxNum">最大记录号</param>
    /// <param name = "strWhereCond">给定条件</param>
    /// <param name = "strOrderBy">排序方式</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取的相应记录对象列表</returns>
    async function UsersEx_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        var strAction = "GetObjLstByRange";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("intMinNum", intMinNum);
        mapParam.add("intMaxNum", intMaxNum);
        mapParam.add("strWhereCond", strWhereCond);
        mapParam.add("strOrderBy", strOrderBy);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_GetObjLstByRange = UsersEx_GetObjLstByRange;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    /// </summary>
    /// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
    /// <returns>获取的相应记录对象列表</returns>
    async function UsersEx_GetObjLstByPagerAsync(objPagerPara) {
        var strAction = "GetObjLstByPager";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = stuPagerPara_js_1.stuPagerPara.GetMapParam(objPagerPara);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objPagerPara,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_GetObjLstByPagerAsync = UsersEx_GetObjLstByPagerAsync;
    ;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager)
    /// </summary>
    /// <param name = "intPageIndex">页序号</param>
    /// <param name = "intPageSize">每页记录数</param>
    /// <param name = "strWhereCond">给定条件</param>
    /// <param name = "strOrderBy">排序方式</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取的相应记录对象列表</returns>
    async function UsersEx_GetObjLstByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy = "", cb, errorCb) {
        var strAction = "GetObjLstByPager";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("intPageIndex", intPageIndex);
        mapParam.add("intPageSize", intPageSize);
        mapParam.add("strWhereCond", strWhereCond);
        mapParam.add("strOrderBy", strOrderBy);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_GetObjLstByPager = UsersEx_GetObjLstByPager;
    ;
    /// <summary>
    /// 调用WebApi来删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    /// </summary>
    /// <param name = "strUserId">关键字</param>
    /// <returns>获取删除的结果</returns>
    async function UsersEx_DelRecordAsync(strUserId) {
        var strAction = "DelRecord";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        strUrl = `${strUrl}/${strUserId}`;
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strUserId", strUserId);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "DELETE",
                dataType: "json",
                data: { "": strUserId },
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_DelRecordAsync = UsersEx_DelRecordAsync;
    ;
    /// <summary>
    /// 调用WebApi来删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecord)
    /// </summary>
    /// <param name = "strUserId">关键字</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取删除的结果</returns>
    async function UsersEx_DelRecord(strUserId, cb, errorCb) {
        var strAction = "DelRecord";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        $.ajax({
            url: strUrl,
            method: "DELETE",
            dataType: "json",
            data: { "": strUserId },
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_DelRecord = UsersEx_DelRecord;
    ;
    /// <summary>
    /// 根据关键字列表删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    /// </summary>
    /// <param name = "arrUserId">关键字列表</param>
    /// <returns>实际删除记录的个数</returns>
    async function UsersEx_DelUserssAsync(arrUserId) {
        var strAction = "DelUserss";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: { "": arrUserId },
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_DelUserssAsync = UsersEx_DelUserssAsync;
    /// <summary>
    /// 根据关键字列表删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecord)
    /// </summary>
    /// <param name = "arrUserId">关键字列表</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>实际删除记录的个数</returns>
    async function UsersEx_DelUserss(arrUserId, cb, errorCb) {
        var strAction = "DelUserss";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        $.ajax({
            url: strUrl,
            method: "POST",
            dataType: "json",
            data: { "": arrUserId },
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_DelUserss = UsersEx_DelUserss;
    /// <summary>
    /// 根据条件删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    /// </summary>
    /// <returns>实际删除记录的个数</returns>
    async function UsersEx_DelUserssByCondAsync(strWhereCond) {
        var strAction = "DelUserssByCond";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: { "": strWhereCond },
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_DelUserssByCondAsync = UsersEx_DelUserssByCondAsync;
    /// <summary>
    /// 根据条件删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCond)
    /// </summary>
    /// <returns>实际删除记录的个数</returns>
    async function UsersEx_DelUserssByCond(strWhereCond, cb, errorCb) {
        var strAction = "DelUserssByCond";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        $.ajax({
            url: strUrl,
            method: "POST",
            dataType: "json",
            data: { "": strWhereCond },
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_DelUserssByCond = UsersEx_DelUserssByCond;
    /// <summary>
    /// 调用WebApi来添加记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    /// </summary>
    /// <param name = "objUsersEN">需要添加的对象</param>
    /// <returns>获取相应的记录的对象</returns>
    async function UsersEx_AddNewRecordAsync(objUsersEN) {
        var strMsg = "";
        var strAction = "AddNewRecord";
        if (objUsersEN.userId === null || objUsersEN.userId === "") {
            strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objUsersEN_Sim);
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objUsersEN,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_AddNewRecordAsync = UsersEx_AddNewRecordAsync;
    ;
    /// <summary>
    /// 调用WebApi来添加记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecord)
    /// </summary>
    /// <param name = "objUsersEN">需要添加的对象</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取相应的记录的对象</returns>
    async function UsersEx_AddNewRecord(objUsersEN, cb, errorCb) {
        var strMsg = "";
        var strAction = "AddNewRecord";
        if (objUsersEN.userId === null || objUsersEN.userId === "") {
            strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objUsersEN);
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        $.ajax({
            url: strUrl,
            method: "POST",
            dataType: "json",
            data: objUsersEN,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_AddNewRecord = UsersEx_AddNewRecord;
    ;
    /// <summary>
    /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    /// </summary>
    /// <param name = "objUsersEN">需要添加的表对象</param>
    /// <returns>返回新添加记录的关键字</returns>
    async function UsersEx_AddNewRecordWithReturnKeyAsync(objUsersEN) {
        var strAction = "AddNewRecordWithReturnKey";
        if (objUsersEN.userId === null || objUsersEN.userId === "") {
            var strMsg = "需要的对象的关键字为空，不能添加!";
            throw new Error(strMsg);
        }
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objUsersEN,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_AddNewRecordWithReturnKeyAsync = UsersEx_AddNewRecordWithReturnKeyAsync;
    /// <summary>
    /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
    /// </summary>
    /// <param name = "objUsersEN">需要添加的表对象</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>返回新添加记录的关键字</returns>
    async function UsersEx_AddNewRecordWithReturnKey(objUsersEN, cb, errorCb) {
        var strAction = "AddNewRecordWithReturnKey";
        if (objUsersEN.userId === null || objUsersEN.userId === "") {
            var strMsg = "需要的对象的关键字为空，不能添加!";
            throw new Error(strMsg);
        }
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        $.ajax({
            url: strUrl,
            method: "POST",
            dataType: "json",
            data: objUsersEN,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_AddNewRecordWithReturnKey = UsersEx_AddNewRecordWithReturnKey;
    /// <summary>
    /// 调用WebApi来修改记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    /// </summary>
    /// <param name = "objUsersEN">需要添加的对象</param>
    /// <returns>获取修改是否成功？</returns>
    async function UsersEx_UpdateRecordAsync(objUsersEN) {
        var strMsg = "";
        var strAction = "UpdateRecord";
        if (objUsersEN.sf_UpdFldSetStr === null || objUsersEN.sf_UpdFldSetStr === "") {
            strMsg = `对象(关键字: ${objUsersEN.userId})的【修改字段集】为空，不能修改!`;
            throw strMsg;
        }
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objUsersEN,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_UpdateRecordAsync = UsersEx_UpdateRecordAsync;
    ;
    /// <summary>
    /// 调用WebApi来修改记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecord)
    /// </summary>
    /// <param name = "objUsersEN">需要添加的对象</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取修改是否成功？</returns>
    async function UsersEx_UpdateRecord(objUsersEN, cb, errorCb) {
        var strMsg = "";
        var strAction = "UpdateRecord";
        if (objUsersEN.sf_UpdFldSetStr === null || objUsersEN.sf_UpdFldSetStr === "") {
            strMsg = `对象(关键字: ${objUsersEN.userId})的【修改字段集】为空，不能修改!`;
            throw strMsg;
        }
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        $.ajax({
            url: strUrl,
            method: "POST",
            dataType: "json",
            data: objUsersEN,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_UpdateRecord = UsersEx_UpdateRecord;
    ;
    /// <summary>
    /// 根据条件来修改记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordWithConditionAsync)
    /// </summary>
    /// <param name = "objUsersEN">需要修改的对象</param>
    /// <param name = "strWhereCond">条件串</param>
    /// <returns>返回的第一条记录的关键字值</returns>
    async function UsersEx_UpdateRecordWithConditionAsync(objUsersEN, strWhereCond) {
        var strAction = "UpdateRecordWithCondition";
        if (objUsersEN.sf_UpdFldSetStr === null || objUsersEN.sf_UpdFldSetStr === "") {
            var strMsg = `对象(关键字: ${objUsersEN.userId})的【修改字段集】为空，不能修改!`;
            throw new Error(strMsg);
        }
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_UpdateRecordWithConditionAsync = UsersEx_UpdateRecordWithConditionAsync;
    /// <summary>
    /// 根据条件来修改记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordWithCondition)
    /// </summary>
    /// <param name = "objUsersEN">需要修改的对象</param>
    /// <param name = "strWhereCond">条件串</param>
    /// <returns>返回的第一条记录的关键字值</returns>
    async function UsersEx_UpdateRecordWithCondition(objUsersEN, strWhereCond, cb, errorCb) {
        var strAction = "UpdateRecordWithCondition";
        if (objUsersEN.sf_UpdFldSetStr === null || objUsersEN.sf_UpdFldSetStr === "") {
            var strMsg = `对象(关键字: ${objUsersEN.userId})的【修改字段集】为空，不能修改!`;
            throw new Error(strMsg);
        }
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        $.ajax({
            url: strUrl,
            method: "POST",
            dataType: "json",
            data: {
                objUsersEN: objUsersEN,
                strWhereCond: strWhereCond
            },
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_UpdateRecordWithCondition = UsersEx_UpdateRecordWithCondition;
    /// <summary>
    /// 根据条件获取是否存在相应的记录？
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>是否存在记录？</returns>
    async function UsersEx_IsExistRecordAsync(strWhereCond) {
        var strAction = "IsExistRecord";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_IsExistRecordAsync = UsersEx_IsExistRecordAsync;
    ;
    /// <summary>
    /// 根据条件获取是否存在相应的记录？
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>是否存在记录？</returns>
    async function UsersEx_IsExistRecord(strWhereCond, cb, errorCb) {
        var strAction = "IsExistRecord";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_IsExistRecord = UsersEx_IsExistRecord;
    ;
    /// <summary>
    /// 根据关键字判断是否存在记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    /// </summary>
    /// <param name = "strUserId">关键字</param>
    /// <returns>是否存在?存在返回True</returns>
    async function UsersEx_IsExistAsync(strUserId) {
        //检测记录是否存在
        var strAction = "IsExist";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("userId", strUserId);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_IsExistAsync = UsersEx_IsExistAsync;
    /// <summary>
    /// 根据关键字判断是否存在记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
    /// </summary>
    /// <param name = "strUserId">关键字</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>是否存在?存在返回True</returns>
    async function UsersEx_IsExist(strUserId, cb, errorCb) {
        //检测记录是否存在
        var strAction = "IsExist";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("userId", strUserId);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_IsExist = UsersEx_IsExist;
    /// <summary>
    /// 获取某一条件的记录数
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funGetRecCountByCondAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取某一条件的记录数</returns>
    async function UsersEx_GetRecCountByCondAsync(strWhereCond) {
        var strAction = "GetRecCountByCond";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_GetRecCountByCondAsync = UsersEx_GetRecCountByCondAsync;
    ;
    /// <summary>
    /// 获取某一条件的记录数
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funGetRecCountByCond)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取某一条件的记录数</returns>
    async function UsersEx_GetRecCountByCond(strWhereCond, cb, errorCb) {
        var strAction = "GetRecCountByCond";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_GetRecCountByCond = UsersEx_GetRecCountByCond;
    ;
    /// <summary>
    /// 获取表的最大关键字
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    /// </summary>
    /// <returns>获取表的最大关键字</returns>
    async function UsersEx_GetMaxStrIdAsync() {
        var strAction = "GetMaxStrId";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_GetMaxStrIdAsync = UsersEx_GetMaxStrIdAsync;
    ;
    /// <summary>
    /// 获取表的最大关键字
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrId)
    /// </summary>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取表的最大关键字</returns>
    async function UsersEx_GetMaxStrId(cb, errorCb) {
        var strAction = "GetMaxStrId";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_GetMaxStrId = UsersEx_GetMaxStrId;
    ;
    /// <summary>
    /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefixAsync)
    /// </summary>
    /// <param name = "mapParam">参数列表</param>
    /// <returns>获取当前表关键字值的最大值</returns>
    async function UsersEx_GetMaxStrIdByPrefixAsync(strPrefix) {
        var strAction = "GetMaxStrIdByPrefix";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strPrefix", strPrefix);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.UsersEx_GetMaxStrIdByPrefixAsync = UsersEx_GetMaxStrIdByPrefixAsync;
    ;
    /// <summary>
    /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
    /// </summary>
    /// <param name = "mapParam">参数列表</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取当前表关键字值的最大值</returns>
    async function UsersEx_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        var strAction = "GetMaxStrIdByPrefix";
        let strUrl = UsersEx_GetWebApiUrl(exports.usersEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strPrefix", strPrefix);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText);
                errorCb(strErrMsg);
            }
        });
    }
    exports.UsersEx_GetMaxStrIdByPrefix = UsersEx_GetMaxStrIdByPrefix;
    ;
});
