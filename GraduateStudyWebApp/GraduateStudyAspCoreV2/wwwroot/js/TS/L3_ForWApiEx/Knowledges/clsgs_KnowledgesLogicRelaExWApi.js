/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_KnowledgesLogicRelaExWApi
表名:gs_KnowledgesLogicRela(01120870)
生成代码版本:2021.01.26.1
生成日期:2021/01/26 23:47:45
生成者:lyl
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:知识点相关
模块英文名:Knowledges
框架-层名:WA_访问扩展层(WA_AccessEx)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == ==
*/
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "axios", "../../L0_Entity/Knowledges/clsgs_KnowledgesLogicRelaEN.js", "../../L0_Entity/Knowledges/clsgs_KnowledgesLogicRelaENEx.js", "../../L3_ForWApi/Knowledges/clsgs_KnowledgesLogicRelaWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_KnowledgesLogicRelaEx_AddNewRecordAsync = exports.gs_KnowledgesLogicRelaEx_FilterFunByKey = exports.gs_KnowledgesLogicRelaEx_FuncMapByFldName = exports.gs_KnowledgesLogicRelaEx_SortFunByKey = exports.gs_KnowledgesLogicRelaEx_GetObjExLstByPagerAsync = exports.gs_KnowledgesLogicRelaEx_GetObjExLstByPager_Cache = exports.gs_KnowledgesLogicRelaEx_CopyToEx = exports.gs_KnowledgesLogicRelaEx_GetWebApiUrl = exports.gs_KnowledgesLogicRelaEx_ConstructorName = exports.gs_KnowledgesLogicRelaEx_Controller = void 0;
    /// <summary>
    /// 知识点逻辑关系表(gs_KnowledgesLogicRela)
    /// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by lyl on 2021年01月26日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    const axios_1 = __importDefault(require("axios"));
    //import * as QQ from "q";
    const clsgs_KnowledgesLogicRelaEN_js_1 = require("../../L0_Entity/Knowledges/clsgs_KnowledgesLogicRelaEN.js");
    const clsgs_KnowledgesLogicRelaENEx_js_1 = require("../../L0_Entity/Knowledges/clsgs_KnowledgesLogicRelaENEx.js");
    const clsgs_KnowledgesLogicRelaWApi_js_1 = require("../../L3_ForWApi/Knowledges/clsgs_KnowledgesLogicRelaWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    exports.gs_KnowledgesLogicRelaEx_Controller = "gs_KnowledgesLogicRelaExApi";
    exports.gs_KnowledgesLogicRelaEx_ConstructorName = "gs_KnowledgesLogicRelaEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function gs_KnowledgesLogicRelaEx_GetWebApiUrl(strController, strAction) {
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
    exports.gs_KnowledgesLogicRelaEx_GetWebApiUrl = gs_KnowledgesLogicRelaEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objgs_KnowledgesLogicRelaENS:源对象
    * @returns 目标对象=>clsgs_KnowledgesLogicRelaEN:objgs_KnowledgesLogicRelaENT
    **/
    function gs_KnowledgesLogicRelaEx_CopyToEx(objgs_KnowledgesLogicRelaENS) {
        const strThisFuncName = gs_KnowledgesLogicRelaEx_CopyToEx.name;
        const objgs_KnowledgesLogicRelaENT = new clsgs_KnowledgesLogicRelaENEx_js_1.clsgs_KnowledgesLogicRelaENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_KnowledgesLogicRelaENT, objgs_KnowledgesLogicRelaENS);
            return objgs_KnowledgesLogicRelaENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.gs_KnowledgesLogicRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objgs_KnowledgesLogicRelaENT;
        }
    }
    exports.gs_KnowledgesLogicRelaEx_CopyToEx = gs_KnowledgesLogicRelaEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_KnowledgesLogicRelaEx_GetObjExLstByPager_Cache(objPagerPara, strKnowledgeGraphId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_KnowledgesLogicRelaObjLst = await (0, clsgs_KnowledgesLogicRelaWApi_js_1.gs_KnowledgesLogicRela_GetObjLst_Cache)(strKnowledgeGraphId);
        const arrgs_KnowledgesLogicRelaExObjLst = arrgs_KnowledgesLogicRelaObjLst.map(gs_KnowledgesLogicRelaEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_KnowledgesLogicRelaExObjLst) {
                const conFuncMap = await gs_KnowledgesLogicRelaEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_KnowledgesLogicRelaExObjLst.length == 0)
            return arrgs_KnowledgesLogicRelaExObjLst;
        let arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRelaExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_KnowledgesLogicRela_Cond = new clsgs_KnowledgesLogicRelaENEx_js_1.clsgs_KnowledgesLogicRelaENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_KnowledgesLogicRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_KnowledgesLogicRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_KnowledgesLogicRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_KnowledgesLogicRela_Sel.length == 0)
                return arrgs_KnowledgesLogicRela_Sel;
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
                arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.sort(gs_KnowledgesLogicRelaEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.slice(intStart, intEnd);
            return arrgs_KnowledgesLogicRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_KnowledgesLogicRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_KnowledgesLogicRelaEx_GetObjExLstByPager_Cache = gs_KnowledgesLogicRelaEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_KnowledgesLogicRelaEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrgs_KnowledgesLogicRelaObjLst = await (0, clsgs_KnowledgesLogicRelaWApi_js_1.gs_KnowledgesLogicRela_GetObjLstAsync)(objPagerPara.whereCond);
        const arrgs_KnowledgesLogicRelaExObjLst = arrgs_KnowledgesLogicRelaObjLst.map(gs_KnowledgesLogicRelaEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_KnowledgesLogicRelaExObjLst) {
                const conFuncMap = await gs_KnowledgesLogicRelaEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_KnowledgesLogicRelaExObjLst.length == 0)
            return arrgs_KnowledgesLogicRelaExObjLst;
        let arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRelaExObjLst;
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
                arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.sort(gs_KnowledgesLogicRelaEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_KnowledgesLogicRela_Sel = arrgs_KnowledgesLogicRela_Sel.slice(intStart, intEnd);
            return arrgs_KnowledgesLogicRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_KnowledgesLogicRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_KnowledgesLogicRelaEx_GetObjExLstByPagerAsync = gs_KnowledgesLogicRelaEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_KnowledgesLogicRelaEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsgs_KnowledgesLogicRelaWApi_js_1.gs_KnowledgesLogicRela_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsgs_KnowledgesLogicRelaWApi_js_1.gs_KnowledgesLogicRela_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.gs_KnowledgesLogicRelaEx_SortFunByKey = gs_KnowledgesLogicRelaEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function gs_KnowledgesLogicRelaEx_FuncMapByFldName(strFldName, objgs_KnowledgesLogicRelaEx) {
        const strThisFuncName = gs_KnowledgesLogicRelaEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsgs_KnowledgesLogicRelaEN_js_1.clsgs_KnowledgesLogicRelaEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.gs_KnowledgesLogicRelaEx_FuncMapByFldName = gs_KnowledgesLogicRelaEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_KnowledgesLogicRelaEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsgs_KnowledgesLogicRelaWApi_js_1.gs_KnowledgesLogicRela_FilterFunByKey)(strKey, value);
        }
    }
    exports.gs_KnowledgesLogicRelaEx_FilterFunByKey = gs_KnowledgesLogicRelaEx_FilterFunByKey;
    /// <summary>
    /// 调用WebApi来添加记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    /// </summary>
    /// <param name = "objgs_UserRelaEN">需要添加的对象</param>
    /// <returns>获取相应的记录的对象</returns>
    //public static AddNewRecordAsync(arrgs_UserRelaPosition :Array<clsgs_UserRelaPositionEN>): Promise<boolean> {
    async function gs_KnowledgesLogicRelaEx_AddNewRecordAsync(strJSON) {
        const strThisFuncName = "";
        var strMsg = "";
        var strAction = "AddNewRecord";
        let strUrl = gs_KnowledgesLogicRelaEx_GetWebApiUrl(exports.gs_KnowledgesLogicRelaEx_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, strJSON);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRelaEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesLogicRelaEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesLogicRelaEx_AddNewRecordAsync = gs_KnowledgesLogicRelaEx_AddNewRecordAsync;
});
