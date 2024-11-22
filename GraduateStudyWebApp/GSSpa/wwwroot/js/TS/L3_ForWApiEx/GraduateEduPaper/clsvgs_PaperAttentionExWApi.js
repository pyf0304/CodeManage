/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvgs_PaperAttentionExWApi
表名:vgs_PaperAttention(01120750)
生成代码版本:2020.09.24.1
生成日期:2020/09/28 12:21:56
生成者:pyf2
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培论文
模块英文名:GraduateEduPaper
框架-层名:WA_访问扩展层(WA_AccessEx)
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
        define(["require", "exports", "jquery", "../../L0_Entity/GraduateEduPaper/clsvgs_PaperAttentionEN.js", "../../L0_Entity/GraduateEduPaper/clsvgs_PaperAttentionENEx.js", "../../PubFun/tzDictionary.js", "../../L3_ForWApi/GraduateEduPaper/clsvgs_PaperAttentionWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_PaperAttentionEx_GetPaperIdNumObjLstAsync = exports.vgs_PaperAttentionEx_FilterFunByKey = exports.vgs_PaperAttentionEx_FuncMapByFldName = exports.vgs_PaperAttentionEx_SortFunByKey = exports.vgs_PaperAttentionEx_GetObjExLstByPagerAsync = exports.vgs_PaperAttentionEx_GetObjExLstByPager_Cache = exports.vgs_PaperAttentionEx_CopyToEx = exports.vgs_PaperAttentionEx_GetWebApiUrl = exports.vgs_PaperAttentionEx_ConstructorName = exports.vgs_PaperAttentionEx_Controller = void 0;
    /// <summary>
    /// vgs_PaperAttention(vgs_PaperAttention)
    /// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by pyf2 on 2020年09月28日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    const $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    const clsvgs_PaperAttentionEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvgs_PaperAttentionEN.js");
    const clsvgs_PaperAttentionENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvgs_PaperAttentionENEx.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    var ResponseData;
    //export class clsvgs_PaperAttentionExWApi {
    //    public static mstrController: string = "vgs_PaperAttentionExApi";
    const clsvgs_PaperAttentionWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsvgs_PaperAttentionWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    exports.vgs_PaperAttentionEx_Controller = "vgs_PaperAttentionExApi";
    exports.vgs_PaperAttentionEx_ConstructorName = "vgs_PaperAttentionEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vgs_PaperAttentionEx_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_PaperAttentionEx_GetWebApiUrl = vgs_PaperAttentionEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvgs_PaperAttentionENS:源对象
    * @returns 目标对象=>clsvgs_PaperAttentionEN:objvgs_PaperAttentionENT
    **/
    function vgs_PaperAttentionEx_CopyToEx(objvgs_PaperAttentionENS) {
        const strThisFuncName = vgs_PaperAttentionEx_CopyToEx.name;
        const objvgs_PaperAttentionENT = new clsvgs_PaperAttentionENEx_js_1.clsvgs_PaperAttentionENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_PaperAttentionENT, objvgs_PaperAttentionENS);
            return objvgs_PaperAttentionENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vgs_PaperAttentionEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvgs_PaperAttentionENT;
        }
    }
    exports.vgs_PaperAttentionEx_CopyToEx = vgs_PaperAttentionEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vgs_PaperAttentionEx_GetObjExLstByPager_Cache(objPagerPara, strUserId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvgs_PaperAttentionObjLst = await (0, clsvgs_PaperAttentionWApi_js_1.vgs_PaperAttention_GetObjLst_Cache)(strUserId);
        const arrvgs_PaperAttentionExObjLst = arrvgs_PaperAttentionObjLst.map(vgs_PaperAttentionEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvgs_PaperAttentionExObjLst) {
                const conFuncMap = await vgs_PaperAttentionEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvgs_PaperAttentionExObjLst.length == 0)
            return arrvgs_PaperAttentionExObjLst;
        let arrvgs_PaperAttention_Sel = arrvgs_PaperAttentionExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvgs_PaperAttention_Cond = new clsvgs_PaperAttentionENEx_js_1.clsvgs_PaperAttentionENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_PaperAttention_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvgs_PaperAttentionWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_PaperAttention_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_PaperAttention_Sel.length == 0)
                return arrvgs_PaperAttention_Sel;
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
                arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.sort(vgs_PaperAttentionEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.sort(objPagerPara.sortFun);
            }
            arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.slice(intStart, intEnd);
            return arrvgs_PaperAttention_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vgs_PaperAttentionEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_PaperAttentionEx_GetObjExLstByPager_Cache = vgs_PaperAttentionEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vgs_PaperAttentionEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvgs_PaperAttentionExObjLst = await (0, clsvgs_PaperAttentionWApi_js_1.vgs_PaperAttention_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvgs_PaperAttentionExObjLst) {
                const conFuncMap = await vgs_PaperAttentionEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvgs_PaperAttentionExObjLst.length == 0)
            return arrvgs_PaperAttentionExObjLst;
        let arrvgs_PaperAttention_Sel = arrvgs_PaperAttentionExObjLst;
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
                arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.sort(vgs_PaperAttentionEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.sort(objPagerPara.sortFun);
            }
            arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.slice(intStart, intEnd);
            return arrvgs_PaperAttention_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vgs_PaperAttentionEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_PaperAttentionEx_GetObjExLstByPagerAsync = vgs_PaperAttentionEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PaperAttentionEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsvgs_PaperAttentionWApi_js_1.vgs_PaperAttention_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsvgs_PaperAttentionWApi_js_1.vgs_PaperAttention_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vgs_PaperAttentionEx_SortFunByKey = vgs_PaperAttentionEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vgs_PaperAttentionEx_FuncMapByFldName(strFldName, objvgs_PaperAttentionEx) {
        const strThisFuncName = vgs_PaperAttentionEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvgs_PaperAttentionEN_js_1.clsvgs_PaperAttentionEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vgs_PaperAttentionEx_FuncMapByFldName = vgs_PaperAttentionEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_PaperAttentionEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsvgs_PaperAttentionWApi_js_1.vgs_PaperAttention_FilterFunByKey)(strKey, value);
        }
    }
    exports.vgs_PaperAttentionEx_FilterFunByKey = vgs_PaperAttentionEx_FilterFunByKey;
    /// <summary>
    /// 获取论文中的用户数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function vgs_PaperAttentionEx_GetPaperIdNumObjLstAsync(strWhereCond) {
        var strAction = "GetPaperIdNumObjLst";
        let strUrl = vgs_PaperAttentionEx_GetWebApiUrl(exports.vgs_PaperAttentionEx_Controller, strAction);
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
    exports.vgs_PaperAttentionEx_GetPaperIdNumObjLstAsync = vgs_PaperAttentionEx_GetPaperIdNumObjLstAsync;
    ;
});
