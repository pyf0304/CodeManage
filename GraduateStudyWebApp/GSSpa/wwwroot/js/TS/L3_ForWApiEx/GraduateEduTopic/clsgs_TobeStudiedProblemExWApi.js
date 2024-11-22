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
        define(["require", "exports", "jquery", "../../L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemEN.js", "../../PubFun/tzDictionary.js", "../../L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemENEx.js", "../../L3_ForWApi/GraduateEduTopic/clsgs_TobeStudiedProblemWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_TobeStudiedProblemEx_GetProblemDateNumObjLstAsync = exports.gs_TobeStudiedProblemEx_GetProblemMonthNumObjLstAsync = exports.gs_TobeStudiedProblemEx_GetProblemYearNumObjLstAsync = exports.gs_TobeStudiedProblemEx_FilterFunByKey = exports.gs_TobeStudiedProblemEx_FuncMapByFldName = exports.gs_TobeStudiedProblemEx_SortFunByKey = exports.gs_TobeStudiedProblemEx_GetObjExLstByPagerAsync = exports.gs_TobeStudiedProblemEx_CopyToEx = exports.gs_TobeStudiedProblemEx_GetWebApiUrl = exports.gs_TobeStudiedProblemEx_ConstructorName = exports.gs_TobeStudiedProblemEx_Controller = void 0;
    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by  on 2019年12月25日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    const $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    const clsgs_TobeStudiedProblemEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemEN.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsgs_TobeStudiedProblemENEx_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemENEx.js");
    const clsgs_TobeStudiedProblemWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsgs_TobeStudiedProblemWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    exports.gs_TobeStudiedProblemEx_Controller = "gs_TobeStudiedProblemExApi";
    exports.gs_TobeStudiedProblemEx_ConstructorName = "gs_TobeStudiedProblemEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function gs_TobeStudiedProblemEx_GetWebApiUrl(strController, strAction) {
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
    exports.gs_TobeStudiedProblemEx_GetWebApiUrl = gs_TobeStudiedProblemEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objgs_TobeStudiedProblemENS:源对象
    * @returns 目标对象=>clsgs_TobeStudiedProblemEN:objgs_TobeStudiedProblemENT
    **/
    function gs_TobeStudiedProblemEx_CopyToEx(objgs_TobeStudiedProblemENS) {
        const strThisFuncName = gs_TobeStudiedProblemEx_CopyToEx.name;
        const objgs_TobeStudiedProblemENT = new clsgs_TobeStudiedProblemENEx_js_1.clsgs_TobeStudiedProblemENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TobeStudiedProblemENT, objgs_TobeStudiedProblemENS);
            return objgs_TobeStudiedProblemENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.gs_TobeStudiedProblemEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objgs_TobeStudiedProblemENT;
        }
    }
    exports.gs_TobeStudiedProblemEx_CopyToEx = gs_TobeStudiedProblemEx_CopyToEx;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_TobeStudiedProblemEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrgs_TobeStudiedProblemExObjLst = await (0, clsgs_TobeStudiedProblemWApi_js_1.gs_TobeStudiedProblem_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_TobeStudiedProblemExObjLst) {
                const conFuncMap = await gs_TobeStudiedProblemEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_TobeStudiedProblemExObjLst.length == 0)
            return arrgs_TobeStudiedProblemExObjLst;
        let arrgs_TobeStudiedProblem_Sel = arrgs_TobeStudiedProblemExObjLst;
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
                arrgs_TobeStudiedProblem_Sel = arrgs_TobeStudiedProblem_Sel.sort(gs_TobeStudiedProblemEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_TobeStudiedProblem_Sel = arrgs_TobeStudiedProblem_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_TobeStudiedProblem_Sel = arrgs_TobeStudiedProblem_Sel.slice(intStart, intEnd);
            return arrgs_TobeStudiedProblem_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_TobeStudiedProblemEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TobeStudiedProblemEx_GetObjExLstByPagerAsync = gs_TobeStudiedProblemEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TobeStudiedProblemEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsgs_TobeStudiedProblemWApi_js_1.gs_TobeStudiedProblem_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsgs_TobeStudiedProblemWApi_js_1.gs_TobeStudiedProblem_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.gs_TobeStudiedProblemEx_SortFunByKey = gs_TobeStudiedProblemEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function gs_TobeStudiedProblemEx_FuncMapByFldName(strFldName, objgs_TobeStudiedProblemEx) {
        const strThisFuncName = gs_TobeStudiedProblemEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.gs_TobeStudiedProblemEx_FuncMapByFldName = gs_TobeStudiedProblemEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_TobeStudiedProblemEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsgs_TobeStudiedProblemWApi_js_1.gs_TobeStudiedProblem_FilterFunByKey)(strKey, value);
        }
    }
    exports.gs_TobeStudiedProblemEx_FilterFunByKey = gs_TobeStudiedProblemEx_FilterFunByKey;
    /// <summary>
    /// 获取会议年数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function gs_TobeStudiedProblemEx_GetProblemYearNumObjLstAsync(strWhereCond) {
        var strAction = "GetProblemYearNumObjLst";
        let strUrl = gs_TobeStudiedProblemEx_GetWebApiUrl(exports.gs_TobeStudiedProblemEx_Controller, strAction);
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
    exports.gs_TobeStudiedProblemEx_GetProblemYearNumObjLstAsync = gs_TobeStudiedProblemEx_GetProblemYearNumObjLstAsync;
    ;
    /// <summary>
    /// 获取会议月份数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function gs_TobeStudiedProblemEx_GetProblemMonthNumObjLstAsync(strWhereCond) {
        var strAction = "GetProblemMonthNumObjLst";
        let strUrl = gs_TobeStudiedProblemEx_GetWebApiUrl(exports.gs_TobeStudiedProblemEx_Controller, strAction);
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
    exports.gs_TobeStudiedProblemEx_GetProblemMonthNumObjLstAsync = gs_TobeStudiedProblemEx_GetProblemMonthNumObjLstAsync;
    ;
    /// <summary>
    /// 获取会议日期数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function gs_TobeStudiedProblemEx_GetProblemDateNumObjLstAsync(strWhereCond) {
        var strAction = "GetProblemDateNumObjLst";
        let strUrl = gs_TobeStudiedProblemEx_GetWebApiUrl(exports.gs_TobeStudiedProblemEx_Controller, strAction);
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
    exports.gs_TobeStudiedProblemEx_GetProblemDateNumObjLstAsync = gs_TobeStudiedProblemEx_GetProblemDateNumObjLstAsync;
    ;
});
