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
        define(["require", "exports", "jquery", "../../L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js", "../../PubFun/tzDictionary.js", "../../L0_Entity/GraduateEduPaper/clsvPaperSubViewpointENEx.js", "../../L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vPaperSubViewpointEx_GetSubViewpointTypeNumObjLstAsync = exports.vPaperSubViewpointEx_GetSubViewpointNumObjLstAsync = exports.vPaperSubViewpointEx_FilterFunByKey = exports.vPaperSubViewpointEx_FuncMapByFldName = exports.vPaperSubViewpointEx_SortFunByKey = exports.vPaperSubViewpointEx_GetObjExLstByPagerAsync = exports.vPaperSubViewpointEx_GetObjExLstByPager_Cache = exports.vPaperSubViewpointEx_CopyToEx = exports.vPaperSubViewpointEx_GetWebApiUrl = exports.vPaperSubViewpointEx_ConstructorName = exports.vPaperSubViewpointEx_Controller = void 0;
    const $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    const clsvPaperSubViewpointEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsvPaperSubViewpointENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperSubViewpointENEx.js");
    const clsvPaperSubViewpointWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    exports.vPaperSubViewpointEx_Controller = "vPaperSubViewpointExApi";
    exports.vPaperSubViewpointEx_ConstructorName = "vPaperSubViewpointEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vPaperSubViewpointEx_GetWebApiUrl(strController, strAction) {
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
    exports.vPaperSubViewpointEx_GetWebApiUrl = vPaperSubViewpointEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvPaperSubViewpointENS:源对象
    * @returns 目标对象=>clsvPaperSubViewpointEN:objvPaperSubViewpointENT
    **/
    function vPaperSubViewpointEx_CopyToEx(objvPaperSubViewpointENS) {
        const strThisFuncName = vPaperSubViewpointEx_CopyToEx.name;
        const objvPaperSubViewpointENT = new clsvPaperSubViewpointENEx_js_1.clsvPaperSubViewpointENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperSubViewpointENT, objvPaperSubViewpointENS);
            return objvPaperSubViewpointENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vPaperSubViewpointEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvPaperSubViewpointENT;
        }
    }
    exports.vPaperSubViewpointEx_CopyToEx = vPaperSubViewpointEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vPaperSubViewpointEx_GetObjExLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvPaperSubViewpointObjLst = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetObjLst_Cache)(strid_CurrEduCls);
        const arrvPaperSubViewpointExObjLst = arrvPaperSubViewpointObjLst.map(vPaperSubViewpointEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvPaperSubViewpointExObjLst) {
                const conFuncMap = await vPaperSubViewpointEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvPaperSubViewpointExObjLst.length == 0)
            return arrvPaperSubViewpointExObjLst;
        let arrvPaperSubViewpoint_Sel = arrvPaperSubViewpointExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvPaperSubViewpoint_Cond = new clsvPaperSubViewpointENEx_js_1.clsvPaperSubViewpointENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperSubViewpoint_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvPaperSubViewpointWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperSubViewpoint_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaperSubViewpoint_Sel.length == 0)
                return arrvPaperSubViewpoint_Sel;
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
                arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.sort(vPaperSubViewpointEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.slice(intStart, intEnd);
            return arrvPaperSubViewpoint_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vPaperSubViewpointEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperSubViewpointEx_GetObjExLstByPager_Cache = vPaperSubViewpointEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vPaperSubViewpointEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvPaperSubViewpointExObjLst = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvPaperSubViewpointExObjLst) {
                const conFuncMap = await vPaperSubViewpointEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvPaperSubViewpointExObjLst.length == 0)
            return arrvPaperSubViewpointExObjLst;
        let arrvPaperSubViewpoint_Sel = arrvPaperSubViewpointExObjLst;
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
                arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.sort(vPaperSubViewpointEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.slice(intStart, intEnd);
            return arrvPaperSubViewpoint_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vPaperSubViewpointEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperSubViewpointEx_GetObjExLstByPagerAsync = vPaperSubViewpointEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperSubViewpointEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vPaperSubViewpointEx_SortFunByKey = vPaperSubViewpointEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vPaperSubViewpointEx_FuncMapByFldName(strFldName, objvPaperSubViewpointEx) {
        const strThisFuncName = vPaperSubViewpointEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vPaperSubViewpointEx_FuncMapByFldName = vPaperSubViewpointEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vPaperSubViewpointEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_FilterFunByKey)(strKey, value);
        }
    }
    exports.vPaperSubViewpointEx_FilterFunByKey = vPaperSubViewpointEx_FilterFunByKey;
    /// <summary>
    /// 获取论文中的用户数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function vPaperSubViewpointEx_GetSubViewpointNumObjLstAsync(strWhereCond) {
        var strAction = "GetSubViewpointNumObjLst";
        let strUrl = vPaperSubViewpointEx_GetWebApiUrl(exports.vPaperSubViewpointEx_Controller, strAction);
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
    exports.vPaperSubViewpointEx_GetSubViewpointNumObjLstAsync = vPaperSubViewpointEx_GetSubViewpointNumObjLstAsync;
    ;
    /// <summary>
    /// 获取论文中的评论数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function vPaperSubViewpointEx_GetSubViewpointTypeNumObjLstAsync(strWhereCond) {
        var strAction = "GetSubViewpointTypeNumObjLst";
        let strUrl = vPaperSubViewpointEx_GetWebApiUrl(exports.vPaperSubViewpointEx_Controller, strAction);
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
    exports.vPaperSubViewpointEx_GetSubViewpointTypeNumObjLstAsync = vPaperSubViewpointEx_GetSubViewpointTypeNumObjLstAsync;
    ;
});
