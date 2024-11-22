/// <summary>
/// 论文读写表(qa_Answer)
/// (AutoGCLib.WA_Access4TypeScript:GeneCode)
/// </summary>
/**
* Created by  on 2020年01月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/InteractManage/clsvqa_AnswerEN.js", "../../PubFun/tzDictionary.js", "../../L0_Entity/InteractManage/clsvqa_AnswerENEx.js", "../../L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js", "axios"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vqa_AnswerEx_Getvqa_AnswerUserNumObjLstAsync = exports.vqa_AnswerEx_Getvqa_AnswerTopicIdNumObjLstAsync = exports.vqa_AnswerEx_FilterFunByKey = exports.vqa_AnswerEx_FuncMapByFldName = exports.vqa_AnswerEx_SortFunByKey = exports.vqa_AnswerEx_GetObjExLstByPagerAsync = exports.vqa_AnswerEx_GetObjExLstByPager_Cache = exports.vqa_AnswerEx_CopyToEx = exports.vqa_AnswerEx_GetWebApiUrl = exports.vqa_AnswerEx_ConstructorName = exports.vqa_AnswerEx_Controller = void 0;
    //import * as QQ from "q";
    const clsvqa_AnswerEN_js_1 = require("../../L0_Entity/InteractManage/clsvqa_AnswerEN.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsvqa_AnswerENEx_js_1 = require("../../L0_Entity/InteractManage/clsvqa_AnswerENEx.js");
    const clsvqa_AnswerWApi_js_1 = require("../../L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const axios_1 = __importDefault(require("axios"));
    exports.vqa_AnswerEx_Controller = "vqa_AnswerExApi";
    exports.vqa_AnswerEx_ConstructorName = "vqa_AnswerEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vqa_AnswerEx_GetWebApiUrl(strController, strAction) {
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
    exports.vqa_AnswerEx_GetWebApiUrl = vqa_AnswerEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvqa_AnswerENS:源对象
    * @returns 目标对象=>clsvqa_AnswerEN:objvqa_AnswerENT
    **/
    function vqa_AnswerEx_CopyToEx(objvqa_AnswerENS) {
        const strThisFuncName = vqa_AnswerEx_CopyToEx.name;
        const objvqa_AnswerENT = new clsvqa_AnswerENEx_js_1.clsvqa_AnswerENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvqa_AnswerENT, objvqa_AnswerENS);
            return objvqa_AnswerENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vqa_AnswerEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvqa_AnswerENT;
        }
    }
    exports.vqa_AnswerEx_CopyToEx = vqa_AnswerEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vqa_AnswerEx_GetObjExLstByPager_Cache(objPagerPara, strTopicId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvqa_AnswerObjLst = await (0, clsvqa_AnswerWApi_js_1.vqa_Answer_GetObjLst_Cache)(strTopicId);
        const arrvqa_AnswerExObjLst = arrvqa_AnswerObjLst.map(vqa_AnswerEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvqa_AnswerExObjLst) {
                const conFuncMap = await vqa_AnswerEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvqa_AnswerExObjLst.length == 0)
            return arrvqa_AnswerExObjLst;
        let arrvqa_Answer_Sel = arrvqa_AnswerExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvqa_Answer_Cond = new clsvqa_AnswerENEx_js_1.clsvqa_AnswerENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvqa_Answer_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvqa_AnswerWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvqa_Answer_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvqa_Answer_Sel.length == 0)
                return arrvqa_Answer_Sel;
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
                arrvqa_Answer_Sel = arrvqa_Answer_Sel.sort(vqa_AnswerEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvqa_Answer_Sel = arrvqa_Answer_Sel.sort(objPagerPara.sortFun);
            }
            arrvqa_Answer_Sel = arrvqa_Answer_Sel.slice(intStart, intEnd);
            return arrvqa_Answer_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vqa_AnswerEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vqa_AnswerEx_GetObjExLstByPager_Cache = vqa_AnswerEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vqa_AnswerEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvqa_AnswerExObjLst = await (0, clsvqa_AnswerWApi_js_1.vqa_Answer_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvqa_AnswerExObjLst) {
                const conFuncMap = await vqa_AnswerEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvqa_AnswerExObjLst.length == 0)
            return arrvqa_AnswerExObjLst;
        let arrvqa_Answer_Sel = arrvqa_AnswerExObjLst;
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
                arrvqa_Answer_Sel = arrvqa_Answer_Sel.sort(vqa_AnswerEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvqa_Answer_Sel = arrvqa_Answer_Sel.sort(objPagerPara.sortFun);
            }
            arrvqa_Answer_Sel = arrvqa_Answer_Sel.slice(intStart, intEnd);
            return arrvqa_Answer_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vqa_AnswerEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vqa_AnswerEx_GetObjExLstByPagerAsync = vqa_AnswerEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vqa_AnswerEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsvqa_AnswerWApi_js_1.vqa_Answer_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsvqa_AnswerWApi_js_1.vqa_Answer_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vqa_AnswerEx_SortFunByKey = vqa_AnswerEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vqa_AnswerEx_FuncMapByFldName(strFldName, objvqa_AnswerEx) {
        const strThisFuncName = vqa_AnswerEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vqa_AnswerEx_FuncMapByFldName = vqa_AnswerEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vqa_AnswerEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsvqa_AnswerWApi_js_1.vqa_Answer_FilterFunByKey)(strKey, value);
        }
    }
    exports.vqa_AnswerEx_FilterFunByKey = vqa_AnswerEx_FilterFunByKey;
    /// <summary>
    /// 获取论文中的用户数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function vqa_AnswerEx_Getvqa_AnswerTopicIdNumObjLstAsync(strWhereCond) {
        const strThisFuncName = "AnswerTopicIdNumObjLstAsync";
        var strAction = "Getvqa_AnswerTopicIdNumObjLst";
        let strUrl = vqa_AnswerEx_GetWebApiUrl(exports.vqa_AnswerEx_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_AnswerEx_Controller, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = (0, clsvqa_AnswerWApi_js_1.vqa_Answer_GetObjLstByJSONObjLst)(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_AnswerEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_AnswerEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_AnswerEx_Getvqa_AnswerTopicIdNumObjLstAsync = vqa_AnswerEx_Getvqa_AnswerTopicIdNumObjLstAsync;
    /// <summary>
    /// 获取论文中的用户数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function vqa_AnswerEx_Getvqa_AnswerUserNumObjLstAsync(strWhereCond) {
        const strThisFuncName = "Getvqa_AnswerUserNumObjLstAsync";
        var strAction = "Getvqa_AnswerUserNumObjLst";
        let strUrl = vqa_AnswerEx_GetWebApiUrl(exports.vqa_AnswerEx_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_AnswerEx_Controller, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = (0, clsvqa_AnswerWApi_js_1.vqa_Answer_GetObjLstByJSONObjLst)(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_AnswerEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_AnswerEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_AnswerEx_Getvqa_AnswerUserNumObjLstAsync = vqa_AnswerEx_Getvqa_AnswerUserNumObjLstAsync;
});
