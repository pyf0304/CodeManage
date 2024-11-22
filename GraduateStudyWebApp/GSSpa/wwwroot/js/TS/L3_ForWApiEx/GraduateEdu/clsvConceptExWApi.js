/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvConceptWApi
表名:vConcept(01120619)
生成代码版本:2020.04.24.1
生成日期:2020/04/25 09:43:23
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
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
        define(["require", "exports", "jquery", "../../L0_Entity/GraduateEduTopic/clsvConceptEN.js", "../../PubFun/clsCommonFunc4Web2.js", "../../L0_Entity/UserManage/clsUsersEN.js", "../../L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js", "../../PubFun/clsPublocalStorage.js", "../../PubFun/tzDictionary.js", "../../L0_Entity/GraduateEduTopic/clsvConceptENEx.js", "../../L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vConceptEx_GetUsersByvConcept = exports.vConceptEx_IsExist = exports.vConceptEx_uniq = exports.vConceptEx_BindDdl_UserIdInvConcept_Cache = exports.vConceptEx_GetConceptUserObjLstAsync = exports.vConceptEx_FilterFunByKey = exports.vConceptEx_FuncMapByFldName = exports.vConceptEx_SortFunByKey = exports.vConceptEx_GetObjExLstByPagerAsync = exports.vConceptEx_GetObjExLstByPager_Cache = exports.vConceptEx_CopyToEx = exports.vConceptEx_GetWebApiUrl = exports.vConceptEx_ConstructorName = exports.vConceptEx_Controller = void 0;
    /// <summary>
    /// vConcept(vConcept)
    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by  on 2020年04月25日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    const $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    const clsvConceptEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvConceptEN.js");
    const clsCommonFunc4Web2_js_1 = require("../../PubFun/clsCommonFunc4Web2.js");
    const clsUsersEN_js_1 = require("../../L0_Entity/UserManage/clsUsersEN.js");
    const clsvConceptWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js");
    const clsPublocalStorage_js_1 = require("../../PubFun/clsPublocalStorage.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsvConceptENEx_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvConceptENEx.js");
    const clsvConceptWApi_js_2 = require("../../L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    exports.vConceptEx_Controller = "vConceptExApi";
    exports.vConceptEx_ConstructorName = "vConceptEx";
    //public static cacheModeId = "02"; //客户端缓存
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vConceptEx_GetWebApiUrl(strController, strAction) {
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
    exports.vConceptEx_GetWebApiUrl = vConceptEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvConceptENS:源对象
    * @returns 目标对象=>clsvConceptEN:objvConceptENT
    **/
    function vConceptEx_CopyToEx(objvConceptENS) {
        const strThisFuncName = vConceptEx_CopyToEx.name;
        const objvConceptENT = new clsvConceptENEx_js_1.clsvConceptENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvConceptENT, objvConceptENS);
            return objvConceptENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vConceptEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvConceptENT;
        }
    }
    exports.vConceptEx_CopyToEx = vConceptEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vConceptEx_GetObjExLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvConceptObjLst = await (0, clsvConceptWApi_js_1.vConcept_GetObjLst_Cache)(strid_CurrEduCls);
        const arrvConceptExObjLst = arrvConceptObjLst.map(vConceptEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvConceptExObjLst) {
                const conFuncMap = await vConceptEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvConceptExObjLst.length == 0)
            return arrvConceptExObjLst;
        let arrvConcept_Sel = arrvConceptExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvConcept_Cond = new clsvConceptENEx_js_1.clsvConceptENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvConcept_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvConceptWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvConcept_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvConcept_Sel.length == 0)
                return arrvConcept_Sel;
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
                arrvConcept_Sel = arrvConcept_Sel.sort(vConceptEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvConcept_Sel = arrvConcept_Sel.sort(objPagerPara.sortFun);
            }
            arrvConcept_Sel = arrvConcept_Sel.slice(intStart, intEnd);
            return arrvConcept_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vConceptEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vConceptEx_GetObjExLstByPager_Cache = vConceptEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vConceptEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvConceptExObjLst = await (0, clsvConceptWApi_js_2.vConcept_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvConceptExObjLst) {
                const conFuncMap = await vConceptEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvConceptExObjLst.length == 0)
            return arrvConceptExObjLst;
        let arrvConcept_Sel = arrvConceptExObjLst;
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
                arrvConcept_Sel = arrvConcept_Sel.sort(vConceptEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvConcept_Sel = arrvConcept_Sel.sort(objPagerPara.sortFun);
            }
            arrvConcept_Sel = arrvConcept_Sel.slice(intStart, intEnd);
            return arrvConcept_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vConceptEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vConceptEx_GetObjExLstByPagerAsync = vConceptEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vConceptEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsvConceptWApi_js_2.vConcept_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsvConceptWApi_js_2.vConcept_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vConceptEx_SortFunByKey = vConceptEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vConceptEx_FuncMapByFldName(strFldName, objvConceptEx) {
        const strThisFuncName = vConceptEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvConceptEN_js_1.clsvConceptEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vConceptEx_FuncMapByFldName = vConceptEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vConceptEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsvConceptWApi_js_1.vConcept_FilterFunByKey)(strKey, value);
        }
    }
    exports.vConceptEx_FilterFunByKey = vConceptEx_FilterFunByKey;
    /// <summary>
    /// 获取论文中的用户数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function vConceptEx_GetConceptUserObjLstAsync(strWhereCond) {
        var strAction = "GetConceptUserObjLst";
        let strUrl = vConceptEx_GetWebApiUrl(exports.vConceptEx_Controller, strAction);
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
                    if (data.ErrorId == 0) {
                        var returnObjLst = JSON.parse(data.ReturnObjLst);
                        //console.log(returnObjLst);
                        resolve(returnObjLst);
                    }
                    else {
                        console.log(data.ErrorMsg);
                        reject(data.ErrorMsg);
                    }
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.vConceptEx_GetConceptUserObjLstAsync = vConceptEx_GetConceptUserObjLstAsync;
    ;
    //从概念表中得到用户数据
    /// <summary>
    /// 绑定基于Web的下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    async function vConceptEx_BindDdl_UserIdInvConcept_Cache(strDdlName, objUsers_Cond) {
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_UserIdInvConcept_Cache");
        var arrvConcept = await (0, clsvConceptWApi_js_1.vConcept_GetObjLst_Cache)(clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
        var arrObjLst_Sel = arrvConcept.map(vConceptEx_GetUsersByvConcept);
        arrObjLst_Sel = vConceptEx_uniq(arrObjLst_Sel);
        console.log(arrObjLst_Sel);
        arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsUsersEN_js_1.clsUsersEN.con_UserName]);
        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsUsersEN_js_1.clsUsersEN.con_UserId, clsUsersEN_js_1.clsUsersEN.con_UserName, "编辑用户");
    }
    exports.vConceptEx_BindDdl_UserIdInvConcept_Cache = vConceptEx_BindDdl_UserIdInvConcept_Cache;
    function vConceptEx_uniq(arr) {
        let arrObjLst_New = new Array();
        for (let x of arr) {
            if (vConceptEx_IsExist(arrObjLst_New, x) == false) {
                arrObjLst_New.push(x);
            }
        }
        return arrObjLst_New;
    }
    exports.vConceptEx_uniq = vConceptEx_uniq;
    function vConceptEx_IsExist(arr, key) {
        let arr_Sel = arr.filter(x => x.userId == key.userId);
        if (arr_Sel.length > 0)
            return true;
        return false;
    }
    exports.vConceptEx_IsExist = vConceptEx_IsExist;
    function vConceptEx_GetUsersByvConcept(objvConcept) {
        var objUsers = new clsUsersEN_js_1.clsUsersEN();
        objUsers.userId = objvConcept.updUser;
        //objUsers.userName = objvConcept.userName;
        return objUsers;
    }
    exports.vConceptEx_GetUsersByvConcept = vConceptEx_GetUsersByvConcept;
});
