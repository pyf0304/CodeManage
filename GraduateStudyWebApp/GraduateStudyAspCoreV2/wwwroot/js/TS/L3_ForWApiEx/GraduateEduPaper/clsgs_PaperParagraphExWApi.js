var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsgs_PaperParagraphEN.js", "../../L0_Entity/GraduateEduPaper/clsgs_PaperParagraphENEx.js", "../../L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphVerWApi.js", "../../L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/tzDictionary.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperParagraphEx_GetObjLstAsync = exports.gs_PaperParagraphEx_FilterFunByKey = exports.gs_PaperParagraphEx_FuncMapByFldName = exports.gs_PaperParagraphEx_SortFunByKey = exports.gs_PaperParagraphEx_GetObjExLstByPagerAsync = exports.gs_PaperParagraphEx_GetObjExLstByPager_Cache = exports.gs_PaperParagraphEx_CopyToEx = exports.gs_PaperParagraphEx_GetWebApiUrl = exports.gs_PaperParagraphEx_ConstructorName = exports.gs_PaperParagraphEx_Controller = void 0;
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    const axios_1 = __importDefault(require("axios"));
    //import * as QQ from "q";
    const clsgs_PaperParagraphEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperParagraphEN.js");
    const clsgs_PaperParagraphENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperParagraphENEx.js");
    const clsgs_PaperParagraphVerWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphVerWApi.js");
    const clsgs_PaperParagraphWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    exports.gs_PaperParagraphEx_Controller = "gs_PaperParagraphExApi";
    exports.gs_PaperParagraphEx_ConstructorName = "gs_PaperParagraphEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function gs_PaperParagraphEx_GetWebApiUrl(strController, strAction) {
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
    exports.gs_PaperParagraphEx_GetWebApiUrl = gs_PaperParagraphEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objgs_PaperParagraphENS:源对象
    * @returns 目标对象=>clsgs_PaperParagraphEN:objgs_PaperParagraphENT
    **/
    function gs_PaperParagraphEx_CopyToEx(objgs_PaperParagraphENS) {
        const strThisFuncName = gs_PaperParagraphEx_CopyToEx.name;
        const objgs_PaperParagraphENT = new clsgs_PaperParagraphENEx_js_1.clsgs_PaperParagraphENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PaperParagraphENT, objgs_PaperParagraphENS);
            return objgs_PaperParagraphENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.gs_PaperParagraphEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objgs_PaperParagraphENT;
        }
    }
    exports.gs_PaperParagraphEx_CopyToEx = gs_PaperParagraphEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_PaperParagraphEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_PaperParagraphObjLst = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_GetObjLst_Cache)();
        const arrgs_PaperParagraphExObjLst = arrgs_PaperParagraphObjLst.map(gs_PaperParagraphEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_PaperParagraphExObjLst) {
                const conFuncMap = await gs_PaperParagraphEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_PaperParagraphExObjLst.length == 0)
            return arrgs_PaperParagraphExObjLst;
        let arrgs_PaperParagraph_Sel = arrgs_PaperParagraphExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_PaperParagraph_Cond = new clsgs_PaperParagraphENEx_js_1.clsgs_PaperParagraphENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PaperParagraph_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_PaperParagraphWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperParagraph_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_PaperParagraph_Sel.length == 0)
                return arrgs_PaperParagraph_Sel;
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
                arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.sort(gs_PaperParagraphEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.slice(intStart, intEnd);
            return arrgs_PaperParagraph_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_PaperParagraphEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_PaperParagraphEx_GetObjExLstByPager_Cache = gs_PaperParagraphEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_PaperParagraphEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrgs_PaperParagraphExObjLst = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_PaperParagraphExObjLst) {
                const conFuncMap = await gs_PaperParagraphEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_PaperParagraphExObjLst.length == 0)
            return arrgs_PaperParagraphExObjLst;
        let arrgs_PaperParagraph_Sel = arrgs_PaperParagraphExObjLst;
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
                arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.sort(gs_PaperParagraphEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.slice(intStart, intEnd);
            return arrgs_PaperParagraph_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_PaperParagraphEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_PaperParagraphEx_GetObjExLstByPagerAsync = gs_PaperParagraphEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperParagraphEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.gs_PaperParagraphEx_SortFunByKey = gs_PaperParagraphEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function gs_PaperParagraphEx_FuncMapByFldName(strFldName, objgs_PaperParagraphEx) {
        const strThisFuncName = gs_PaperParagraphEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.gs_PaperParagraphEx_FuncMapByFldName = gs_PaperParagraphEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_PaperParagraphEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_FilterFunByKey)(strKey, value);
        }
    }
    exports.gs_PaperParagraphEx_FilterFunByKey = gs_PaperParagraphEx_FilterFunByKey;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function gs_PaperParagraphEx_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        var strAction = "GetObjLst";
        let strUrl = gs_PaperParagraphEx_GetWebApiUrl(exports.gs_PaperParagraphEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraphEx_Controller, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = (0, clsgs_PaperParagraphVerWApi_js_1.gs_PaperParagraphVer_GetObjLstByJSONObjLst)(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraphEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraphEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraphEx_GetObjLstAsync = gs_PaperParagraphEx_GetObjLstAsync;
});
