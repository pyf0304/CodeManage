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
        define(["require", "exports", "jquery", "../../L0_Entity/GraduateEduPaper/clsPaperEN.js", "../../L0_Entity/GraduateEduPaper/clsPaperENEx.js", "../../L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsCommonFunc4Web2.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsSysPara4WebApi2.js", "../../PubFun/tzDictionary.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperEx_GetObjLstByPagerById_CurrEduCls_Cache = exports.PaperEx_GetRecCountByCondById_CurrEduCls_Cache = exports.PaperEx_GetSubObjLstById_CurrEduCls_Cache = exports.PaperEx_GetObjLstById_CurrEduCls_sessionStorage = exports.PaperEx_GetObjLstById_CurrEduCls_localStorage = exports.PaperEx_GetObjLstById_CurrEduCls_ClientCache = exports.PaperEx_GetObjLstById_CurrEduCls_Cache = exports.PaperEx_ReFreshThisCacheById_CurrEduCls = exports.PaperEx_GetObjByPaperIdById_CurrEduCls_Cache = exports.PaperEx_GetObjLstById_CurrEduCls = exports.PaperEx_BindDdl_PaperIdInDivById_CurrEduCls_Cache = exports.PaperEx_FilterFunByKey = exports.PaperEx_FuncMapByFldName = exports.PaperEx_SortFunByKey = exports.PaperEx_GetObjExLstByPagerAsync = exports.PaperEx_GetObjExLstByPager_Cache = exports.PaperEx_CopyToEx = exports.PaperEx_GetWebApiUrl = exports.paperEx_ConstructorName = exports.paperEx_Controller = void 0;
    /// <summary>
    /// 论文表(Paper)
    /// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by pyf on 2021年06月11日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    const $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    const clsPaperEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsPaperENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperENEx.js");
    const clsPaperWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsCommonFunc4Web2_js_1 = require("../../PubFun/clsCommonFunc4Web2.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsSysPara4WebApi2_js_1 = require("../../PubFun/clsSysPara4WebApi2.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    exports.paperEx_Controller = "PaperExApi";
    exports.paperEx_ConstructorName = "paperEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function PaperEx_GetWebApiUrl(strController, strAction) {
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
    exports.PaperEx_GetWebApiUrl = PaperEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objPaperENS:源对象
    * @returns 目标对象=>clsPaperEN:objPaperENT
    **/
    function PaperEx_CopyToEx(objPaperENS) {
        const strThisFuncName = PaperEx_CopyToEx.name;
        const objPaperENT = new clsPaperENEx_js_1.clsPaperENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperENT, objPaperENS);
            return objPaperENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.paperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objPaperENT;
        }
    }
    exports.PaperEx_CopyToEx = PaperEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function PaperEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrPaperObjLst = await (0, clsPaperWApi_js_1.Paper_GetObjLst_Cache)();
        const arrPaperExObjLst = arrPaperObjLst.map(PaperEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrPaperExObjLst) {
                const conFuncMap = await PaperEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrPaperExObjLst.length == 0)
            return arrPaperExObjLst;
        let arrPaper_Sel = arrPaperExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objPaper_Cond = new clsPaperENEx_js_1.clsPaperENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaper_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsPaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrPaper_Sel = arrPaper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPaper_Sel.length == 0)
                return arrPaper_Sel;
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
                arrPaper_Sel = arrPaper_Sel.sort(PaperEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrPaper_Sel = arrPaper_Sel.sort(objPagerPara.sortFun);
            }
            arrPaper_Sel = arrPaper_Sel.slice(intStart, intEnd);
            return arrPaper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.paperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperEx_GetObjExLstByPager_Cache = PaperEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function PaperEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrPaperExObjLst = await (0, clsPaperWApi_js_1.Paper_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrPaperExObjLst) {
                const conFuncMap = await PaperEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrPaperExObjLst.length == 0)
            return arrPaperExObjLst;
        let arrPaper_Sel = arrPaperExObjLst;
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
                arrPaper_Sel = arrPaper_Sel.sort(PaperEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrPaper_Sel = arrPaper_Sel.sort(objPagerPara.sortFun);
            }
            arrPaper_Sel = arrPaper_Sel.slice(intStart, intEnd);
            return arrPaper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.paperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperEx_GetObjExLstByPagerAsync = PaperEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsPaperWApi_js_1.Paper_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsPaperWApi_js_1.Paper_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.PaperEx_SortFunByKey = PaperEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function PaperEx_FuncMapByFldName(strFldName, objPaperEx) {
        const strThisFuncName = PaperEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsPaperEN_js_1.clsPaperEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.PaperEx_FuncMapByFldName = PaperEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function PaperEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsPaperWApi_js_1.Paper_FilterFunByKey)(strKey, value);
        }
    }
    exports.PaperEx_FilterFunByKey = PaperEx_FilterFunByKey;
    /// <summary>
    /// 绑定基于Web的下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    async function PaperEx_BindDdl_PaperIdInDivById_CurrEduCls_Cache(strDivName, strDdlName, strid_CurrEduCls) {
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！(In BindDdl_PaperIdInDiv_Cache)`;
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_PaperIdInDiv_Cache");
        var arrObjLst_Sel = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsPaperEN_js_1.clsPaperEN.con_PaperId, clsPaperEN_js_1.clsPaperEN.con_PaperTitle, "论文表");
    }
    exports.PaperEx_BindDdl_PaperIdInDivById_CurrEduCls_Cache = PaperEx_BindDdl_PaperIdInDivById_CurrEduCls_Cache;
    /// <summary>
    /// 根据教学班获取对象列表，用对象列表表示
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
    /// </summary>
    /// <param name = "strId_CurrEduCls">教学班流水号</param>
    /// <returns>获取的相应对象列表</returns>
    async function PaperEx_GetObjLstById_CurrEduCls(strId_CurrEduCls) {
        var strAction = "GetObjLstById_CurrEduCls";
        let strUrl = PaperEx_GetWebApiUrl(exports.paperEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strId_CurrEduCls", strId_CurrEduCls);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "Get",
                dataType: "json",
                data: strData,
                success: function (data) {
                    if (data.ErrorId == 0) {
                        var returnObjLst = JSON.parse(data.ReturnObjLst);
                        //console.log(returnObjLst);
                        resolve(returnObjLst);
                    }
                    else {
                        console.error(data.ErrorMsg);
                        reject(data.ErrorMsg);
                    }
                },
                error: function (result) {
                    console.error(result);
                    console.error(JSON.stringify(result));
                    if (result.statusText == "error") {
                        var strInfo = `网络错误！访问地址:${strUrl} 不成功！`;
                        reject(strInfo);
                    }
                    else {
                        reject(result.statusText);
                    }
                }
            });
        });
    }
    exports.PaperEx_GetObjLstById_CurrEduCls = PaperEx_GetObjLstById_CurrEduCls;
    ;
    /// <summary>
    /// 根据关键字获取相关对象, 从缓存中获取.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
    /// </summary>
    /// <param name = "strPaperId">所给的关键字</param>
    /// <returns>对象</returns>
    async function PaperEx_GetObjByPaperIdById_CurrEduCls_Cache(strPaperId, strid_CurrEduCls) {
        var arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        var obj = new clsPaperEN_js_1.clsPaperEN();
        try {
            var arrPaper_Sel = arrPaperObjLst_Cache.filter(x => x.paperId == strPaperId);
            var objPaper;
            if (arrPaper_Sel.length > 0) {
                objPaper = arrPaper_Sel[0];
                return objPaper;
            }
            else {
                return obj;
            }
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据关键字:[${strPaperId}]获取相应的对象不成功!`;
            console.error(strMsg);
            alert(strMsg);
        }
        return obj;
    }
    exports.PaperEx_GetObjByPaperIdById_CurrEduCls_Cache = PaperEx_GetObjByPaperIdById_CurrEduCls_Cache;
    ;
    /// <summary>
    /// 刷新本类中的缓存.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    /// </summary>
    async function PaperEx_ReFreshThisCacheById_CurrEduCls(strid_CurrEduCls) {
        var strMsg = "";
        if (clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.spSetRefreshCacheOn == true) {
            var strKey = `${clsPaperEN_js_1.clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
            switch (clsPaperEN_js_1.clsPaperEN.CacheModeId) {
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
            strMsg = `刷新缓存成功！`,
                console.trace(strMsg);
        }
        else {
            strMsg = `刷新缓存已经关闭。`;
            console.trace(strMsg);
        }
    }
    exports.PaperEx_ReFreshThisCacheById_CurrEduCls = PaperEx_ReFreshThisCacheById_CurrEduCls;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls) {
        var arrPaperObjLst_Cache;
        switch (clsPaperEN_js_1.clsPaperEN.CacheModeId) {
            case "04": //sessionStorage
                arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls);
                break;
        }
        return arrPaperObjLst_Cache;
    }
    exports.PaperEx_GetObjLstById_CurrEduCls_Cache = PaperEx_GetObjLstById_CurrEduCls_Cache;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function PaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsPaperEN_js_1.clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            var arrPaperObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            return arrPaperObjLst_Cache;
        }
        try {
            const responseText = await PaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
            var arrPaperObjLst = responseText;
            CacheHelper_js_1.CacheHelper.Add(strKey, arrPaperObjLst);
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperObjLst.length}!`;
            console.log(strInfo);
            return arrPaperObjLst;
        }
        catch (e) {
            var strMsg = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperEx_GetObjLstById_CurrEduCls_ClientCache = PaperEx_GetObjLstById_CurrEduCls_ClientCache;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function PaperEx_GetObjLstById_CurrEduCls_localStorage(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsPaperEN_js_1.clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (localStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            var strTempObjLst = localStorage.getItem(strKey);
            var arrPaperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperObjLst_Cache;
        }
        try {
            const responseText = await PaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
            var arrPaperObjLst = responseText;
            localStorage.setItem(strKey, JSON.stringify(arrPaperObjLst));
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperObjLst.length}!`;
            console.log(strInfo);
            return arrPaperObjLst;
        }
        catch (e) {
            var strMsg = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperEx_GetObjLstById_CurrEduCls_localStorage = PaperEx_GetObjLstById_CurrEduCls_localStorage;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function PaperEx_GetObjLstById_CurrEduCls_sessionStorage(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsPaperEN_js_1.clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            var strTempObjLst = sessionStorage.getItem(strKey);
            var arrPaperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperObjLst_Cache;
        }
        try {
            const responseText = await PaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
            var arrPaperObjLst = responseText;
            sessionStorage.setItem(strKey, JSON.stringify(arrPaperObjLst));
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperObjLst.length}!`;
            console.log(strInfo);
            return arrPaperObjLst;
        }
        catch (e) {
            var strMsg = `从缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperEx_GetObjLstById_CurrEduCls_sessionStorage = PaperEx_GetObjLstById_CurrEduCls_sessionStorage;
    /// <summary>
    /// 根据条件对象, 从缓存的对象列表中获取子集.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
    /// </summary>
    /// <param name = "objstrSubViewpointId_Cond">条件对象</param>
    /// <returns>对象列表子集</returns>
    async function PaperEx_GetSubObjLstById_CurrEduCls_Cache(objPaper_Cond, strid_CurrEduCls) {
        var arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        var arrPaper_Sel = arrPaperObjLst_Cache.filter(x => true);
        if (objPaper_Cond.sf_FldComparisonOp == null || objPaper_Cond.sf_FldComparisonOp == "")
            return arrPaper_Sel;
        var dicFldComparisonOp = JSON.parse(objPaper_Cond.sf_FldComparisonOp);
        //console.log("clsPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objPaper_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = objPaper_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            return arrPaper_Sel;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${JSON.stringify(objPaper_Cond)}]缓存对象列表中获取子集对象不成功!`;
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperEx_GetSubObjLstById_CurrEduCls_Cache = PaperEx_GetSubObjLstById_CurrEduCls_Cache;
    ;
    /// <summary>
    /// 根据条件对象, 从缓存的对象列表中获取记录数.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
    /// </summary>
    /// <param name = "objPaper_Cond">条件对象</param>
    /// <returns>对象列表记录数</returns>
    async function PaperEx_GetRecCountByCondById_CurrEduCls_Cache(objPaper_Cond, strid_CurrEduCls) {
        var arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        var arrPaper_Sel = arrPaperObjLst_Cache.filter(x => true);
        if (objPaper_Cond.sf_FldComparisonOp == null || objPaper_Cond.sf_FldComparisonOp == "")
            return arrPaper_Sel.length;
        var dicFldComparisonOp = JSON.parse(objPaper_Cond.sf_FldComparisonOp);
        //console.log("clsPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objPaper_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = objPaper_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            return arrPaper_Sel.length;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${JSON.stringify(objPaper_Cond)}]从缓存对象列表中获取记录数不成功!`;
            console.error(strMsg);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.PaperEx_GetRecCountByCondById_CurrEduCls_Cache = PaperEx_GetRecCountByCondById_CurrEduCls_Cache;
    ;
    /// <summary>
    /// 从缓存中获取分页对象列表.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
    /// </summary>
    /// <param name = "objPagerPara">分页参数结构</param>
    /// <returns>对象列表</returns>
    async function PaperEx_GetObjLstByPagerById_CurrEduCls_Cache(objPagerPara, strid_CurrEduCls) {
        var arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        if (arrPaperObjLst_Cache.length == 0)
            return arrPaperObjLst_Cache;
        var arrPaper_Sel = arrPaperObjLst_Cache.filter(x => true);
        var obj_Cond = JSON.parse(objPagerPara.whereCond);
        var dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsPaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(obj_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = obj_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            if (arrPaper_Sel.length == 0)
                return arrPaper_Sel;
            var intStart = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
            if (intStart <= 0)
                intStart = 0;
            var intEnd = intStart + objPagerPara.pageSize;
            if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
                var sstrSplit = objPagerPara.orderBy.split(" ");
                var strSortType = "asc";
                var strSortFld = sstrSplit[0];
                if (sstrSplit.length > 1)
                    strSortType = sstrSplit[1];
                //                console.log(arrPaper_Sel);
                let objFirst = arrPaper_Sel[0]; //第一个对象
                let strSortValue = objFirst[strSortFld]; //第一个对象排序字段值            
                let strSortFldType = typeof (strSortValue); //排序字段值的数据类型
                //console.log("排序字段的数据类型: " + strSortFldType);
                switch (strSortFldType) {
                    case "string":
                        if (strSortType.toLowerCase() == "asc") {
                            arrPaper_Sel = arrPaper_Sel.sort((x, y) => x[strSortFld].localeCompare(y[strSortFld]));
                        }
                        else {
                            arrPaper_Sel = arrPaper_Sel.sort((x, y) => y[strSortFld].localeCompare(x[strSortFld]));
                        }
                        break;
                    case "number":
                    case "boolean":
                        if (strSortType.toLowerCase() == "asc") {
                            arrPaper_Sel = arrPaper_Sel.sort((x, y) => x[strSortFld] - y[strSortFld]);
                        }
                        else {
                            arrPaper_Sel = arrPaper_Sel.sort((x, y) => y[strSortFld] - x[strSortFld]);
                        }
                        break;
                }
            }
            else {
                //如果排序字段名[orderBy]为空，就调用排序函数
                arrPaper_Sel = arrPaper_Sel.sort(objPagerPara.sortFun);
            }
            arrPaper_Sel = arrPaper_Sel.slice(intStart, intEnd);
            return arrPaper_Sel;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${objPagerPara.whereCond}]获取分页对象列表不成功!(In Paper_GetObjLstByPager_Cache)`;
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperEx_GetObjLstByPagerById_CurrEduCls_Cache = PaperEx_GetObjLstByPagerById_CurrEduCls_Cache;
    ;
});
